
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    [Serializable]
    public class Izvodjac : IDomenskiObjekat
    {
        int id;
        string ime;
        string prezime;
        string trajanjeUgovora;
        string email;
        string telefon;
        public string ImePrezime
        {
            get
            {
                return Ime + " " + Prezime;
            }
        }

        public int Id { get => id; set => id = value; }
        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public string TrajanjeUgovora { get => trajanjeUgovora; set => trajanjeUgovora = value; }
        public string Email { get => email; set => email = value; }
        public string Telefon { get => telefon; set => telefon = value; }

        public string ImeKljuca()
        {
            return "Izvodjac.ID";
        }

        public List<IDomenskiObjekat> ListaObjekata(SqlDataReader citac)
        {
            List<IDomenskiObjekat> lista = new List<IDomenskiObjekat>();
            while (citac.Read())
            {
                Izvodjac izvodjac = new Izvodjac()
                {
                    Id = (int)citac["ID"],
                    Ime = citac["Ime"] as string,
                    Prezime = citac["Prezime"] as string,
                    TrajanjeUgovora = citac["TrajanjeUgovora"] as string,
                    Email = citac["Email"] as string,
                    Telefon = citac["Telefon"] as string
                };
                lista.Add(izvodjac);

            }
            return lista;
        }

        public object NazivTabele()
        {
            return "Izvodjac";
        }

        public object PodesiParametreZaIzmenu()
        {
            return $"Ime = '{Ime}', Prezime = '{Prezime}', TrajanjeUgovora = '{TrajanjeUgovora}', Email = '{Email}', Telefon = '{Telefon}'";
        }

        public object VratiKljuc()
        {
            return $"{ImeKljuca()} = {Id}";
        }

        public object VratiKoloneZaInsert()
        {
            return $"Ime, Prezime, TrajanjeUgovora, Email, Telefon";
        }

        public object VratiUslov()
        {
            return $"Izvodjac.Ime LIKE '%{Ime}%' or Izvodjac.Prezime LIKE '%{Ime}%'";
        }

        public object VratiVrednostiZaInsert()
        {
            return $"{Id},'{Ime}', '{Prezime}', '{TrajanjeUgovora}', '{Email}', '{Telefon}'";
        }

        public object VratiUslovZaBrisanje()
        {
            throw new NotImplementedException();
        }
    }

}
