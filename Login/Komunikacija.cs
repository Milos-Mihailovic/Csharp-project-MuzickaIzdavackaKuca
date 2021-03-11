using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Domen;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using System.Windows.Forms;

namespace Login
{
    public class Komunikacija
    {
        private static Komunikacija instance;
        TcpClient klijent;
        NetworkStream tok;
        BinaryFormatter formater;

        public static Komunikacija Instance
        {
            get
            {

                if (instance == null)
                {
                    instance = new Komunikacija();
                }
                return instance;
            }
        }



        private Komunikacija() { poveziSeSaServerom(); }

        
        public bool poveziSeSaServerom()
        {
            try
            {
                klijent = new TcpClient("127.0.0.1", 12000);
                tok = klijent.GetStream();
                formater = new BinaryFormatter();
                return true;
            }
            catch (Exception)
            {

                return false;
            }

        }

        public GlavniUrednik PrijaviSe(string username, string pass)
        {
            TransferKlasa zahtev = new TransferKlasa()
            {
                operacija = Operacija.LOGIN,
                TransferObjekat = new GlavniUrednik() { Username = username, Password = pass }
            };
            formater.Serialize(tok, zahtev);

            TransferKlasa odgovor = (TransferKlasa)formater.Deserialize(tok);
            if (odgovor.Signal)
            {
                return (GlavniUrednik) odgovor.Rezultat;
            }
            else
            {
                throw new Exception(odgovor.Rezultat.ToString());
            }


        }

        public PesmeAlbuma VratiPesmaAlbumID()
        {
            PesmeAlbuma pa = new PesmeAlbuma();

            TransferKlasa zahtev = new TransferKlasa()
            {
                operacija = Operacija.VRATI_PESMA_ALBUM_ID,
                TransferObjekat = pa
            };
            formater.Serialize(tok, zahtev);

            TransferKlasa odgovor = (TransferKlasa)formater.Deserialize(tok);
            if (odgovor.Signal)
            {
                int ID = (int)odgovor.Rezultat;
                PesmeAlbuma p = new PesmeAlbuma
                {
                    Id = ID
                };
                return p;
            }
            else
            {
                throw new Exception(odgovor.Rezultat.ToString());
            }
        }

        public Izvodjac VratiIzvodjacID()
        {
            Izvodjac izvodjac = new Izvodjac();

            TransferKlasa zahtev = new TransferKlasa()
            {
                operacija = Operacija.VRATI_IZVODJAC_ID,
                TransferObjekat = izvodjac
            };
            formater.Serialize(tok, zahtev);

            TransferKlasa odgovor = (TransferKlasa)formater.Deserialize(tok);
            if (odgovor.Signal)
            {
                int ID = (int)odgovor.Rezultat;
                Izvodjac i = new Izvodjac
                {
                    Id = ID
                };
                return i;
            }
            else
            {
                throw new Exception(odgovor.Rezultat.ToString());
            }
        }

        public Pesma VratiPesmaID()
        {
            Pesma pesma = new Pesma();

            TransferKlasa zahtev = new TransferKlasa()
            {
                operacija = Operacija.VRATI_PESMA_ID,
                TransferObjekat = pesma
            };
            formater.Serialize(tok, zahtev);

            TransferKlasa odgovor = (TransferKlasa)formater.Deserialize(tok);
            if (odgovor.Signal)
            {
                int ID = (int)odgovor.Rezultat;
                Pesma p = new Pesma
                {
                    Id = ID
                };
                return p;
            }
            else
            {
                throw new Exception(odgovor.Rezultat.ToString());
            }
        }


        public Album VratiAlbumID()
        {
            Album album = new Album()
            {

                Id = 0,
                NazivAlbuma = null

            };
            TransferKlasa zahtev = new TransferKlasa()
            {
                operacija = Operacija.VRATI_ALBUM_ID,
                TransferObjekat = album
            };
            formater.Serialize(tok, zahtev);

            TransferKlasa odgovor = (TransferKlasa)formater.Deserialize(tok);
            if (odgovor.Signal)
            {
                int ID = (int)odgovor.Rezultat;
                Album a = new Album
                {
                    Id = ID
                };
                return a;
            }
            else
            {
                throw new Exception(odgovor.Rezultat.ToString());
            }
        }

