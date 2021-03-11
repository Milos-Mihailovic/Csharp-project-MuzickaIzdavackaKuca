using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Domen;
using System.Data;
using System.Data.SqlClient;

namespace Broker
{
    public class BrokerBaze
    {
        SqlCommand komanda;
        SqlConnection konekcija;
        SqlTransaction transakcija;

        void konektujSe()
        {
            konekcija = new SqlConnection(@"Data Source=MILOS-NOTE;Initial Catalog=MuzickaIzdavackaKuca;Integrated Security=True");
            komanda = konekcija.CreateCommand();
        }

        BrokerBaze()
        {
            konektujSe();
        }

        static BrokerBaze instanca;
        public static BrokerBaze dajSesiju()
        {
            if (instanca == null)
            {
                instanca = new BrokerBaze();
            }
            return instanca;
        }

        public List<IDomenskiObjekat> VratiSve(IDomenskiObjekat ido)
        {
            string upit = $"SELECT * FROM {ido.NazivTabele()}";
            SqlCommand komanda = new SqlCommand(upit, konekcija, transakcija);
            SqlDataReader citac = komanda.ExecuteReader();
            List<IDomenskiObjekat> rezultat = ido.ListaObjekata(citac);
            citac.Close();
            try
            {
                return rezultat;
            }
            catch (Exception)
            {

                throw new Exception("Greška!");
            }
        }

        public List<IDomenskiObjekat> VratiPoKriterijumu(IDomenskiObjekat ido)
        {
            string upit = $"select * from {ido.NazivTabele()} where {ido.VratiUslov()}";
            SqlCommand komanda = new SqlCommand(upit, konekcija, transakcija);
            SqlDataReader citac = komanda.ExecuteReader();
            List<IDomenskiObjekat> rezultat = ido.ListaObjekata(citac);
            citac.Close();
            try
            {
                return rezultat;
            }
            catch (Exception)
            {

                throw new Exception("Greška!");
            }
        }

        public IDomenskiObjekat VratiTacanObjekat(IDomenskiObjekat ido)
        {
            string upit = $"Select * from {ido.NazivTabele()} where {ido.VratiKljuc()}";
            SqlCommand komanda = new SqlCommand(upit, konekcija, transakcija);
            SqlDataReader citac = komanda.ExecuteReader();
            List<IDomenskiObjekat> rez = ido.ListaObjekata(citac);
            citac.Close();
            return rez.FirstOrDefault();
        }

        public IDomenskiObjekat Vratiizvodjaca(IDomenskiObjekat ido, string vrednost)
        {
            komanda.CommandText = $"Select * from {ido.NazivTabele()} where {vrednost}";
            komanda.CommandType = CommandType.Text;
            SqlDataReader citac = komanda.ExecuteReader();
            List<IDomenskiObjekat> rez = ido.ListaObjekata(citac);
            citac.Close();
            return rez.FirstOrDefault();
        }



        public int Sacuvaj(IDomenskiObjekat ido)
        {
            string upit = $"insert into {ido.NazivTabele()} values ({ido.VratiVrednostiZaInsert()})";
            SqlCommand komanda = new SqlCommand(upit, konekcija, transakcija);
            try
            {
                return komanda.ExecuteNonQuery();
            }
            catch (Exception e)
            {

                throw new Exception("Greška!");
            }
        }

        public int Izmena(IDomenskiObjekat ido)
        {
            Console.WriteLine("sdasd:    "+ ido.PodesiParametreZaIzmenu());
            string upit = $"update {ido.NazivTabele()} set {ido.PodesiParametreZaIzmenu()} where {ido.VratiKljuc()}";

            SqlCommand komanda = new SqlCommand(upit, konekcija, transakcija);
            try
            {
                return komanda.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw new Exception("Greška!");
            }
        }

        public int Obrisi(IDomenskiObjekat ido)
        {
            string upit = $"delete from {ido.NazivTabele()} where {ido.VratiUslovZaBrisanje()}";
            SqlCommand komanda = new SqlCommand(upit, konekcija, transakcija);
            try
            {
                return komanda.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw new Exception("Greška!");
            }
        }

        public int DajSifru(IDomenskiObjekat ido)
        {
            string upit = @"select MAX("+ido.ImeKljuca()+") from "+ido.NazivTabele()+"";
            SqlCommand komanda = new SqlCommand(upit, konekcija, transakcija);
            try
            {
                try
                {
                    int sifra = Convert.ToInt32(komanda.ExecuteScalar());
                    return sifra + 1;
                }
                catch (Exception)
                {

                    return 1;
                }
            }
            catch (Exception)
            {

                throw new Exception("Greška!");
            }
        }

        public void OtvoriKonekciju()
        {
            konekcija.Open();
        }

        public void ZatvoriKonekciju()
        {
            konekcija.Close();
        }

        public void PocniTransakciju()
        {
            transakcija = konekcija.BeginTransaction();
        }
        
        public void PotvrdiTransakciju()
        {
            transakcija.Commit();
        }

        public void PonistiTransakciju()
        {
            transakcija.Rollback();
        }

    }
}
