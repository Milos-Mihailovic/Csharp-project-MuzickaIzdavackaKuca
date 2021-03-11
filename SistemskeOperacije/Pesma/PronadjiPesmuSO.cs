using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;

namespace SistemskeOperacije
{
    public class PronadjiPesmuSO : OpstaSistemskaOperacija
    {
        protected override object IzvrsiKonkretnuOperaciju(IDomenskiObjekat domenskiObjekat)
        {
            try
            {
                Pesma pesma = (Pesma)domenskiObjekat;
                Rezultat = Broker.BrokerBaze.dajSesiju().VratiPoKriterijumu(pesma).OfType<Pesma>().ToList<Pesma>();
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