        public ZanrAlbuma VratiZanrID()
        {
            ZanrAlbuma zanr = new ZanrAlbuma()
            {

                Id = 0,
                NazivZanra = null

             };
            TransferKlasa zahtev = new TransferKlasa()
            {
                operacija = Operacija.VRATI_ZANR_ID,
                TransferObjekat = zanr
            };
            formater.Serialize(tok, zahtev);

            TransferKlasa odgovor = (TransferKlasa)formater.Deserialize(tok);
            if (odgovor.Signal)
            {
                int ID = (int)odgovor.Rezultat;
                ZanrAlbuma z = new ZanrAlbuma
                {
                    Id = ID
                };
                return z;
            }
            else
            {
                throw new Exception(odgovor.Rezultat.ToString());
            }

        }

            public Pesma KreirajPesmuSO(Pesma pesma)
            {
            TransferKlasa zahtev = new TransferKlasa()
            {
                operacija = Operacija.KREIRAJ_PESMU,
                TransferObjekat = pesma
            };
            formater.Serialize(tok, zahtev);

            TransferKlasa odgovor = (TransferKlasa)formater.Deserialize(tok);
            if (odgovor.Signal)
            {
                
                int ID = (int)odgovor.Rezultat;
                Pesma p = new Pesma
                {
                    Id = ID
                };
                return p;
            }
            else
            {
                throw new Exception(odgovor.Rezultat.ToString());
            }


        }

        public Album KreirajAlbumSO(Album album)
        {
            TransferKlasa zahtev = new TransferKlasa()
            {
                operacija = Operacija.KREIRAJ_ALBUM,
                TransferObjekat = album
            };
            formater.Serialize(tok, zahtev);

            TransferKlasa odgovor = (TransferKlasa)formater.Deserialize(tok);
            if (odgovor.Signal)
            {
                int ID = (int)odgovor.Rezultat;
                Album a = new Album
                {
                    Id = ID
                };
                return a;
            }
            else
            {
                throw new Exception(odgovor.Rezultat.ToString());
            }


        }

        public PesmeAlbuma PretragaPesmaAlbumSO(PesmeAlbuma pesmeAlbuma)
        {
            TransferKlasa zahtev = new TransferKlasa()
            {
                operacija = Operacija.PRETRAGA_PESME_ALBUMA,
                TransferObjekat = pesmeAlbuma
            };
            formater.Serialize(tok, zahtev);

            TransferKlasa odgovor = (TransferKlasa)formater.Deserialize(tok);
            if (odgovor.Signal)
            {
                return (PesmeAlbuma)odgovor.Rezultat;
            }
            else
            {
                throw new Exception(odgovor.Rezultat.ToString());
            }
        }

        public ZanrAlbuma PretragaZanraSO(ZanrAlbuma zanrAlbuma)
        {
            TransferKlasa zahtev = new TransferKlasa()
            {
                operacija = Operacija.PRETRAGA_ZANRA,
                TransferObjekat = zanrAlbuma
            };
            formater.Serialize(tok, zahtev);

            TransferKlasa odgovor = (TransferKlasa)formater.Deserialize(tok);
            if (odgovor.Signal)
            {
                return (ZanrAlbuma)odgovor.Rezultat;
            }
            else
            {
                throw new Exception(odgovor.Rezultat.ToString());
            }
        }

        public Izvodjac PretragaIzvodjacaSO(Izvodjac izvodjac)
        {

            TransferKlasa zahtev = new TransferKlasa()
            {
                operacija = Operacija.PRETRAGA_IZVODJACA,
                TransferObjekat = izvodjac
            };
            formater.Serialize(tok, zahtev);

            TransferKlasa odgovor = (TransferKlasa)formater.Deserialize(tok);
            if (odgovor.Signal)
            {
                return (Izvodjac)odgovor.Rezultat;
            }
            else
            {
                throw new Exception(odgovor.Rezultat.ToString());
            }


        }


