using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    [Serializable]
    public class GlavniUrednik : IDomenskiObjekat
    {
        int id;
        string ime;
        string prezime;
        string username;
        string password;

        public int Id { get => id; set => id = value; }
        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }

        public string ImeKljuca()
        {
            return "GlavniUrednik.ID";
        }

        public List<IDomenskiObjekat> ListaObjekata(SqlDataReader citac)
        {
            List<IDomenskiObjekat> lista = new List<IDomenskiObjekat>();
            while (citac.Read())
            {
                GlavniUrednik glavniUrednik = new GlavniUrednik()
                {
                    Id = (int)citac["ID"],
                    Ime = citac["Ime"] as string,
                    Prezime = citac["Prezime"] as string,
                    Username = citac["User"] as string,
                    Password = citac["Password"] as string,
                };
                lista.Add(glavniUrednik);
            }
            return lista;
        }

        public object NazivTabele()
        {
            return "GlavniUrednik";
        }

        public object PodesiParametreZaIzmenu()
        {
            return $"GlavniUrednik.[User] = '{Username}', GlavniUrednik.Password = '{Password}'";
        }

        public object VratiKljuc()
        {
            return $"{ImeKljuca()} = {Id}";
        }

        public object VratiKoloneZaInsert()
        {
            throw new NotImplementedException();
        }

        public object VratiUslov()
        {
            return (Username == null) ? $"(GlavniUrednik.Ime LIKE '%{Ime}%' or GlavniUrednik.Prezime LIKE '%{Prezime}%') " : $"(GlavniUrednik.[User] LIKE '{Username}' AND GlavniUrednik.Password LIKE '{Password}')";
        }

        public object VratiVrednostiZaInsert()
        {
            throw new NotImplementedException();
        }

        public object VratiUslovZaBrisanje()
        {
            throw new NotImplementedException();
        }
    }
}
