using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Picklesimer
{
    public partial class ViewAllQuotes : Form
    {
        private Form _MainMenu;

        public ViewAllQuotes(Form mainMenu)
        {
            InitializeComponent();

            _MainMenu = mainMenu;
            loadgrid();
        }

        private void loadgrid()
        {
            var quotesFile = @"quotes.json";

            using(StreamReader reader = new StreamReader(quotesFile))
            {
                //load quotes
                string quotes = reader.ReadToEnd();
                List<DeskQuote> deskQuotes = JsonConvert.DeserializeObject<List<DeskQuote>>(quotes);

                dataGridView1.DataSource = deskQuotes.Select(d => new
                {
                    Date = d.QuoteDate,
                    Customer = d.CustomerName,
                    Depth = d.Desk.Depth,
                    Width = d.Desk.Width,
                    Drawers = d.Desk.Drawers,
                    SurfaceMaterial = d.Desk.SurfaceMaterial,
                    DeliveryType = d.DeliveryOption,
                    QuoteAmount = d.PriceQuote.ToString("c")
                }).ToList();
            }
        }

        private void ViewAllQuotes_FormClosed(object sender, FormClosedEventArgs e)
        {
            _MainMenu.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