        public List<Izvodjac> PronadjiIzvodjacaSO(Izvodjac izvodjac)
        {
            TransferKlasa zahtev = new TransferKlasa()
            {
                operacija = Operacija.PRONADJI_IZVODJACA,
                TransferObjekat = izvodjac
               
            };
            formater.Serialize(tok, zahtev);

            TransferKlasa odgovor = (TransferKlasa)formater.Deserialize(tok);
            if (odgovor.Signal)
            {
                
                return (List<Izvodjac>)odgovor.Rezultat;
            }
            else
            {
                throw new Exception(odgovor.Rezultat.ToString());
            }


        }

        public List<Album> VratiListuAlbumaSO()
        {
            TransferKlasa zahtev = new TransferKlasa()
            {
                operacija = Operacija.VRATI_LISTU_ALBUMA, 
                TransferObjekat = new Album()
            };
            formater.Serialize(tok, zahtev);

            TransferKlasa odgovor = (TransferKlasa)formater.Deserialize(tok);
            if (odgovor.Signal)
            {
                return (List<Album>)odgovor.Rezultat;
                
            }
            else
            {
                throw new Exception(odgovor.Rezultat.ToString());
            }
        }

        public List<ZanrAlbuma> VratiListuZanrovaSO()
        {
            TransferKlasa zahtev = new TransferKlasa()
            {
                operacija = Operacija.VRATI_LISTU_ZANROVA,
                TransferObjekat = new ZanrAlbuma()
            };
            formater.Serialize(tok, zahtev);

            TransferKlasa odgovor = (TransferKlasa)formater.Deserialize(tok);
            if (odgovor.Signal)
            {
                return (List<ZanrAlbuma>)odgovor.Rezultat;

            }
            else
            {
                throw new Exception(odgovor.Rezultat.ToString());
            }

        }

        public List<Izvodjac> VratiListuIzvodjacaSO()
        {
            TransferKlasa zahtev = new TransferKlasa()
            {
                operacija = Operacija.VRATI_LISTU_IZVODJACA,
                TransferObjekat = new Izvodjac() 
            };
            formater.Serialize(tok, zahtev);

            TransferKlasa odgovor = (TransferKlasa)formater.Deserialize(tok);
            if (odgovor.Signal)
            {
                return (List<Izvodjac>)odgovor.Rezultat;

            }
            else
            {
                throw new Exception(odgovor.Rezultat.ToString());
            }


        }

        public ZanrAlbuma ZapamtiZanrSO(ZanrAlbuma zanr)
        {
            TransferKlasa zahtev = new TransferKlasa()
            {
                operacija = Operacija.ZAPAMTI_ZANR,
                TransferObjekat = zanr
            };
            formater.Serialize(tok, zahtev);

            TransferKlasa odgovor = (TransferKlasa)formater.Deserialize(tok);
            if (odgovor.Signal)
            {
                int id = (int)odgovor.Rezultat;
                return zanr;
            }
            else
            {
                throw new Exception(odgovor.Rezultat.ToString());
            }

        }

        public Pesma IzmeniPesmuSO(Pesma pesma)
        {
            TransferKlasa zahtev = new TransferKlasa()
            {
                operacija = Operacija.IZMENI_PESMU,
                TransferObjekat = pesma
            };
            formater.Serialize(tok, zahtev);

            TransferKlasa odgovor = (TransferKlasa)formater.Deserialize(tok);
            if (odgovor.Signal)
            {
                int id = (int)odgovor.Rezultat;
                return pesma;
            }
            else
            {
                throw new Exception(odgovor.Rezultat.ToString());
            }
        }

