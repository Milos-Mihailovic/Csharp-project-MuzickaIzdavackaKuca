using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    [Serializable]
    public class Pesma : IDomenskiObjekat
    {
        int id;
        string numera;
        Izvodjac izvodjac = new Izvodjac();
        string tekstopisac;
        string tekstPesme;
        string email;
        string telefon;

        public int Id { get => id; set => id = value; }
        public string Numera { get => numera; set => numera = value; }
        public Izvodjac Izvodjac { get => izvodjac; set => izvodjac = value; }
        public string Tekstopisac { get => tekstopisac; set => tekstopisac = value; }
        public string TekstPesme { get => tekstPesme; set => tekstPesme = value; }
        public string Email { get => email; set => email = value; }
        public string Telefon { get => telefon; set => telefon = value; }

        public string ImeKljuca()
        {
            return "Pesma.ID";
        }

        public List<IDomenskiObjekat> ListaObjekata(SqlDataReader citac)
        {
            List<IDomenskiObjekat> lista = new List<IDomenskiObjekat>();
            while (citac.Read())
            {
                Pesma pesma = new Pesma()
                {
                    Id = (int)citac["ID"],
                    Numera = citac["Numera"] as string,
                    Izvodjac = new Izvodjac()
                    {
                        Id = (int)citac["IzvodjacID"],
                    },
                    Tekstopisac = citac["Tekstopisac"] as string,
                    TekstPesme = citac["TekstPesme"] as string,
                    Email = citac["EmailTekstopisca"] as string,
                    Telefon = citac["TelefonTekstopisca"] as string
                };
                lista.Add(pesma);
            }
            return lista;
        }

        public object NazivTabele()
        {
            return "Pesma";
        }

        public object PodesiParametreZaIzmenu()
        {
            return $"Numera = '{Numera}', IzvodjacID = {Izvodjac.Id}, Tekstopisac = '{Tekstopisac}', TekstPesme = '{TekstPesme}', EmailTekstopisca = '{Email}', TelefonTekstopisca = '{Telefon}'";
        }

        public object VratiKljuc()
        {
            return $"{ImeKljuca()} = {Id}";
        }

        public object VratiKoloneZaInsert()
        {
            return $"Numera, IzvodjacID, Tekstopisac, TekstPesme, EmailTekstopisca, TelefonTekstopisca";
        }

        public object VratiUslov()
        {
            return $"Pesma.Numera LIKE '%{Numera}%'";
        }

        public object VratiVrednostiZaInsert()
        {
            return $"{Id}, '{Numera}', {Izvodjac.Id}, '{Tekstopisac}', '{TekstPesme}', '{Email}', '{Telefon}'";
        }

        public object VratiUslovZaBrisanje()
        {
            throw new NotImplementedException();
        }
    }
}
