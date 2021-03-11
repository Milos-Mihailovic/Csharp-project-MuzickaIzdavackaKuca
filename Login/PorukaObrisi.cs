using System;
using Login.Poruke;
using Domen;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Login.UserCon;

namespace Login.Poruke
{
    public partial class PorukaObrisi : Form
    {
        KontrolerKI kki = new KontrolerKI();
        public PorukaObrisi()
        {
            InitializeComponent();
        }

        private void PorukaObrisi_Load(object sender, EventArgs e)
        {

        }

        //da_ne = 1 - ako je kliknuto dugme da
        //da_ne = 0 - ako je stisnuto dugme ne
        public bool da_ne; 

        private void jThinButton1_Click(object sender, EventArgs e)
        {

            da_ne = true;
            MessageBox.Show("Sistem je obrisao album!");
            this.Close();
        }

        private void jThinButton2_Click(object sender, EventArgs e)
        {
            da_ne = false;
            this.Close();
        }
    }
}