        public Izvodjac IzmeniIzvodjacaSO(Izvodjac izvodjac)
        {
            TransferKlasa zahtev = new TransferKlasa()
            {
                operacija = Operacija.IZMENI_IZVODJACA,
                TransferObjekat = izvodjac
            };
            formater.Serialize(tok, zahtev);

            TransferKlasa odgovor = (TransferKlasa)formater.Deserialize(tok);
            if (odgovor.Signal)
            {
                int id = (int)odgovor.Rezultat;
                return izvodjac;
            }
            else
            {
                throw new Exception(odgovor.Rezultat.ToString());
            }
        }

        public Izvodjac ZapamtiIzvodjacaSO(Izvodjac izvodjac)
        {
            TransferKlasa zahtev = new TransferKlasa()
            {
                operacija = Operacija.ZAPAMTI_IZVODJACA,
                TransferObjekat = izvodjac
            };
            formater.Serialize(tok, zahtev);

            TransferKlasa odgovor = (TransferKlasa)formater.Deserialize(tok);
            if (odgovor.Signal)
            {
                int id = (int)odgovor.Rezultat;
                return izvodjac;
            }
            else
            {
                throw new Exception(odgovor.Rezultat.ToString());
            }


        }

        public Pesma ZapamtiPesmuSO(Pesma pesma)
        {
            TransferKlasa zahtev = new TransferKlasa()
            {
                operacija = Operacija.ZAPAMTI_PESMU,
                TransferObjekat = pesma
            };
            formater.Serialize(tok, zahtev);

            TransferKlasa odgovor = (TransferKlasa)formater.Deserialize(tok);
            if (odgovor.Signal)
            {
                int id = (int)odgovor.Rezultat;
                return pesma;
            }
            else
            {
                throw new Exception(odgovor.Rezultat.ToString());
            }


        }

        public Album ZapamtiAlbumSO(Album album)
        {
            TransferKlasa zahtev = new TransferKlasa()
            {
                operacija = Operacija.ZAPAMTI_ALBUM,
                TransferObjekat = album
            };
            formater.Serialize(tok, zahtev);

            TransferKlasa odgovor = (TransferKlasa)formater.Deserialize(tok);
            if (odgovor.Signal)
            {
                int id = (int)odgovor.Rezultat;
                return album;
            }
            else
            {
                throw new Exception(odgovor.Rezultat.ToString());
            }


        }

        public PesmeAlbuma DodajPesmaAlbumSO(PesmeAlbuma pesmeAlbuma)
        {

            TransferKlasa zahtev = new TransferKlasa()
            {
                operacija = Operacija.DODAJ_PESMA_ALBUM,
                TransferObjekat = pesmeAlbuma
            };
            formater.Serialize(tok, zahtev);

            TransferKlasa odgovor = (TransferKlasa)formater.Deserialize(tok);
            if (odgovor.Signal)
            {
                
                int id = (int)odgovor.Rezultat;
                return pesmeAlbuma;
            }
            else
            {
                throw new Exception(odgovor.Rezultat.ToString());
            }


        }

        public Pesma PretragaPesmeSO(Pesma pesma)
        {
            Console.WriteLine("ddddd: "+pesma.Id);
            TransferKlasa zahtev = new TransferKlasa()
            {
                operacija = Operacija.PRETRAGA_PESME,
                TransferObjekat = pesma
            };
            formater.Serialize(tok, zahtev);

            TransferKlasa odgovor = (TransferKlasa)formater.Deserialize(tok);
            if (odgovor.Signal)
            {
                return (Pesma)odgovor.Rezultat;
            }
            else
            {
                throw new Exception(odgovor.Rezultat.ToString());
            }


        }

        public List<PesmeAlbuma> PronadjiPesmaAlbumSO(PesmeAlbuma pesmeAlbuma)
        {
          
            TransferKlasa zahtev = new TransferKlasa()
            {
                operacija = Operacija.PRONADJI_PESMU_ALBUMA,
                TransferObjekat = pesmeAlbuma
            };
            formater.Serialize(tok, zahtev);

            TransferKlasa odgovor = (TransferKlasa)formater.Deserialize(tok);
            if (odgovor.Signal)
            {
                return (List<PesmeAlbuma>)odgovor.Rezultat;
            }
            else
            {
                throw new Exception(odgovor.Rezultat.ToString());
            }
        }

