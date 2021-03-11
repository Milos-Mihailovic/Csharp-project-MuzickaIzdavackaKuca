﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;

namespace SistemskeOperacije
{
    public class IzmeniPesmuSO : OpstaSistemskaOperacija
    {
        protected override object IzvrsiKonkretnuOperaciju(IDomenskiObjekat domenskiObjekat)
        {
            try
            {
                Pesma pesma = (Pesma)domenskiObjekat;
                pesma.Id = Broker.BrokerBaze.dajSesiju().Izmena(domenskiObjekat);
                Rezultat = pesma.Id;
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
