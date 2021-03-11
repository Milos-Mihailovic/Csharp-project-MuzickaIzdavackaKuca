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
using Login.Poruke;
using System.Collections;

namespace Login.UserCon
{
    public partial class AlbumiUC : UserControl
    {
        KontrolerKI kki = new KontrolerKI();

        public AlbumiUC()
        {
            InitializeComponent();
        }

        int indeks;
        private void dgvPesmeAl_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAlbumi.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                if (e.ColumnIndex == 3)
                {
                    indeks = e.RowIndex;
                    DataGridViewRow red = dgvAlbumi.Rows[indeks];
                    PorukaObrisi obrisi = new PorukaObrisi();
                    obrisi.ShowDialog();
                    if (obrisi.da_ne == true)
                    {
                        Album album = new Album
                        {
                            NazivAlbuma = red.Cells[0].Value.ToString()
                        };

                        var listaAlbuma = Komunikacija.Instance.PronadjiAlbumSO(album);
                        album = listaAlbuma[0];

                        PesmeAlbuma pesmeAlbuma = new PesmeAlbuma
                        {
                            Album = album
                        };

                        kki.obrisiPesmeAlbuma(pesmeAlbuma);

                    }
                    var albumi = kki.vratiAlbume();
                    dgvAlbumi.Rows.Clear();
                    foreach (Album al in albumi)
                    {
                        var zanr = Komunikacija.Instance.PretragaZanraSO(al.ZanrAlbuma);
                        var nazivZanra = zanr.NazivZanra;
                        dgvAlbumi.Rows.Add(al.NazivAlbuma, nazivZanra);
                    }
                }
                else if (e.ColumnIndex == 2)
                {
                    indeks = e.RowIndex;
                    DataGridViewRow red = dgvAlbumi.Rows[indeks];
                    string imeAlbuma = red.Cells[0].Value.ToString();
                    string imeZanra  = red.Cells[1].Value.ToString();
                    FormaListaPesama listaPesama = new FormaListaPesama(imeAlbuma, imeZanra);
                    listaPesama.ShowDialog();
                    
                }
            }

        }

        private void btnKreiraj_Click(object sender, EventArgs e)
        {

        }

        private void txtNazivAl_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {

            new FormaZanr().ShowDialog();
            var zanrovi = kki.vratiZanrove();
            dgvZanrovi.Rows.Clear();
            foreach (ZanrAlbuma z in zanrovi)
            {
                dgvZanrovi.Rows.Add(z.Id, z.NazivZanra);

            }
        }

        private void labelNazAl_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAlbum_Click(object sender, EventArgs e)
        {
            new FormaAlbuma().ShowDialog();
            var albumi = kki.vratiAlbume();
            dgvAlbumi.Rows.Clear();
            foreach (Album a in albumi)
            {
                var zanr = Komunikacija.Instance.PretragaZanraSO(a.ZanrAlbuma);
                var nazivZanra = zanr.NazivZanra;
                dgvAlbumi.Rows.Add(a.NazivAlbuma, nazivZanra);

            }

        }

        private void dgvZanrovi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void AlbumiUC_Load(object sender, EventArgs e)
        {

            var zanrovi = kki.vratiZanrove();
            foreach (ZanrAlbuma z in zanrovi)
            {
                dgvZanrovi.Rows.Add(z.Id, z.NazivZanra);

            }

            var albumi = kki.vratiAlbume();

            for (int i = 0; i < albumi.Count; i++)
            {
                PesmeAlbuma pesmeAlbuma = new PesmeAlbuma
                {
                    Album = albumi[i]
                };

                var listaPA = Komunikacija.Instance.PronadjiPesmaAlbumSO(pesmeAlbuma);

                var zanr = Komunikacija.Instance.PretragaZanraSO(albumi[i].ZanrAlbuma);
                var nazivZanra = zanr.NazivZanra;
                dgvAlbumi.Rows.Add(albumi[i].NazivAlbuma, nazivZanra);
           
            }
            
        }
    }
}
