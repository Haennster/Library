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
        long id_czytelnika;

        public strona_glowna(long id_czytelnika)
        {
            InitializeComponent();
            this.id_czytelnika = id_czytelnika;
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
        }

        private void strona_glowna_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'daneDataSet.Kategorie' . Możesz go przenieść lub usunąć.
            this.kategorieTableAdapter.Fill(this.daneDataSet.Kategorie);
            WyswietlZalogowanego();
            category.SelectedIndex = -1;

        }

        public void WyswietlZalogowanego()
        {
            DaneEntities dane = new DaneEntities();
            var zalogowany = from zalog in dane.Czytelnicy
                             where zalog.id_czytelnik == id_czytelnika
                             select new { zalog.login };
            zalogowanylabel.Text = "Witaj: " + zalogowany.First().login;
        }
    }
}
