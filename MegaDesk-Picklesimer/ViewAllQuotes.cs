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
    public partial class ViewAllQuotes : Form
    {
        private Form _MainMenu;

        public ViewAllQuotes(Form mainMenu)
        {
            InitializeComponent();

            _MainMenu = mainMenu;
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
