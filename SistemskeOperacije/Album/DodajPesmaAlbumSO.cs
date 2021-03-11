using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;

namespace SistemskeOperacije
{
    public class DodajPesmaAlbumSO : OpstaSistemskaOperacija
    {
        protected override object IzvrsiKonkretnuOperaciju(IDomenskiObjekat domenskiObjekat)
        {

            try
            {
                PesmeAlbuma pa = (PesmeAlbuma)domenskiObjekat;
                Console.WriteLine("XXX :"+pa.Id);
                pa.Id = Broker.BrokerBaze.dajSesiju().Sacuvaj(domenskiObjekat);
                Rezultat = pa.Id;
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
