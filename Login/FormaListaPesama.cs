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
    public partial class FormaListaPesama : Form
    {
        private string imeAlbuma;
        private string imeZanra;

        public FormaListaPesama()
        {
            InitializeComponent();
        }

        public FormaListaPesama(string imeAlbuma, string imeZanra)
        {
            InitializeComponent();

            txtNazivAlbuma.Text = imeAlbuma;
            txtNazivZanra.Text = imeZanra;

            Album album = new Album
            {
                NazivAlbuma = imeAlbuma
            };

            var albumi = Komunikacija.Instance.PronadjiAlbumSO(album);
            album = albumi[0];

            PesmeAlbuma pesmeAlbuma = new PesmeAlbuma
            {
                Album = album
            };

            var listaPA = Komunikacija.Instance.PronadjiPesmaAlbumSO(pesmeAlbuma);
            foreach (PesmeAlbuma pa in listaPA)
            {
                var pesma = Komunikacija.Instance.PretragaPesmeSO(pa.Pesma);
                dgvListaPesama.Rows.Add(pesma.Numera);

            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
