using Login.Poruke;
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
    public partial class FormaAlbuma : Form
    {
        KontrolerKI kki = new KontrolerKI();

        public FormaAlbuma()
        {
            InitializeComponent();
            var album = kki.vratiAlbumID();
            txtAlbumID.Text = album.Id.ToString();
            MessageBox.Show("Sistem je kreirao album!");
        }

        private void jThinButton3_Click(object sender, EventArgs e)
        {

        }

        private void btnZapamti_Click(object sender, EventArgs e)
        {

            var albumi = kki.vratiAlbume();
            foreach (Album za in albumi)
            {
                if (txtNazivAlbuma.Text == za.NazivAlbuma)
                {
                    MessageBox.Show("Uneti album već postoji");
                    return;
                };
            }

            if (cmbZanr.Text == "")
            {
                MessageBox.Show("Niste izabrali Žanr albuma!");
            }
            else if (dgvPesmeAlbuma.Rows.Count == 0)
            {
                MessageBox.Show("Tabela albuma sa pesmama je prazna!");
            }
                else
            {

                
                Album album = new Album
                {
                    Id          = int.Parse(txtAlbumID.Text),
                    
                    ZanrAlbuma  = new ZanrAlbuma
                    {
                        Id      = cmbZanr.SelectedIndex + 1
                    },
                    NazivAlbuma = txtNazivAlbuma.Text

                };

                if (kki.zapamtiAlbum(album) != null)
                {

                    Album a = new Album
                    {
                        Id = int.Parse(txtAlbumID.Text)
                    };

                    for (int i = 0; i < dgvPesmeAlbuma.Rows.Count; i++)
                    {
                        var red = dgvPesmeAlbuma.Rows[i];
                        Pesma pesma = new Pesma
                        {
                            Numera = red.Cells[0].Value.ToString()
                        };

                        var pesme = Komunikacija.Instance.PronadjiPesmuSO(pesma);

                        foreach (Pesma p in pesme)
                        {
                            if (p.Numera == pesma.Numera)
                            {
                                pesma = p;
                            };
                        }

                        var pesmeAlbuma = kki.vratiPesmaAlbumID();
                        pesmeAlbuma.Pesma = pesma;
                        pesmeAlbuma.Album = album;
                        kki.DodajPesmaAlbum(pesmeAlbuma);
                    }
                        this.Close();
                }
            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnKreirajAlbum_Click(object sender, EventArgs e)
        {
            
        }

        private void dgvNazivPesme_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormaAlbuma_Load(object sender, EventArgs e)
        {
            var zanrovi = kki.vratiZanrove();
            foreach (ZanrAlbuma za in zanrovi)
            {
                cmbZanr.Items.Add(za.NazivZanra);

            }

            var pesme = kki.vratiPesme();
            foreach (Pesma p in pesme)
            {
                dgvPesme.Rows.Add(p.Numera);

            }

        }
        
        int indeks;
        private void dgvPesmeAlbuma_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPesmeAlbuma.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                indeks = e.RowIndex;
                dgvPesmeAlbuma.Rows.RemoveAt(indeks);
            }
        }

        private void btnPretraziPesme_Click(object sender, EventArgs e)
        {
            string valueSearch = txtPretraziPesme.Text.ToString();
            if (valueSearch == "")
            {
                var pesme = kki.vratiPesme();
                foreach (Pesma p in pesme)
                {
                    dgvPesme.Rows.Add(p.Numera);

                }
            }
            Pesma pesma = new Pesma
            {
                Numera = valueSearch
            };

            List<Pesma> listaPesma = Komunikacija.Instance.PronadjiPesmuSO(pesma);
            dgvPesme.Rows.Clear();
            foreach (Pesma p in listaPesma)
            {

                dgvPesme.Rows.Add(p.Numera);

            }
        }

        private void btnDodajPesmu_Click(object sender, EventArgs e)
        {

        }

        private void cmbZanr_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvPesme_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPesme.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                indeks = e.RowIndex;
                DataGridViewRow red = dgvPesme.Rows[indeks];
                var numera = red.Cells[0].Value.ToString();
                for (int i = 0; i < dgvPesmeAlbuma.Rows.Count; i++)
                {
                    if (dgvPesmeAlbuma.Rows[i].Cells[0].Value.ToString() == numera)
                    {
                        MessageBox.Show("Vec ste uneli ovu pesmu");
                        return;
                    }
                }

                dgvPesmeAlbuma.Rows.Add(red.Cells[0].Value.ToString());

            }
        }

        private void txtAlbumID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
