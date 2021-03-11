﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;

namespace SistemskeOperacije
{
    public class VratiListuAlbumaSO : OpstaSistemskaOperacija
    {
        protected override object IzvrsiKonkretnuOperaciju(IDomenskiObjekat domenskiObjekat)
        {
            try
            {
                Rezultat = Broker.BrokerBaze.dajSesiju().VratiSve(domenskiObjekat).OfType<Album>().ToList<Album>();
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
