using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;

namespace SistemskeOperacije
{
    public class PretragaAlbumaSO : OpstaSistemskaOperacija
    {
        protected override object IzvrsiKonkretnuOperaciju(IDomenskiObjekat domenskiObjekat)
        {
            try
            {
                Rezultat = Broker.BrokerBaze.dajSesiju().VratiTacanObjekat(domenskiObjekat);
                Signal = true;
                return false;
            }
            catch (Exception e)
            {
                Signal = false;
                return false;
            }
            

        }
    }
}
