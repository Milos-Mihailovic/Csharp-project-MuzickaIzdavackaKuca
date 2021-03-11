using Domen;
using Server;
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
    public partial class Login : Form
    {
        KontrolerKI konKI = new KontrolerKI();
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lblX_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPotvrdi_Click(object sender, EventArgs e)
        {
             Komunikacija k = Komunikacija.Instance;
            if (k.poveziSeSaServerom())
            {
                
                if (konKI.Login(txtUsername, txtPass, lblErrorLogin))
                {
                    this.Hide();
                    GlavnaForma gf = new GlavnaForma();
                    gf.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Neuspesna prijava!");
                }
            }
            else
            {
                MessageBox.Show("Niste povezani sa serverom!");
            }
            
           
        }

        private void jFlatButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
