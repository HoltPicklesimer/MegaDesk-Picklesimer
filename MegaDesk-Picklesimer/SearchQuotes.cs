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
    public partial class SearchQuotes : Form
    {
        private Form _MainMenu;

        public SearchQuotes(Form mainMenu)
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

            loadgrid();
        }

        private void SearchQuotes_FormClosed(object sender, FormClosedEventArgs e)
        {
            _MainMenu.Show();
        }
        
        private void loadgrid(DesktopMaterials? query = null)
        {
            var quotesFile = @"quotes.json";

            using (StreamReader reader = new StreamReader(quotesFile))
            {
                //load quotes
                string quotes = reader.ReadToEnd();
                List<DeskQuote> deskQuotes = JsonConvert.DeserializeObject<List<DeskQuote>>(quotes);
                if (query.HasValue)
                {
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
                    }).Where(q => q.SurfaceMaterial == query)
                      .ToList();
                }

                else
                {
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
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmbMaterial_SelectedValueChanged(object sender, EventArgs e)
        {
            if(cmbMaterial.SelectedIndex > -1) { 
                loadgrid((DesktopMaterials)cmbMaterial.SelectedValue);
                dataGridView1.Update();
                cmbMaterial.Refresh();
            }
        }
    }
}
