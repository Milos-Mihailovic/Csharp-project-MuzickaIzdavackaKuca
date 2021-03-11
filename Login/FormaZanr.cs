using System;
using Domen;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class FormaZanr : Form
    {
        KontrolerKI kki = new KontrolerKI();

        public FormaZanr()
        {
            InitializeComponent();
            var zanr = kki.vratiZanrID();
            txtZanrID.Text = zanr.Id.ToString();
            MessageBox.Show("Sistem je kreirao žanr!");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnZapamti_Click(object sender, EventArgs e)
        {
            var zanrovi = kki.vratiZanrove();
            foreach (ZanrAlbuma za in zanrovi)
            {
                if (txtNoviZanr.Text == za.NazivZanra)
                {
                    MessageBox.Show("Uneti žanr već postoji");
                    return;
                };
            }

            if (txtNoviZanr.Text == "")
            {
                MessageBox.Show("Niste upisali novi zanr!");
            }
            else
            {
                kki.zapamtiZanr(int.Parse(txtZanrID.Text), txtNoviZanr.Text);
                MessageBox.Show("Sistem je zapamtio žanr!");
                this.Close();
            }
            
        }

        private void txtZanrID_TextChanged(object sender, EventArgs e)
        {

        }

        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormaZanr_Load(object sender, EventArgs e)
        {

        }
    }
}
