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
    public partial class FormaIzmeniPesmu : Form
    {
        KontrolerKI kki = new KontrolerKI();

        public FormaIzmeniPesmu(Pesma pesma, int indeks)
        {
            InitializeComponent();
            var listaPesme = kki.vratiPesme();
            pesma.Id = listaPesme[indeks].Id;
            popuniFormu(pesma);
        }

        public void popuniFormu(Pesma pesma)
        {
            txtID.Text = pesma.Id.ToString();
            txtNazivPesme.Text = pesma.Numera;
            var izvodjaci = kki.vratiIzvodjace();
            foreach (Izvodjac i in izvodjaci)
            {
                cmbIzvodjac.Items.Add(i.Ime + " " + i.Prezime);

            }
            cmbIzvodjac.Text = pesma.Izvodjac.Ime;
            txtTekstopisac.Text = pesma.Tekstopisac;
            txtPesme.Text = pesma.TekstPesme;
            txtEmail.Text = pesma.Email;
            txtTelefon.Text = pesma.Telefon;

        }

        public FormaIzmeniPesmu()
        {
            InitializeComponent();
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
                Pesma pesma = new Pesma();
                pesma.Id = int.Parse(txtID.Text);
                pesma.Numera = txtNazivPesme.Text;
                pesma.Izvodjac = new Izvodjac
                {
                    Id = cmbIzvodjac.SelectedIndex + 1
                };
                pesma.Tekstopisac = txtTekstopisac.Text;
                pesma.TekstPesme = txtPesme.Text;
                pesma.Email = txtEmail.Text;
                pesma.Telefon = txtTelefon.Text;
            if (kki.izmeniPesmu(pesma) != null)
            {
                this.Close();
            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormaIzmeniPesmu_Load(object sender, EventArgs e)
        {
            
        }

        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
