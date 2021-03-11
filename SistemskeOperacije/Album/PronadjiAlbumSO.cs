using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;

namespace SistemskeOperacije
{
    public class PronadjiAlbumSO : OpstaSistemskaOperacija
    {
        protected override object IzvrsiKonkretnuOperaciju(IDomenskiObjekat domenskiObjekat)
        {
            try
            {
                Album album = (Album)domenskiObjekat;
                Rezultat = Broker.BrokerBaze.dajSesiju().VratiPoKriterijumu(album).OfType<Album>().ToList<Album>();
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
