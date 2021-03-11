using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public partial class Server : Form
    {
        ServerMIK s;
        public Server()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnPokreni_Click(object sender, EventArgs e)
        {
            s = new ServerMIK();
            if (s.pokreniServer())
            {
                label1.Text = "Uspešno ste pokrenuli \n server!";
                Poruka1 p = new Poruka1();
                p.Show();
                btnPokreni.Enabled = false;
                btnZaustavi.Enabled = true;
            }
            
        }

        private void btnZaustavi_Click(object sender, EventArgs e)
        {
            if (s.zaustaviServer())
            {
                label1.Text = "Server je zaustavljen!";
                Poruka2 p = new Poruka2();
                p.Show();
                btnPokreni.Enabled = true;
                btnZaustavi.Enabled = false;
            }
            
        }

        private void panelServer_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void Server_Load(object sender, EventArgs e)
        {
           
        }
    }
}
