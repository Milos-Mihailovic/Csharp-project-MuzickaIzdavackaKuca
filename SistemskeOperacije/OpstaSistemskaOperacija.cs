using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije
{
    public abstract class OpstaSistemskaOperacija
    {
        public object Rezultat { get; set; }
        public bool Signal { get; set; }
        //public string Poruka { get; set; }

        public object IzvrsiSO(IDomenskiObjekat domenskiObjekat)
        {
            
                //template izvrsavanja
                Broker.BrokerBaze.dajSesiju().OtvoriKonekciju();
                Broker.BrokerBaze.dajSesiju().PocniTransakciju();
                IzvrsiKonkretnuOperaciju(domenskiObjekat);
                if (Signal)
                {
                    Broker.BrokerBaze.dajSesiju().PotvrdiTransakciju();
                }
                else
                {
                    Broker.BrokerBaze.dajSesiju().PonistiTransakciju();
                }
                Broker.BrokerBaze.dajSesiju().ZatvoriKonekciju();
                return Signal;
           
        }

        protected abstract object IzvrsiKonkretnuOperaciju(IDomenskiObjekat domenskiObjekat);
    }
}
