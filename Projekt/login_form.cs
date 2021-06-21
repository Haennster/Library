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
    public partial class login_form : Form
    {


        public login_form()
        {
            InitializeComponent();
        }

        private void register_btn_Click(object sender, EventArgs e)
        {
            rejestracja rej = new rejestracja();
            rej.Show();
            this.Close();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guest_btn_Click(object sender, EventArgs e)
        {
            strona_glowna_guest main = new strona_glowna_guest();
            main.Show();
            this.Close();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            error_label.Show();
        }
    }
}
