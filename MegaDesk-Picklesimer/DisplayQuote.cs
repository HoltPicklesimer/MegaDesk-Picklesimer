using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Picklesimer
{
    public partial class DisplayQuote : Form
    {
        private Form _MainMenu;

        public DisplayQuote(Form mainMenu, DeskQuote deskQuote)
        {
            InitializeComponent();

            _MainMenu = mainMenu;

            // Set the values of the quote in the form
            nWidth.Value = deskQuote.Desk.Width;
            nDepth.Value = deskQuote.Desk.Depth;
            nDrawers.Value = deskQuote.Desk.Drawers;
            cmbMaterial.Text = deskQuote.Desk.SurfaceMaterial.ToString();
            txtName.Text = deskQuote.CustomerName;
            lblDate.Text = deskQuote.QuoteDate.ToShortDateString();
            cmbDelivery.Text = deskQuote.DeliveryOption.ToString();
            txtPrice.Text = deskQuote.PriceQuote.ToString("c");
        }

        private void DisplayQuote_FormClosed(object sender, FormClosedEventArgs e)
        {
            _MainMenu.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
