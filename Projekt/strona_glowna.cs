using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt
{
    public partial class strona_glowna : Form
    {
        public strona_glowna()
        {
            InitializeComponent();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            login_form login = new login_form();
            login.Show();
            this.Close();
        }

        private void wypoz_btn_Click(object sender, EventArgs e)
        {

        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            title.Clear();
            author.Clear();
            category.SelectedIndex = -1;
            if (wypozyczone.Checked == true)
            { 
                wypozyczone.Checked = false;
            }
        }

        private void strona_glowna_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'categories.Kategorie' . Możesz go przenieść lub usunąć.
            this.kategorieTableAdapter.Fill(this.categories.Kategorie);

        }
    }
}
