using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domen;

namespace Login.UserCon
{
    public partial class PesmeUC : UserControl
    {
        KontrolerKI kki = new KontrolerKI();

        public PesmeUC()
        {
            InitializeComponent();

        }

        int indeks;
        private void dgvPesma_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPesma.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                indeks = e.RowIndex;
                DataGridViewRow red = dgvPesma.Rows[indeks];

                Pesma p = new Pesma
                {

                    Numera = red.Cells[0].Value.ToString(),
                    Izvodjac = new Izvodjac()
                    {
                        Ime = red.Cells[1].Value.ToString()
                    },
                    Tekstopisac = red.Cells[2].Value.ToString(),
                    TekstPesme  = red.Cells[3].Value.ToString(),
                    Email       = red.Cells[4].Value.ToString(),
                    Telefon     = red.Cells[5].Value.ToString()

                };
                FormaIzmeniPesmu pesma = new FormaIzmeniPesmu(p, indeks);
                pesma.ShowDialog();
                
                var pesme = kki.vratiPesme();
                dgvPesma.Rows.Clear();
                foreach (Pesma pes in pesme)
                {
                    var izvodjac = Komunikacija.Instance.PretragaIzvodjacaSO(pes.Izvodjac);
                    var imePrezime = izvodjac.Ime + " " + izvodjac.Prezime;
                    dgvPesma.Rows.Add(pes.Numera, imePrezime, pes.Tekstopisac, pes.TekstPesme, pes.Email, pes.Telefon);

                }
            }
        }
        

    private void btnKreirajPesmu_Click(object sender, EventArgs e)
        {
            new FormaPesma().ShowDialog();
            var pesme = kki.vratiPesme();
            dgvPesma.Rows.Clear();
            foreach (Pesma pes in pesme)
            {
                
                var izvodjac = Komunikacija.Instance.PretragaIzvodjacaSO(pes.Izvodjac);
                var imePrezime = izvodjac.Ime + " " + izvodjac.Prezime;
                dgvPesma.Rows.Add(pes.Numera, imePrezime, pes.Tekstopisac, pes.TekstPesme, pes.Email, pes.Telefon);

            }
        }

        private void txtPretragaPes_TextChanged(object sender, EventArgs e)
        {

        }

        private void PesmeUC_Load(object sender, EventArgs e)
        {
            var pesme = kki.vratiPesme();
            foreach (Pesma p in pesme)
            {           
                var izvodjac = Komunikacija.Instance.PretragaIzvodjacaSO(p.Izvodjac);
                dgvPesma.Rows.Add(p.Numera, izvodjac.ImePrezime, p.Tekstopisac, p.TekstPesme, p.Email, p.Telefon);
            }
        }

        private void btnPretraziIzvodjaca_Click(object sender, EventArgs e)
        {
            string valueSearch = txtPretragaPes.Text.ToString();
            if (valueSearch == "")
            {
                var pesme = kki.vratiPesme();
                dgvPesma.Rows.Clear();
                foreach (Pesma p in pesme)
                {
                    var izvodjac = Komunikacija.Instance.PretragaIzvodjacaSO(p.Izvodjac);
                    dgvPesma.Rows.Add(p.Numera, izvodjac.ImePrezime, p.Tekstopisac, p.TekstPesme, p.Email, p.Telefon);

                }
            }
            else
            {

                Pesma pesma = new Pesma
                {
                    Numera = valueSearch
                };

                List<Pesma> listaPesme = Komunikacija.Instance.PronadjiPesmuSO(pesma);
                if (listaPesme.Count == 0)
                {
                    MessageBox.Show("Sistem ne može da nađe pesmu po zadatoj vrednosti!");
                }
                else
                {
                    dgvPesma.Rows.Clear();
                    foreach (Pesma p in listaPesme)
                    {
                        var izvodjac = Komunikacija.Instance.PretragaIzvodjacaSO(p.Izvodjac);
                        dgvPesma.Rows.Add(p.Numera, izvodjac.ImePrezime, p.Tekstopisac, p.TekstPesme, p.Email, p.Telefon);

                    }
                    MessageBox.Show("Sistem je našao pesmu po zadatoj vrednosti!");
                }
            }
        }
    }
}
