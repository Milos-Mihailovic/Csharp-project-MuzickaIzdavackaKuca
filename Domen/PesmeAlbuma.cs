using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    [Serializable]
    public class PesmeAlbuma : IDomenskiObjekat
    {

        int id;
        Pesma pesma = new Pesma();
        Album album = new Album();

        public int Id { get => id; set => id = value; }
        public Pesma Pesma { get => pesma; set => pesma = value; }
        public Album Album { get => album; set => album = value; }

        public string ImeKljuca()
        {
            return "PesmeAlbuma.ID";
        }

        public List<IDomenskiObjekat> ListaObjekata(SqlDataReader citac)
        {
            List<IDomenskiObjekat> lista = new List<IDomenskiObjekat>();
            while (citac.Read())
            {
                PesmeAlbuma pesmeAlbuma = new PesmeAlbuma()
                {
                    Pesma = new Pesma()
                    {
                        Id = (int)citac["PesmaID"]
                    },
                    Album = new Album
                    {
                        Id = (int)citac["AlbumID"]
                    },
                    Id = (int)citac["ID"]
                };
                lista.Add(pesmeAlbuma);
            }
            return lista;
        }

        public object NazivTabele()
        {
            return "PesmeAlbuma";
        }

        public object PodesiParametreZaIzmenu()
        {
            throw new NotImplementedException();
        }

        public object VratiKljuc()
        {
            return $"{ImeKljuca()} = {Id}";
        }

        public object VratiUslov()
        {
            return $"PesmeAlbuma.AlbumID = {Album.Id}";
        }

        public object VratiUslovZaBrisanje()
        {
            return $"PesmeAlbuma.AlbumID = {Album.Id}";
        }

        public object VratiVrednostiZaInsert()
        {
            return $"{Pesma.Id}, {Album.Id}, {Id}"; 
        }
    }
}
