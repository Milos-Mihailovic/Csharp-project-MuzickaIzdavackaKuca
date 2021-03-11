using Domen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Login.UserCon;

namespace Login
{
    public partial class FormaIzmeniIzvodjaca : Form
    {
        KontrolerKI kki = new KontrolerKI();
        Izvodjac izvodjacTemp = new Izvodjac();


        public FormaIzmeniIzvodjaca(Izvodjac izvodjac, int indeks)
        {
            InitializeComponent();
            //popuni polja
            List<Izvodjac> izvodjaci = kki.vratiIzvodjace();
            izvodjac.Id = izvodjaci[indeks].Id;
            izvodjacTemp = izvodjac;

        }

        public FormaIzmeniIzvodjaca()
        {
            InitializeComponent();
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
                Izvodjac izvodjac = new Izvodjac
                {
                    Id = int.Parse(txtID.Text),
                    Ime = txtIme.TextValue,
                    Prezime = txtPrezime.TextValue,
                    TrajanjeUgovora = txtTrajanjeUgovora.TextValue,
                    Email = txtEmail.TextValue,
                    Telefon = txtTelefon.TextValue
                };
            if (kki.izmeniIzvodjaca(izvodjac) != null)
            {
                this.Close();
            }
    
        }

        private void FormaIzmeniIzvodjaca_Load(object sender, EventArgs e)
        {

        }

        private void txtIme_Load(object sender, EventArgs e)
        {
            if (izvodjacTemp != null)
            {
                txtID.Text = izvodjacTemp.Id.ToString();
                txtIme.TextValue = izvodjacTemp.Ime;
                txtPrezime.TextValue = izvodjacTemp.Prezime;
                txtTrajanjeUgovora.TextValue = izvodjacTemp.TrajanjeUgovora;
                txtEmail.TextValue = izvodjacTemp.Email;
                txtTelefon.TextValue = izvodjacTemp.Telefon;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
