using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    public enum Operacija {
        KRAJ,
        LOGIN,
        DODAJ_PESMA_ALBUM,
        VRATI_ALBUM_ID,
        VRATI_ZANR_ID,
        VRATI_IZVODJAC_ID,
        VRATI_PESMA_ID,
        VRATI_PESMA_ALBUM_ID,
        IZMENI_IZVODJACA,
        IZMENI_PESMU,
        KREIRAJ_ALBUM,
        KREIRAJ_NOVOG_IZVODJACA,
        KREIRAJ_PESMU,
        KREIRAJ_NOVI_ZANR,
        OBRISI_ALBUM,
        OBRISI_PESME_ALBUM,
        PRETRAGA_ALBUMA,
        PRETRAGA_PESME_ALBUMA,
        PRETRAGA_ZANRA,
        PRETRAGA_IZVODJACA,
        PRETRAGA_PESME,
        PRONADJI_ALBUM,
        PRONADJI_PESMU_ALBUMA,
        PRONADJI_IZVODJACA,
        PRONADJI_PESMU,
        VRATI_LISTU_IZVODJACA,
        VRATI_LISTU_PESAMA,
        VRATI_LISTU_ALBUMA,
        VRATI_LISTU_ZANROVA,
        ZAPAMTI_ZANR,
        ZAPAMTI_ALBUM,
        ZAPAMTI_IZVODJACA,
        ZAPAMTI_PESMU
        
    }

    [Serializable]
    public class TransferKlasa
    {
        public Operacija operacija { get; set; }
        public object TransferObjekat { get; set; }
        public GlavniUrednik GlavniUrednik { get; set; }
        public Object Rezultat { get; set; }
        public string Poruka { get; set; }
        public bool Signal { get; set; }
        public string Unos { get; set; }
    }
}
