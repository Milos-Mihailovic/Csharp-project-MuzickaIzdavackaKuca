using Domen;
using Login.Poruke;
using System;
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
    public partial class FormaPesma : Form
    {
        KontrolerKI kki = new KontrolerKI();
      
        public FormaPesma()
        {
            InitializeComponent();
            var pesma = kki.vratiPesmaID();
            txtID.Text = pesma.Id.ToString();
            MessageBox.Show("Sistem je kreirao pesmu!");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnZapamti_Click(object sender, EventArgs e)
        {
            var pesme = kki.vratiPesme();
            foreach (Pesma p in pesme)
            {
                if (txtNazivPesme.Text == p.Numera) {
                    MessageBox.Show("Uneto ime pesme već postoji");
                    return;
                };
            }
            if (cmbIzvodjac.Text == "")
            {
                MessageBox.Show("Niste izabrali izvođača!");
            }
            else
            {
                Pesma pesma = new Pesma
                {
                    Id          = int.Parse(txtID.Text),
                    Numera      = txtNazivPesme.Text,
                    Izvodjac    = new Izvodjac {
                        Id = cmbIzvodjac.SelectedIndex+1
                    },
                    Tekstopisac = txtTekstopisac.Text,
                    TekstPesme  = txtPesme.Text,
                    Email       = txtEmail.Text,
                    Telefon     = txtTelefon.Text
                };
                
                if (kki.zapamtiPesmu(pesma) != null)
                {
                    this.Close();
                }
            }
            

        }

        private void jThinButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void cmbIzvodjac_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormaPesma_Load(object sender, EventArgs e)
        {
            var izvodjaci = kki.vratiIzvodjace();
            foreach (Izvodjac i in izvodjaci)
            {
                cmbIzvodjac.Items.Add(i.Ime + " " + i.Prezime);

            }

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