        public List<Pesma> PronadjiPesmuSO(Pesma pesma)
        {
            TransferKlasa zahtev = new TransferKlasa()
            {
                operacija = Operacija.PRONADJI_PESMU,
                TransferObjekat = pesma
            };
            formater.Serialize(tok, zahtev);

            TransferKlasa odgovor = (TransferKlasa)formater.Deserialize(tok);
            if (odgovor.Signal)
            {
                return (List<Pesma>)odgovor.Rezultat;
            }
            else
            {
                throw new Exception(odgovor.Rezultat.ToString());
            }


        }

        public List<Pesma> VratiListuPesamaSO()
        {
            TransferKlasa zahtev = new TransferKlasa()
            {
                operacija = Operacija.VRATI_LISTU_PESAMA,
                TransferObjekat = new Pesma() //????????
            };
            formater.Serialize(tok, zahtev);

            TransferKlasa odgovor = (TransferKlasa)formater.Deserialize(tok);
            if (odgovor.Signal)
            {
                
                return (List<Pesma>) odgovor.Rezultat;
            }
            else
            {
                throw new Exception(odgovor.Rezultat.ToString());
            }


        }

        public void obrisiPesmeAlbumaSO(PesmeAlbuma pesmeAlbum)
        {
            TransferKlasa zahtev = new TransferKlasa()
            {
                operacija = Operacija.OBRISI_PESME_ALBUM,
                TransferObjekat = pesmeAlbum
            };
            formater.Serialize(tok, zahtev);

            TransferKlasa odgovor = (TransferKlasa)formater.Deserialize(tok);
            if (odgovor.Signal)
            {
                //int id = (int)odgovor.Rezultat;
                //return pesmeAlbum;
            }
            else
            {
                throw new Exception(odgovor.Rezultat.ToString());
            }
        }


        public void ObrisiAlbumSO(Album album)
        {
            TransferKlasa zahtev = new TransferKlasa()
            {
                operacija = Operacija.OBRISI_ALBUM,
                TransferObjekat = album
            };
            formater.Serialize(tok, zahtev);

            TransferKlasa odgovor = (TransferKlasa)formater.Deserialize(tok);
            if (odgovor.Signal)
            {
                //int id = (int)odgovor.Rezultat;
                //return album;
            }
            else
            {
                throw new Exception(odgovor.Rezultat.ToString());
            }


        }

        public Album PretragaAlbumaSO(Album album)
        {
            TransferKlasa zahtev = new TransferKlasa()
            {
                operacija = Operacija.PRETRAGA_ALBUMA,
                TransferObjekat = album
            };
            formater.Serialize(tok, zahtev);

            TransferKlasa odgovor = (TransferKlasa)formater.Deserialize(tok);
            if (odgovor.Signal)
            {
                int id = (int)odgovor.Rezultat;
                return album;
            }
            else
            {
                throw new Exception(odgovor.Rezultat.ToString());
            }


        }

        public List<Album> PronadjiAlbumSO(Album album)
        {
            TransferKlasa zahtev = new TransferKlasa()
            {
                operacija = Operacija.PRONADJI_ALBUM,
                TransferObjekat = album
            };
            formater.Serialize(tok, zahtev);

            TransferKlasa odgovor = (TransferKlasa)formater.Deserialize(tok);
            if (odgovor.Signal)
            {
                return (List<Album>)odgovor.Rezultat;
            }
            else
            {
                throw new Exception(odgovor.Rezultat.ToString());
            }


        }
      
        public void kraj()
        {
            TransferKlasa zahtev = new TransferKlasa()
            {
                operacija = Operacija.KRAJ,
            };
            formater.Serialize(tok, zahtev);
        }

    }
}
