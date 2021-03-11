using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;

namespace SistemskeOperacije
{
    public class PronadjiIzvodjacaSO : OpstaSistemskaOperacija
    {
        protected override object IzvrsiKonkretnuOperaciju(IDomenskiObjekat domenskiObjekat)
        {
            try
            {
                Izvodjac izvodjac = (Izvodjac)domenskiObjekat;
                Rezultat = Broker.BrokerBaze.dajSesiju().VratiPoKriterijumu(izvodjac).OfType<Izvodjac>().ToList<Izvodjac>();
                Signal = true;
                return true;
            }
            catch (Exception e)
            {
                Signal = true;
                return true;
            }

        }
    }
}
