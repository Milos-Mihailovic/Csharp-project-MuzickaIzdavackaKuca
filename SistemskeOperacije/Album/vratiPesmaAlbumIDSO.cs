using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;

namespace SistemskeOperacije
{
    public class VratiPesmaAlbumIDSO : OpstaSistemskaOperacija
    {
        protected override object IzvrsiKonkretnuOperaciju(IDomenskiObjekat domenskiObjekat)
        {
            try
            {
                PesmeAlbuma pa = (PesmeAlbuma)domenskiObjekat;
                pa.Id = Broker.BrokerBaze.dajSesiju().DajSifru(domenskiObjekat);
                Rezultat = pa.Id;
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
