using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domen;

namespace Login
{
    public partial class GlavnaForma : Form
    {
        KontrolerKI glavniKontroler = new KontrolerKI();

        public GlavnaForma()
        {
            InitializeComponent();
            mmStudioUC1.BringToFront();
            lblTitle.Text = "Početna";
        }

        private void GlavnaForma_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPocetna_Click(object sender, EventArgs e)
        {
            mmStudioUC1.BringToFront();
            lblTitle.Text = "Početna";
        }

        private void btnIzvodjac_Click(object sender, EventArgs e)
        {
            izvodjacUC1.BringToFront();
            lblTitle.Text = "Izvođači";
        }

        private void izvodjacUC1_Load(object sender, EventArgs e)
        {

        }

        private void btnPesma_Click(object sender, EventArgs e)
        {
            pesmeUC1.BringToFront();
            lblTitle.Text = "Pesme";
        }

        private void btnAlbum_Click(object sender, EventArgs e)
        {
            albumiUC1.BringToFront();
            lblTitle.Text = "Albumi";
        }

        private void pesmeUC1_Load(object sender, EventArgs e)
        {

        }

        private void pesmeUC1_Load_1(object sender, EventArgs e)
        {

        }

        private void albumiUC1_Load(object sender, EventArgs e)
        {

        }
    }
}
