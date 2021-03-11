using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;

namespace SistemskeOperacije
{
    public class VratiIzvodjacIDSO : OpstaSistemskaOperacija
    {
        protected override object IzvrsiKonkretnuOperaciju(IDomenskiObjekat domenskiObjekat)
        {
            try
            {
                Izvodjac izvodjac = (Izvodjac)domenskiObjekat;
                izvodjac.Id = Broker.BrokerBaze.dajSesiju().DajSifru(domenskiObjekat);
                Rezultat = izvodjac.Id;
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
