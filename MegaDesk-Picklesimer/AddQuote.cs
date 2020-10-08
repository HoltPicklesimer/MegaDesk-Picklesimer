using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace MegaDesk_Picklesimer
{
    public partial class AddQuote : Form
    {
        private Form _MainMenu;

        public AddQuote(Form mainMenu)
        {
            InitializeComponent();

            _MainMenu = mainMenu;

            // Material Selector
            var materials = Enum.GetValues(typeof(DesktopMaterials))
                            .Cast<DesktopMaterials>()
                            .ToList();

            cmbMaterial.DataSource = materials;
            // Select no option
            cmbMaterial.SelectedIndex = -1;

            // Shipping Selector
            var shippingOptions = Enum.GetValues(typeof(DeliveryOptions))
                            .Cast<DeliveryOptions>()
                            .ToList();

            cmbDelivery.DataSource = shippingOptions;
            // Select no option
            cmbDelivery.SelectedIndex = -1;

            // Set the date
            lblDate.Text = DateTime.Now.ToShortDateString();

            // Set min/mx of controls
            nWidth.Minimum = Desk.MIN_WIDTH;
            nWidth.Maximum = Desk.MAX_WIDTH;
            nDepth.Minimum = Desk.MIN_DEPTH;
            nDepth.Maximum = Desk.MAX_DEPTH;
            nDrawers.Minimum = Desk.MIN_DRAWERS;
            nDrawers.Maximum = Desk.MAX_DRAWERS;
        }

        private void AddQuote_FormClosed(object sender, FormClosedEventArgs e)
        {
            _MainMenu.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateFields())
                {
                    var newDesk = new Desk()
                    {
                        Width = nWidth.Value,
                        Depth = nDepth.Value,
                        Drawers = (int)nDrawers.Value,
                        SurfaceMaterial = (DesktopMaterials)cmbMaterial.SelectedValue
                    };

                    var newQuote = new DeskQuote()
                    {
                        CustomerName = txtName.Text,
                        DeliveryOption = (DeliveryOptions)cmbDelivery.SelectedValue,
                        Desk = newDesk,
                        QuoteDate = DateTime.Now
                    };

                    newQuote.PriceQuote = newQuote.CalculatePriceQuote();

                    AddQuoteToFile(newQuote);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(string.Format("Error: {0}, Stack Trace: {1}", ex.Message, ex.StackTrace));
            }
        }

        // Checks the fields to make sure they are filled in with valid values.
        private bool ValidateFields()
        {
            var errorMessage = string.Empty;

            if (string.IsNullOrEmpty(txtName.Text))
                errorMessage += "Please enter a name for this order.\n";

            var materialsCount = cmbMaterial.Items.Count;
            if (cmbMaterial.SelectedIndex < 0 || cmbMaterial.SelectedIndex > materialsCount)
                errorMessage += "Please select a surface material.\n";

            var shippingOptionCount = cmbDelivery.Items.Count;
            if (cmbDelivery.SelectedIndex < 0 || cmbDelivery.SelectedIndex > shippingOptionCount)
                errorMessage += "Please select a shipping option.\n";

            // Display a message if any field is empty or wrong
            if (errorMessage != string.Empty)
            {
                var message = string.Format(
                        "Please fix the following before the form can be submitted:\n{0}",
                        errorMessage
                    );
                MessageBox.Show(message);

                return false;
            }
            else
            {
                return true;
            }
        }

        private void AddQuoteToFile(DeskQuote deskQuote)
        {
            var quotesFile = @"quotes.json";
            List<DeskQuote> deskQuotes = new List<DeskQuote>();

            // read existing quotes
            if (File.Exists(quotesFile))
            {
                using (StreamReader reader = new StreamReader(quotesFile))
                {
                    string quotes = reader.ReadToEnd();

                    if (quotes.Length > 0)
                    {
                        // deserialize quotes
                        deskQuotes = JsonConvert.DeserializeObject<List<DeskQuote>>(quotes);
                    }
                }
            }

            // Add the quote to the list
            deskQuotes.Add(deskQuote);

            // Save the new list to the file
            SaveQuotes(deskQuotes);

            // Display the new quote
            DisplayNewQuote(deskQuote);
        }

        private void SaveQuotes(List<DeskQuote> deskQuotes)
        {
            var quotesFile = @"quotes.json";

            // If the file does not exist, create it
            if (!File.Exists(quotesFile))
            {
                File.Create(quotesFile);
            }

            using (StreamWriter writer = new StreamWriter(quotesFile))
            {
                string jsonObject = JsonConvert.SerializeObject(deskQuotes);
                writer.Write(jsonObject);
            }
        }

        private void DisplayNewQuote(DeskQuote newQuote)
        {
            var displayQuote = new DisplayQuote(_MainMenu, newQuote);
            displayQuote.StartPosition = FormStartPosition.Manual;
            displayQuote.Location = Location;
            displayQuote.Show();
            Close();
            _MainMenu.Hide();
        }
    }
}
