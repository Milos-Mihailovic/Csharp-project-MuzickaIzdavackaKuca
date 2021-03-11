using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;

namespace SistemskeOperacije
{
    public class VratiAlbumIDSO : OpstaSistemskaOperacija
    {
        protected override object IzvrsiKonkretnuOperaciju(IDomenskiObjekat domenskiObjekat)
        {
            try
            {
                Album album = (Album)domenskiObjekat;
                album.Id = Broker.BrokerBaze.dajSesiju().DajSifru(domenskiObjekat);
                Rezultat = album.Id;
                Signal = true;
                return true;
            }
            catch (Exception e)
            {
                Signal = false;
                return false;
            }
           
            
        }
    }
}
