using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Domen;
using SistemskeOperacije;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;

namespace Server
{
    public class Kontroler
    {

        private static Kontroler _instance;

        private Kontroler()
        {
            
        }

        public static Kontroler Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Kontroler();
                }
                return _instance;
            }
        }

        public OpstaSistemskaOperacija Login(GlavniUrednik glavniUrednik)
        {
            OpstaSistemskaOperacija operacija = new LoginSO();
            operacija.IzvrsiSO(glavniUrednik);
            return operacija;
        }
        
        public OpstaSistemskaOperacija VratiPesmaAlbumID(PesmeAlbuma pa)
        {
            OpstaSistemskaOperacija operacija = new VratiPesmaAlbumIDSO();
            operacija.IzvrsiSO(pa);
            return operacija;
        }
        public OpstaSistemskaOperacija VratiZanrID(ZanrAlbuma zanrAlbuma)
        {
            OpstaSistemskaOperacija operacija = new VratiZanrIDSO();
            operacija.IzvrsiSO(zanrAlbuma);
            return operacija;
        }

        public OpstaSistemskaOperacija VratiPesmaID(Pesma pesma)
        {
            OpstaSistemskaOperacija operacija = new VratiPesmaIDSO();
            operacija.IzvrsiSO(pesma);
            return operacija;
        }

        public OpstaSistemskaOperacija VratiIzvodjacID(Izvodjac izvodjac)
        {
            OpstaSistemskaOperacija operacija = new VratiIzvodjacIDSO();
            operacija.IzvrsiSO(izvodjac);
            return operacija;
        }

        public OpstaSistemskaOperacija VratiAlbumID(Album album)
        {
            OpstaSistemskaOperacija operacija = new VratiAlbumIDSO();
            operacija.IzvrsiSO(album);
            return operacija;
        }
        
        public OpstaSistemskaOperacija PretragaPesmeAlbuma(PesmeAlbuma pesmeAlbuma)
        {
            OpstaSistemskaOperacija operacija = new PretragaPesmeAlbumaSO();
            operacija.IzvrsiSO(pesmeAlbuma);
            return operacija;
        }

        public OpstaSistemskaOperacija PretragaZanra(ZanrAlbuma zanrAlbuma)
        {
            OpstaSistemskaOperacija operacija = new PretragaZanraSO();
            operacija.IzvrsiSO(zanrAlbuma);
            return operacija;
        }

        public OpstaSistemskaOperacija PretragaIzvodjaca(Izvodjac izvodjac)
        {
            OpstaSistemskaOperacija operacija = new PretragaIzvodjacaSO();
            operacija.IzvrsiSO(izvodjac);
            return operacija;
        }
        public OpstaSistemskaOperacija PronadjiIzvodjaca(Izvodjac izvodjac)
        {
            OpstaSistemskaOperacija operacija = new PronadjiIzvodjacaSO();
            operacija.IzvrsiSO(izvodjac);
            return operacija;
        }
        public OpstaSistemskaOperacija VratiListuIzvodjaca(Izvodjac izvodjac)
        {
            OpstaSistemskaOperacija operacija = new VratiListuIzvodjacaSO();
            operacija.IzvrsiSO(izvodjac);
            return operacija;
        }

        public OpstaSistemskaOperacija VratiListuAlbuma(Album album)
        {
            OpstaSistemskaOperacija operacija = new VratiListuAlbumaSO();
            operacija.IzvrsiSO(album);

            return operacija;

        }

        public OpstaSistemskaOperacija VratiListuZanrova(ZanrAlbuma zanrAlbuma)
        {
            OpstaSistemskaOperacija operacija = new VratiListuZanrovaSO();
            operacija.IzvrsiSO(zanrAlbuma);
            return operacija;
        }

        public OpstaSistemskaOperacija ZapamtiZanr(ZanrAlbuma zanrAlbuma)
        {
            OpstaSistemskaOperacija operacija = new ZapamtiZanrSO();
            operacija.IzvrsiSO(zanrAlbuma);
            return operacija;
        }


        public OpstaSistemskaOperacija IzmeniPesmu(Pesma pesma)
        {

            OpstaSistemskaOperacija operacija = new IzmeniPesmuSO();
            operacija.IzvrsiSO(pesma);
            return operacija;
        }

        public OpstaSistemskaOperacija IzmeniIzvodjaca(Izvodjac izvodjac)
        {
            
            OpstaSistemskaOperacija operacija = new IzmeniIzvodjacaSO();
            operacija.IzvrsiSO(izvodjac);
            return operacija;
        }

        public OpstaSistemskaOperacija ZapamtiIzvodjaca(Izvodjac izvodjac)
        {
            OpstaSistemskaOperacija operacija = new ZapamtiIzvodjacaSO();
            operacija.IzvrsiSO(izvodjac);
            return operacija;
        }

        public OpstaSistemskaOperacija PretragaPesme(Pesma pesma)
        {
            OpstaSistemskaOperacija operacija = new PretragaPesmeSO();
            operacija.IzvrsiSO(pesma);
            return operacija;
        }

        public OpstaSistemskaOperacija PronadjiPesmaAlbum(PesmeAlbuma pesmeAlbuma)
        {
            OpstaSistemskaOperacija operacija = new PronadjiPesmeAlbumaSO();
            operacija.IzvrsiSO(pesmeAlbuma);
            return operacija;
        }
        
        public OpstaSistemskaOperacija PronadjiPesmu(Pesma pesma)
        {
            OpstaSistemskaOperacija operacija = new PronadjiPesmuSO();
            operacija.IzvrsiSO(pesma);
            return operacija;
        }
        public OpstaSistemskaOperacija VratiListuPesama(Pesma pesma)
        {
            OpstaSistemskaOperacija operacija = new VratiListuPesamaSO();
            operacija.IzvrsiSO(pesma);
            return operacija;

        }
        public OpstaSistemskaOperacija ZapamtiPesmu(Pesma pesma)
        {
            OpstaSistemskaOperacija operacija = new ZapamtiPesmuSO();
            operacija.IzvrsiSO(pesma);
            return operacija;

        }
        public OpstaSistemskaOperacija KreirajAlbum(Album album)
        {
            OpstaSistemskaOperacija operacija = new KreirajAlbumSO();
            operacija.IzvrsiSO(album);
            return operacija;
        }
        public OpstaSistemskaOperacija ObrisiPesmeAlbum(PesmeAlbuma pesmeAlbuma)
        {
            OpstaSistemskaOperacija operacija = new ObrisiPesmeAlbumSO();
            operacija.IzvrsiSO(pesmeAlbuma);
            return operacija;
        }

        public OpstaSistemskaOperacija ObrisiAlbum(Album album)
        {
            OpstaSistemskaOperacija operacija = new ObrisiAlbumSO();
            operacija.IzvrsiSO(album);
            return operacija;
        }

        public OpstaSistemskaOperacija PretragaAlbuma(Album album)
        {
            OpstaSistemskaOperacija operacija = new PretragaAlbumaSO();
            operacija.IzvrsiSO(album);
            return operacija;
        }
        public OpstaSistemskaOperacija PronadjiAlbum(Album album)
        {
            OpstaSistemskaOperacija operacija = new PronadjiAlbumSO();
            operacija.IzvrsiSO(album);
            return operacija;
        }
        public OpstaSistemskaOperacija ZapamtiAlbum(Album album)
        {
            OpstaSistemskaOperacija operacija = new ZapamtiAlbumSO();
            operacija.IzvrsiSO(album);
            return operacija;
        }

        public OpstaSistemskaOperacija DodajPesmaAlbum(PesmeAlbuma pesmeAlbuma)
        {
            OpstaSistemskaOperacija operacija = new DodajPesmaAlbumSO();
            Console.WriteLine(pesmeAlbuma.Id);
            operacija.IzvrsiSO(pesmeAlbuma);
            return operacija;
        }

    }
}
