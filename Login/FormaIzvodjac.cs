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
    public partial class FormaIzvodjac : Form
    {
        KontrolerKI kki = new KontrolerKI();
        

        public FormaIzvodjac()
        {
            InitializeComponent();
            // izvodjacTemp = null;
            var izvodjac = kki.vratiIzvodjacID();
            txtID.Text = izvodjac.Id.ToString();
            MessageBox.Show("Sistem je kreirao izvođača!");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void jThinButton1_Click(object sender, EventArgs e)
        {

        }

        private void btnZapamti_Click(object sender, EventArgs e)
        {

            if (txtID.Text == "")
            {
                MessageBox.Show("Niste kreirali ID!");
            }
            else if (txtIme.TextValue == "" || txtPrezime.TextValue == "" || txtTrajanjeUgovora.TextValue == ""||
                    txtEmail.TextValue == "" || txtTelefon.TextValue == "")
            {
                kki.zapamtiIzvodjaca(int.Parse(txtID.Text), txtIme.TextValue, txtPrezime.TextValue, txtTrajanjeUgovora.TextValue, txtEmail.TextValue, txtTelefon.TextValue);

            }
            else 
            {
                PorukaZapamti zapamti = new PorukaZapamti();
                zapamti.Show();
                kki.zapamtiIzvodjaca(int.Parse(txtID.Text), txtIme.TextValue, txtPrezime.TextValue, txtTrajanjeUgovora.TextValue, txtEmail.TextValue, txtTelefon.TextValue);
                
                this.Close();
            }
        }

        private void jThinButton1_Click_1(object sender, EventArgs e)
        {
           
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
        }

        private void FormaIzvodjac_Load(object sender, EventArgs e)
        {

        }

        private void txtIme_Load(object sender, EventArgs e)
        {
            

        }


        public void txtIme_TextChanged(object sender, EventArgs e)
        {
        }

        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelIzvodjac_Click(object sender, EventArgs e)
        {

        }

        private void txtPrezime_Load(object sender, EventArgs e)
        {

        }

        private void FormaIzvodjac_Load_1(object sender, EventArgs e)
        {

        }
    }
}
