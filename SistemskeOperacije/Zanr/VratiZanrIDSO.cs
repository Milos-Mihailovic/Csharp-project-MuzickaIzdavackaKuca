using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;

namespace SistemskeOperacije
{
    public class VratiZanrIDSO : OpstaSistemskaOperacija
    {
        protected override object IzvrsiKonkretnuOperaciju(IDomenskiObjekat domenskiObjekat)
        {
            try
            {
                ZanrAlbuma zanr = (ZanrAlbuma)domenskiObjekat;
                zanr.Id = Broker.BrokerBaze.dajSesiju().DajSifru(domenskiObjekat);
                Rezultat = zanr.Id;
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
