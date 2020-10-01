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
    public partial class AddQuote : Form
    {
        private Form _MainMenu;

        public AddQuote(Form mainMenu)
        {
            InitializeComponent();

            _MainMenu = mainMenu;

            var materials = Enum.GetValues(typeof(DesktopMaterial))
                            .Cast<DesktopMaterial>()
                            .ToList();

            cmbMaterial.DataSource = materials;
            // Select no option
            cmbMaterial.SelectedIndex = -1;
        }

        private void AddQuote_FormClosed(object sender, FormClosedEventArgs e)
        {
            _MainMenu.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
