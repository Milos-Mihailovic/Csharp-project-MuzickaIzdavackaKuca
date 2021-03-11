using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;

namespace SistemskeOperacije
{
    public class LoginSO : OpstaSistemskaOperacija
    {
        protected override object IzvrsiKonkretnuOperaciju(IDomenskiObjekat domenskiObjekat)
        {
            try
            {
                GlavniUrednik glavniUrednik = (GlavniUrednik)domenskiObjekat;
                List<GlavniUrednik> listaUrednik = Broker.BrokerBaze.dajSesiju().VratiPoKriterijumu(domenskiObjekat).OfType<GlavniUrednik>().ToList<GlavniUrednik>();
                GlavniUrednik urednik = listaUrednik.Single();
                Rezultat = urednik;
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
