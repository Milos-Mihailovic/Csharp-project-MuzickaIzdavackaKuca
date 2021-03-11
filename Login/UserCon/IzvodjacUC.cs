using Domen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Login;


namespace Login.UserCon
{
    public partial class IzvodjacUC : UserControl
    {
        KontrolerKI kki = new KontrolerKI();

        public IzvodjacUC()
        {
            InitializeComponent();
            txtPretragaIzv.GotFocus += TxtPretragaPes_GotFocus;
        }
        private bool placeholder = true;
        private void TxtPretragaPes_GotFocus(object sender, EventArgs e)
        {
            if (placeholder)
            {
                placeholder = false;
                txtPretragaIzv.Text = "";
            }
        }

        private void btnKreiraj_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtPretragaPes_TextChanged(object sender, EventArgs e)
        {
          
        }

        int indeks;
        private void dgvIzvodjac_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dgvIzvodjac.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                indeks = e.RowIndex;
                DataGridViewRow red = dgvIzvodjac.Rows[indeks];
                MessageBox.Show("Sistem je našao izvođača po zadatoj vrednosti!");
                Izvodjac i = new Izvodjac
                {

                    Ime             = red.Cells[0].Value.ToString(), 
                    Prezime         = red.Cells[1].Value.ToString(),
                    TrajanjeUgovora = red.Cells[2].Value.ToString(),
                    Email           = red.Cells[3].Value.ToString(),
                    Telefon         = red.Cells[4].Value.ToString()

                };
                FormaIzmeniIzvodjaca izvodjac = new FormaIzmeniIzvodjaca(i, indeks);
                izvodjac.ShowDialog();
                var izvodjaci = kki.vratiIzvodjace();
                dgvIzvodjac.Rows.Clear();
                foreach (Izvodjac izv in izvodjaci)
                {
                    dgvIzvodjac.Rows.Add(izv.Ime, izv.Prezime, izv.TrajanjeUgovora, izv.Email, izv.Telefon);

                }
            }


        }

        private void btnKreirajIzvodjaca_Click(object sender, EventArgs e)
        {
           new FormaIzvodjac().ShowDialog();
            var izvodjaci = kki.vratiIzvodjace();
            dgvIzvodjac.Rows.Clear();
            foreach (Izvodjac i in izvodjaci)
            {
                dgvIzvodjac.Rows.Add(i.Ime, i.Prezime, i.TrajanjeUgovora, i.Email, i.Telefon);

            }
        }

        private void IzvodjacUC_Load(object sender, EventArgs e)
        {
            var izvodjaci = kki.vratiIzvodjace();
            foreach (Izvodjac i in izvodjaci)
            {
                 dgvIzvodjac.Rows.Add(i.Ime, i.Prezime, i.TrajanjeUgovora, i.Email, i.Telefon);
                
            }
            
        }

        private void btnPretraziIzvodjaca_Click(object sender, EventArgs e)
        {
            string valueSearch = txtPretragaIzv.Text.ToString();
            if (valueSearch == "")
            {
                var izvodjaci = kki.vratiIzvodjace();
                foreach (Izvodjac i in izvodjaci)
                {
                    dgvIzvodjac.Rows.Add(i.Ime, i.Prezime, i.TrajanjeUgovora, i.Email, i.Telefon);

                }
            }
            Izvodjac izvodjac = new Izvodjac
            {
                Ime = valueSearch
            };

            List<Izvodjac> listaIzvodjaca = Komunikacija.Instance.PronadjiIzvodjacaSO(izvodjac);
            if (listaIzvodjaca.Count == 0)
            {
                MessageBox.Show("Sistem ne može da nađe izvođača po zadatoj vrednosti!");
            }
            else
            {
                dgvIzvodjac.Rows.Clear();
                foreach (Izvodjac i in listaIzvodjaca)
                {

                    dgvIzvodjac.Rows.Add(i.Ime, i.Prezime, i.TrajanjeUgovora, i.Email, i.Telefon);

                }
                MessageBox.Show("Sistem je našao izvođača po zadatoj vrednosti!");
            }
           
        }
    }
}
