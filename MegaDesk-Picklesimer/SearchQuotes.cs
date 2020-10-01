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
    public partial class SearchQuotes : Form
    {
        private Form _MainMenu;

        public SearchQuotes(Form mainMenu)
        {
            InitializeComponent();

            _MainMenu = mainMenu;
        }

        private void SearchQuotes_FormClosed(object sender, FormClosedEventArgs e)
        {
            _MainMenu.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
