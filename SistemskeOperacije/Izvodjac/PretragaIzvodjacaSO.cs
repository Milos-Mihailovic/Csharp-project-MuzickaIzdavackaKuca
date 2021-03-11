using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;

namespace SistemskeOperacije
{
    public class PretragaIzvodjacaSO : OpstaSistemskaOperacija
    {
        protected override object IzvrsiKonkretnuOperaciju(IDomenskiObjekat domenskiObjekat)
        {
            try
            {
                Izvodjac izvodjac = (Izvodjac)domenskiObjekat;
                Rezultat = Broker.BrokerBaze.dajSesiju().VratiTacanObjekat(izvodjac);
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
