using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    [Serializable]
    public class Album : IDomenskiObjekat
    {
        int id;
        ZanrAlbuma zanrAlbuma = new ZanrAlbuma();
        string nazivAlbuma;


        public int Id { get => id; set => id = value; }
        public ZanrAlbuma ZanrAlbuma { get => zanrAlbuma; set => zanrAlbuma = value; }
        public string NazivAlbuma { get => nazivAlbuma; set => nazivAlbuma = value; }

        public string ImeKljuca()
        {
            return "Album.ID";
        }

        public List<IDomenskiObjekat> ListaObjekata(SqlDataReader citac)
        {
            List<IDomenskiObjekat> lista = new List<IDomenskiObjekat>();
            while (citac.Read())
            {
                Album album = new Album()
                {
                    Id = (int)citac["ID"],
                    ZanrAlbuma = new ZanrAlbuma()
                    {
                        Id = (int)citac["ZanrAlbumaID"],
                    },
                    NazivAlbuma = citac["Naziv"] as string
                };
                lista.Add(album);
            }
            return lista;
        }

        public object NazivTabele()
        {
            return "Album";
        }

        public object PodesiParametreZaIzmenu()
        {
            return $"ZanrAlbumaID = {ZanrAlbuma} Naziv = '{NazivAlbuma}'";
        }

        public object VratiKljuc()
        {
            return $"{ImeKljuca()} = {Id}";
        }

        public object VratiKoloneZaInsert()
        {
            return $"ZanrAlbumaID, Naziv";
        }

        public object VratiUslov()
        {
            return $"Album.Naziv = '{NazivAlbuma}'"; 
        }

        public object VratiUslovZaBrisanje()
        {
            return $"Album.ID = {Id}";
        }

        public object VratiVrednostiZaInsert()
        {
            return $"{Id}, {ZanrAlbuma.Id},'{NazivAlbuma}'";
        }
    }
}
