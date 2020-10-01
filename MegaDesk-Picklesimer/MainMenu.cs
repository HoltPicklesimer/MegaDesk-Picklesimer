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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnAddNewQuote_Click(object sender, EventArgs e)
        {
            var addQuote = new AddQuote(this);
            addQuote.StartPosition = FormStartPosition.Manual;
            addQuote.Location = Location;
            addQuote.Show();
            Hide();
        }

        private void btnViewQuotes_Click(object sender, EventArgs e)
        {
            var viewQuotes = new ViewAllQuotes(this);
            viewQuotes.StartPosition = FormStartPosition.Manual;
            viewQuotes.Location = Location;
            viewQuotes.Show();
            Hide();
        }

        private void btnSearchQuotes_Click(object sender, EventArgs e)
        {
            var searchQuotes = new SearchQuotes(this);
            searchQuotes.StartPosition = FormStartPosition.Manual;
            searchQuotes.Location = Location;
            searchQuotes.Show();
            Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
