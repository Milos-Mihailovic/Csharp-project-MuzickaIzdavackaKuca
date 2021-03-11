using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JTextBox;
using Login.Poruke;
using System.ComponentModel;
using Login.UserCon;

namespace Login
{
    class KontrolerKI
    {

        public Album vratiAlbumID()
        {
            return Komunikacija.Instance.VratiAlbumID();
        }


        public PesmeAlbuma vratiPesmaAlbumID()
        {
            return Komunikacija.Instance.VratiPesmaAlbumID();
        }

        public ZanrAlbuma vratiZanrID()
        {
            return Komunikacija.Instance.VratiZanrID();
        }

        public Pesma vratiPesmaID()
        {
            return Komunikacija.Instance.VratiPesmaID();
        }

        public Izvodjac vratiIzvodjacID()
        {
            return Komunikacija.Instance.VratiIzvodjacID();
        }

        public Pesma kreirajNovuPesmu(int id, string numera, Izvodjac izvodjac, string tekstopisac, string tekstPesme, string email, string telefon)
        {

            Pesma pesma = new Pesma()
            {

                Id = id,
                Numera = numera,
                Izvodjac = new Izvodjac(),
                Tekstopisac = tekstopisac,
                TekstPesme = tekstPesme,
                Email = email,
                Telefon = telefon

            };
            return Komunikacija.Instance.KreirajPesmuSO(pesma);
        }

        public Album kreirajAlbum(int id, string naziv, List<Pesma> pesma)
        {

            Album album = new Album()
            {

                Id = id,
                NazivAlbuma = naziv,
                //Pesme = pesma //??????????

            };
            return Komunikacija.Instance.KreirajAlbumSO(album);
        }

        public void obrisiPesmeAlbuma(PesmeAlbuma pesmeAlbuma)
        {
            Komunikacija.Instance.obrisiPesmeAlbumaSO(pesmeAlbuma);
        }

        public void obrisiAlbum(Album album)
        {
            Komunikacija.Instance.ObrisiAlbumSO(album);
        }

        public ZanrAlbuma zapamtiZanr(int id, string nazivZanra)
        {
            ZanrAlbuma zanr = new ZanrAlbuma();
            zanr.Id = id;

            zanr.NazivZanra = nazivZanra;
            if (zanr.NazivZanra == "")
            {
                MessageBox.Show("Niste uneli ime!");
                return null;
            }

            var rezultat = Komunikacija.Instance.ZapamtiZanrSO(zanr);

            return rezultat;
        }

        public Izvodjac izmeniIzvodjaca(Izvodjac izvodjac)
        {
            
            if (izvodjac.Ime == "")
            {
                MessageBox.Show("Niste uneli ime!");
                return null;
            }

            if (izvodjac.Prezime == "")
            {
                MessageBox.Show("Niste uneli prezime!");
                return null;
            }

            if (izvodjac.TrajanjeUgovora == "")
            {
                MessageBox.Show("Niste uneli trajanje ugovora!");
                return null;
            }

            if (izvodjac.Email == "")
            {
                MessageBox.Show("Niste uneli E-mail!");
                return null;
            }

            if (izvodjac.Telefon == "")
            {
                MessageBox.Show("Niste uneli broj telefona!");
                return null;
            }

            var rezultat = Komunikacija.Instance.IzmeniIzvodjacaSO(izvodjac);

            PorukaZapamti zapamti = new PorukaZapamti();
            zapamti.Show();

            return rezultat;
        }

        public Izvodjac zapamtiIzvodjaca(int id, string ime, string prezime, string trajanjeUgovora, string email, string telefon)
        {
            Izvodjac izvodjac = new Izvodjac();
            izvodjac.Id = id;
            
            izvodjac.Ime = ime;
            if (izvodjac.Ime == "")
            {
                MessageBox.Show("Niste uneli ime!");
                return null;
            }

            izvodjac.Prezime = prezime;
            if (izvodjac.Prezime == "")
            {
                MessageBox.Show("Niste uneli prezime!");
                return null;
            }

            izvodjac.TrajanjeUgovora = trajanjeUgovora;
            if (izvodjac.TrajanjeUgovora == "")
            {
                MessageBox.Show("Niste uneli trajanje ugovora!");
                return null;
            }

            izvodjac.Email = email;
            if (izvodjac.Email == "")
            {
                MessageBox.Show("Niste uneli E-mail!");
                return null;
            }

            izvodjac.Telefon = telefon;
            if (izvodjac.Telefon == "")
            {
                MessageBox.Show("Niste uneli broj telefona!");
                return null;
            }



            izvodjac = new Izvodjac()
            {
                Id = id,
                Ime = ime,
                Prezime = prezime,
                TrajanjeUgovora = trajanjeUgovora,
                Email = email,
                Telefon = telefon

            };

    
            var rezultat = Komunikacija.Instance.ZapamtiIzvodjacaSO(izvodjac);
            

            return rezultat;
        }


