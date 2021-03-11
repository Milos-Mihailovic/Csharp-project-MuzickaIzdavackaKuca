using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;

namespace SistemskeOperacije
{
    public class PronadjiPesmeAlbumaSO : OpstaSistemskaOperacija
    {
        protected override object IzvrsiKonkretnuOperaciju(IDomenskiObjekat domenskiObjekat)
        {
            try
            {
                PesmeAlbuma pesmeAlbuma = (PesmeAlbuma)domenskiObjekat;
                Rezultat = Broker.BrokerBaze.dajSesiju().VratiPoKriterijumu(pesmeAlbuma).OfType<PesmeAlbuma>().ToList<PesmeAlbuma>();
                // za svaku pesmu albuma
                // dodaj pesmu vratiZaID
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
