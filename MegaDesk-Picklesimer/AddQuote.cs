using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            var materials = Enum.GetValues(typeof(DesktopMaterial))
                            .Cast<DesktopMaterial>()
                            .ToList();

            cmbMaterial.DataSource = materials;
            // Select no option
            cmbMaterial.SelectedIndex = -1;

            // Shipping Selector
            var shippingOptions = Enum.GetValues(typeof(ShippingOption))
                            .Cast<ShippingOption>()
                            .ToList();

            cmbShip.DataSource = shippingOptions;
            // Select no option
            cmbShip.SelectedIndex = -1;

            // Set the date
            lblDate.Text = DateTime.Now.ToShortDateString();
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
                CheckFields();
            }
            catch(Exception ex)
            {
                MessageBox.Show(string.Format("Error: {0}, Stack Trace: {1}", ex.Message, ex.StackTrace));
            }
        }

        // Checks the fields to make sure they are filled in with valid values.
        private void CheckFields()
        {
            var errorMessage = string.Empty;

            var materialsCount = cmbMaterial.Items.Count;
            if (cmbMaterial.SelectedIndex < 0 || cmbMaterial.SelectedIndex > materialsCount)
                errorMessage += "Please select a surface material.\n";

            var shippingOptionCount = cmbShip.Items.Count;
            if (cmbShip.SelectedIndex < 0 || cmbShip.SelectedIndex > shippingOptionCount)
                errorMessage += "Please select a shipping option.\n";

            if (string.IsNullOrEmpty(txtName.Text))
                errorMessage += "Please enter a name for this order.\n";

            // Display a message if any field is empty or wrong
            if (errorMessage != string.Empty)
            {
                var message = string.Format(
                        "Please fix the following before the form can be submitted:\n{0}",
                        errorMessage
                    );
                MessageBox.Show(message);
            }
        }
    }
}
