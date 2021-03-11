using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    [Serializable]
    public class ZanrAlbuma : IDomenskiObjekat
    {
        int id;
        string nazivZanra;

        public int Id { get => id; set => id = value; }
        public string NazivZanra { get => nazivZanra; set => nazivZanra = value; }

        public string ImeKljuca()
        {
            return "ZanrAlbuma.ID";
        }

        public List<IDomenskiObjekat> ListaObjekata(SqlDataReader citac)
        {
            List<IDomenskiObjekat> lista = new List<IDomenskiObjekat>();
            while (citac.Read())
            {
                ZanrAlbuma zanrAlbuma = new ZanrAlbuma()
                {
                    Id = (int)citac["ID"],
                    NazivZanra = citac["NazivZanra"] as string,

                };
                lista.Add(zanrAlbuma);
            }
            return lista;
        }

        public object NazivTabele()
        {
            return "ZanrAlbuma";
        }

        public object PodesiParametreZaIzmenu()
        {
            return $"NazivZanra = '{NazivZanra}'";
        }

        public object VratiKljuc()
        {
            return $"{ImeKljuca()} = {Id}";
        }

        public object VratiKoloneZaInsert()
        {
            return $"ID, NazivZanra";
        }

        public object VratiUslov()
        {
            return $"ZanrAlbuma.NazivZanra LIKE '%{NazivZanra}%'";
        }

        public object VratiVrednostiZaInsert()
        {
            return $"{Id},'{NazivZanra}'";
        }

        public object VratiUslovZaBrisanje()
        {
            throw new NotImplementedException();
        }
    }
}
