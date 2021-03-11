using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;

namespace SistemskeOperacije
{
    public class ObrisiAlbumSO : OpstaSistemskaOperacija
    {
        protected override object IzvrsiKonkretnuOperaciju(IDomenskiObjekat domenskiObjekat)
        {
            try
            {
                Rezultat = Broker.BrokerBaze.dajSesiju().Obrisi(domenskiObjekat);
                Signal = true;
                return true;
            }
            catch (Exception)
            {
                Signal = false;
                return false;
            }
            
        }
    }
}