        public List<Izvodjac> vratiIzvodjace()
        {

            var rezultat = Komunikacija.Instance.VratiListuIzvodjacaSO();
            return rezultat;
        }

        public List<Album> vratiAlbume()
        {
            var rezultat = Komunikacija.Instance.VratiListuAlbumaSO();
            return rezultat;
        }

        public List<ZanrAlbuma> vratiZanrove()
        {
            var rezultat = Komunikacija.Instance.VratiListuZanrovaSO();
            return rezultat;
        }

        public Pesma izmeniPesmu(Pesma pesma)
        {
            if (pesma.Numera == "")
            {
                MessageBox.Show("Niste uneli naziv pesme!");
                return null;
            }

            if (pesma.Izvodjac == null)
            {
                MessageBox.Show("Niste odabrali izvodjaca!");
                return null;
            }

            if (pesma.Tekstopisac == "")
            {
                MessageBox.Show("Niste uneli tekstopisca");
                return null;
            }

            if (pesma.Email == "")
            {
                MessageBox.Show("Niste uneli E-mail tekstopisca!");
                return null;
            }

            if (pesma.Telefon == "")
            {
                MessageBox.Show("Niste uneli broj telefona tekstopisca!");
                return null;
            }

            if (pesma.TekstPesme == "")
            {
                MessageBox.Show("Niste uneli tekst pesme!");
                return null;
            }

            var rezultat = Komunikacija.Instance.IzmeniPesmuSO(pesma);


            PorukaZapamtiPesmu zapamtiPesmu = new PorukaZapamtiPesmu();
            zapamtiPesmu.Show();

            return rezultat;
        }

        public Album zapamtiAlbum(Album album)
        {
            if (album.ZanrAlbuma == null)
            {
                MessageBox.Show("Niste odabrali žanr albuma!");
                return null;
            }

            if (album.NazivAlbuma == "")
            {
                MessageBox.Show("Niste uneli naziv albuma!");
                return null;
            }

            var rezultat = Komunikacija.Instance.ZapamtiAlbumSO(album);
            PorukaZapAl zapamtiAlbum = new PorukaZapAl();
            zapamtiAlbum.Show();

            return rezultat;
        }

        public PesmeAlbuma DodajPesmaAlbum(PesmeAlbuma pesmeAlbuma)
        {

            if (pesmeAlbuma.Pesma == null)
            {
                MessageBox.Show("Niste sačuvali pesmu!");
                return null;
            }

            if (pesmeAlbuma.Album == null)
            {
                MessageBox.Show("Niste sačuvali album!");
                return null;
            }

            if (pesmeAlbuma.Id == 0)
            {
                MessageBox.Show("ID ne može biti 0!");
                return null;
            }

            var rezultat = Komunikacija.Instance.DodajPesmaAlbumSO(pesmeAlbuma);
            PorukaZapamtiPesmu zapamtiPesmu = new PorukaZapamtiPesmu();
            zapamtiPesmu.Show();
            return rezultat;

        }

        public Pesma zapamtiPesmu(Pesma pesma)
        {
            
            if (pesma.Numera == "")
            {
                MessageBox.Show("Niste uneli naziv pesme!");
                return null;
            }

            if (pesma.Izvodjac == null)
            {
                MessageBox.Show("Niste odabrali izvodjaca!");
                return null;
            }
           
            if (pesma.Tekstopisac == "")
            {
                MessageBox.Show("Niste uneli tekstopisca");
                return null;
            }

            if (pesma.Email == "")
            {
                MessageBox.Show("Niste uneli E-mail tekstopisca!");
                return null;
            }

            if (pesma.Telefon == "")
            {
                MessageBox.Show("Niste uneli broj telefona tekstopisca!");
                return null;
            }

            if (pesma.TekstPesme == "")
            {
                MessageBox.Show("Niste uneli tekst pesme!");
                return null;
            }

            var rezultat = Komunikacija.Instance.ZapamtiPesmuSO(pesma);
            PorukaZapamtiPesmu zapamtiPesmu = new PorukaZapamtiPesmu();
            zapamtiPesmu.Show();

            return rezultat;


        }
        
        public List<Pesma> vratiPesme()
        {
            var rezultat = Komunikacija.Instance.VratiListuPesamaSO();
            return rezultat;
        }

        private static GlavniUrednik glvUrednik;
        public bool Login(JTextBox.JTextBox txtUsername, JTextBox.JTextBox txtPass, Label lblErrorLogin)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.TextValue) ||
                string.IsNullOrWhiteSpace(txtPass.TextValue))
            {
                lblErrorLogin.Text = "Username i password su obavezna polja!";
                return false;
            }
            else
            {
                try
                {
                    glvUrednik = Komunikacija.Instance.PrijaviSe(txtUsername.TextValue, txtPass.TextValue);
                    return true;
                }
                catch (Exception ex)
                {
                    lblErrorLogin.Text = "Username ili password su neispravni!";
                    return false;
                }
            }
            
        }

    }
}
