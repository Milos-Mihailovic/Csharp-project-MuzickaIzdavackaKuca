using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Domen;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using SistemskeOperacije;

namespace Server
{
    public class ObradaKlijenta
    {
        private NetworkStream tok;
        BinaryFormatter formater;

        public ObradaKlijenta(NetworkStream tok)
        {
            this.tok = tok;
            formater = new BinaryFormatter();
        }

        internal void obradi()
        {
            try
            {
                bool kraj = false;
                while (!kraj)
                {
                    TransferKlasa transfer = formater.Deserialize(tok) as TransferKlasa;
                    switch (transfer.operacija)
                    {
                        case Operacija.LOGIN:
                            OpstaSistemskaOperacija operacija = Kontroler.Instance.Login(transfer.TransferObjekat as GlavniUrednik);

                            TransferKlasa odgovor = new TransferKlasa
                            {
                                TransferObjekat = operacija.Rezultat,
                                Signal = operacija.Signal
                            };
                            formater.Serialize(tok, odgovor);
                            break;
                        case Operacija.KREIRAJ_ALBUM:
                            OpstaSistemskaOperacija kreirajAlbumSO = Kontroler.Instance.KreirajAlbum(transfer.TransferObjekat as Album);
                            try
                            {
                                transfer.Signal = kreirajAlbumSO.Signal;
                                transfer.Rezultat = kreirajAlbumSO.Rezultat;
                            }
                            catch (Exception)
                            {
                                transfer.Signal = false;
                            }
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacija.VRATI_ALBUM_ID:
                            OpstaSistemskaOperacija vratiAlbumIDSO = Kontroler.Instance.VratiAlbumID(transfer.TransferObjekat as Album);
                            try
                            {
                                transfer.Signal = vratiAlbumIDSO.Signal;
                                transfer.Rezultat = vratiAlbumIDSO.Rezultat;
                            }
                            catch (Exception)
                            {
                                transfer.Signal = false;
                            }
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacija.VRATI_PESMA_ALBUM_ID:
                            OpstaSistemskaOperacija vratiPesmaAlbumIDSO = Kontroler.Instance.VratiPesmaAlbumID(transfer.TransferObjekat as PesmeAlbuma);
                            try
                            {
                                transfer.Signal = vratiPesmaAlbumIDSO.Signal;
                                transfer.Rezultat = vratiPesmaAlbumIDSO.Rezultat;
                            }
                            catch (Exception)
                            {
                                transfer.Signal = false;
                            }
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacija.VRATI_ZANR_ID:
                            OpstaSistemskaOperacija vratiZanrIDSO = Kontroler.Instance.VratiZanrID(transfer.TransferObjekat as ZanrAlbuma);
                            try
                            {
                                transfer.Signal = vratiZanrIDSO.Signal;
                                transfer.Rezultat = vratiZanrIDSO.Rezultat;
                            }
                            catch (Exception)
                            {
                                transfer.Signal = false;
                            }
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacija.VRATI_PESMA_ID:
                            OpstaSistemskaOperacija vratiPesmaIDSO = Kontroler.Instance.VratiPesmaID(transfer.TransferObjekat as Pesma);
                            try
                            {
                                transfer.Signal = vratiPesmaIDSO.Signal;
                                transfer.Rezultat = vratiPesmaIDSO.Rezultat;
                            }
                            catch (Exception)
                            {
                                transfer.Signal = false;
                            }
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacija.VRATI_IZVODJAC_ID:
                            OpstaSistemskaOperacija vratiIZvodjacIDSO = Kontroler.Instance.VratiIzvodjacID(transfer.TransferObjekat as Izvodjac);
                            try
                            {
                                transfer.Signal = vratiIZvodjacIDSO.Signal;
                                transfer.Rezultat = vratiIZvodjacIDSO.Rezultat;
                            }
                            catch (Exception)
                            {
                                transfer.Signal = false;
                            }
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacija.OBRISI_PESME_ALBUM:
                            OpstaSistemskaOperacija ObrisiPesmeAlbumSO = Kontroler.Instance.ObrisiPesmeAlbum(transfer.TransferObjekat as PesmeAlbuma);
                            OpstaSistemskaOperacija ObrisiAlbumSO = Kontroler.Instance.ObrisiAlbum((transfer.TransferObjekat as PesmeAlbuma).Album);
                            try
                            {
                                transfer.Signal = ObrisiPesmeAlbumSO.Signal; 
                                transfer.Rezultat = ObrisiPesmeAlbumSO.Rezultat;
                               
                            }
                            catch (Exception)
                            {
                                transfer.Signal = false;
                            }
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacija.PRETRAGA_ALBUMA:
                            OpstaSistemskaOperacija pretragaAlbumaSO = Kontroler.Instance.PretragaAlbuma(transfer.TransferObjekat as Album);
                            try
                            {
                                transfer.Signal = pretragaAlbumaSO.Signal; 
                                transfer.Rezultat = pretragaAlbumaSO.Rezultat;
                            }
                            catch (Exception)
                            {
                                transfer.Signal = false;
                            }
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacija.PRETRAGA_PESME_ALBUMA:
                            OpstaSistemskaOperacija pretragaPesmeAlbumaSO = Kontroler.Instance.PretragaPesmeAlbuma(transfer.TransferObjekat as PesmeAlbuma);
                            try
                            {
                                transfer.Signal = pretragaPesmeAlbumaSO.Signal;
                                transfer.Rezultat = pretragaPesmeAlbumaSO.Rezultat;
                            }
                            catch (Exception)
                            {
                                transfer.Signal = false;
                            }
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacija.PRETRAGA_ZANRA:
                            OpstaSistemskaOperacija pretragaZanraSO = Kontroler.Instance.PretragaZanra(transfer.TransferObjekat as ZanrAlbuma);
                            try
                            {
                                transfer.Signal = pretragaZanraSO.Signal; 
                                transfer.Rezultat = pretragaZanraSO.Rezultat;
                            }
                            catch (Exception)
                            {
                                transfer.Signal = false;
                            }
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacija.PRETRAGA_IZVODJACA:
                            OpstaSistemskaOperacija pretragaIzvodjacaSO = Kontroler.Instance.PretragaIzvodjaca(transfer.TransferObjekat as Izvodjac);
                            try
                            {
                                transfer.Signal = pretragaIzvodjacaSO.Signal; 
                                transfer.Rezultat = pretragaIzvodjacaSO.Rezultat;
                            }
                            catch (Exception)
                            {
                                transfer.Signal = false;
                            }
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacija.PRETRAGA_PESME:
                            OpstaSistemskaOperacija pretragaPesmeSO = Kontroler.Instance.PretragaPesme(transfer.TransferObjekat as Pesma);
                            try
                            {
                                transfer.Signal = pretragaPesmeSO.Signal; 
                                transfer.Rezultat = pretragaPesmeSO.Rezultat;
                            }
                            catch (Exception)
                            {
                                transfer.Signal = false;
                            }
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacija.PRONADJI_ALBUM:
                            OpstaSistemskaOperacija pronadjiAlbumSO = Kontroler.Instance.PronadjiAlbum(transfer.TransferObjekat as Album);
                            try
                            {
                                transfer.Signal = pronadjiAlbumSO.Signal; 
                                transfer.Rezultat = pronadjiAlbumSO.Rezultat;
                            }
                            catch (Exception)
                            {
                                transfer.Signal = false;
                            }
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacija.PRONADJI_IZVODJACA:
                            OpstaSistemskaOperacija pronadjiIzvodjacaSO = Kontroler.Instance.PronadjiIzvodjaca(transfer.TransferObjekat as Izvodjac);

                            try
                            {
                                transfer.Signal = pronadjiIzvodjacaSO.Signal; 
                                transfer.Rezultat = pronadjiIzvodjacaSO.Rezultat;
                            }
                            catch (Exception)
                            {
                                transfer.Signal = false;
                            }
                            formater.Serialize(tok, transfer);
                            break;
                                case Operacija.PRONADJI_PESMU_ALBUMA:
                            OpstaSistemskaOperacija pronadjiPesmaAlbumSO = Kontroler.Instance.PronadjiPesmaAlbum(transfer.TransferObjekat as PesmeAlbuma);
                            try
                            {
                                transfer.Signal = pronadjiPesmaAlbumSO.Signal; 
                                transfer.Rezultat = pronadjiPesmaAlbumSO.Rezultat;
                            }
                            catch (Exception)
                            {
                                transfer.Signal = false;
                            }
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacija.PRONADJI_PESMU:
                            OpstaSistemskaOperacija pronadjiPesmuSO = Kontroler.Instance.PronadjiPesmu(transfer.TransferObjekat as Pesma);
                            try
                            {
                                transfer.Signal = pronadjiPesmuSO.Signal; 
                                transfer.Rezultat = pronadjiPesmuSO.Rezultat;
                            }
                            catch (Exception)
                            {
                                transfer.Signal = false;
                            }
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacija.VRATI_LISTU_ALBUMA:
                            OpstaSistemskaOperacija vratiListuAlbumaSO = Kontroler.Instance.VratiListuAlbuma(transfer.TransferObjekat as Album);
                            try
                            {
                                transfer.Signal = vratiListuAlbumaSO.Signal;
                                transfer.Rezultat = vratiListuAlbumaSO.Rezultat;
                            }
                            catch (Exception)
                            {
                                transfer.Signal = false;
                            }
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacija.VRATI_LISTU_ZANROVA:
                            OpstaSistemskaOperacija vratiListuZanrovaSO = Kontroler.Instance.VratiListuZanrova(transfer.TransferObjekat as ZanrAlbuma);
                            try
                            {
                                transfer.Signal = vratiListuZanrovaSO.Signal;
                                transfer.Rezultat = vratiListuZanrovaSO.Rezultat;
                            }
                            catch (Exception)
                            {
                                transfer.Signal = false;
                            }
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacija.VRATI_LISTU_IZVODJACA:
                            OpstaSistemskaOperacija vratiListuIzvodjacaSO = Kontroler.Instance.VratiListuIzvodjaca(transfer.TransferObjekat as Izvodjac);
                            try
                            {
                                transfer.Signal = vratiListuIzvodjacaSO.Signal; 
                                transfer.Rezultat = vratiListuIzvodjacaSO.Rezultat;
                            }
                            catch (Exception)
                            {
                                transfer.Signal = false;
                            }
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacija.VRATI_LISTU_PESAMA:
                            OpstaSistemskaOperacija vratiListuPesamaSO = Kontroler.Instance.VratiListuPesama(transfer.TransferObjekat as Pesma);
                            try
                            {
                                transfer.Signal = vratiListuPesamaSO.Signal; 
                                transfer.Rezultat = vratiListuPesamaSO.Rezultat;
                            }
                            catch (Exception)
                            {
                                transfer.Signal = false;
                            }
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacija.ZAPAMTI_ALBUM:
                            OpstaSistemskaOperacija zapamtiAlbumSO = Kontroler.Instance.ZapamtiAlbum(transfer.TransferObjekat as Album);
                            try
                            {
                                transfer.Signal = zapamtiAlbumSO.Signal; 
                                transfer.Rezultat = zapamtiAlbumSO.Rezultat;
                            }
                            catch (Exception)
                            {
                                transfer.Signal = false;
                            }
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacija.DODAJ_PESMA_ALBUM:
                            OpstaSistemskaOperacija dodajPesmaAlbumSO = Kontroler.Instance.DodajPesmaAlbum(transfer.TransferObjekat as PesmeAlbuma);
                            try
                            {
                                transfer.Signal = dodajPesmaAlbumSO.Signal; 
                                transfer.Rezultat = dodajPesmaAlbumSO.Rezultat;
                            }
                            catch (Exception)
                            {
                                transfer.Signal = false;
                            }
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacija.ZAPAMTI_ZANR:
                            OpstaSistemskaOperacija zapamtiZanrSO = Kontroler.Instance.ZapamtiZanr(transfer.TransferObjekat as ZanrAlbuma);
                            try
                            {
                                transfer.Signal = zapamtiZanrSO.Signal; 
                                transfer.Rezultat = zapamtiZanrSO.Rezultat;
                            }
                            catch (Exception)
                            {
                                transfer.Signal = false;
                            }
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacija.IZMENI_PESMU:
                            OpstaSistemskaOperacija IzmeniPesmuSO = Kontroler.Instance.IzmeniPesmu(transfer.TransferObjekat as Pesma);
                            try
                            {
                                transfer.Signal = IzmeniPesmuSO.Signal; 
                                transfer.Rezultat = IzmeniPesmuSO.Rezultat;
                            }
                            catch (Exception)
                            {
                                transfer.Signal = false;
                            }
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacija.IZMENI_IZVODJACA:
                            OpstaSistemskaOperacija IzmeniIzvodjacaSO = Kontroler.Instance.IzmeniIzvodjaca(transfer.TransferObjekat as Izvodjac);
                            try
                            {
                                transfer.Signal = IzmeniIzvodjacaSO.Signal; 
                                transfer.Rezultat = IzmeniIzvodjacaSO.Rezultat;
                            }
                            catch (Exception)
                            {
                                transfer.Signal = false;
                            }
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacija.ZAPAMTI_IZVODJACA:
                            OpstaSistemskaOperacija zapamtiIzvodjacaSO = Kontroler.Instance.ZapamtiIzvodjaca(transfer.TransferObjekat as Izvodjac);
                            try
                            {
                                transfer.Signal = zapamtiIzvodjacaSO.Signal; 
                                transfer.Rezultat = zapamtiIzvodjacaSO.Rezultat;
                            }
                            catch (Exception)
                            {
                                transfer.Signal = false;
                            }
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacija.ZAPAMTI_PESMU:
                            OpstaSistemskaOperacija zapamtiPesmuSO = Kontroler.Instance.ZapamtiPesmu(transfer.TransferObjekat as Pesma);
                            try
                            {
                                transfer.Signal = zapamtiPesmuSO.Signal; 
                                transfer.Rezultat = zapamtiPesmuSO.Rezultat;
                            }
                            catch (Exception)
                            {
                                transfer.Signal = false;
                            }
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacija.KRAJ: kraj = true;
                            break;
                        default:
                            break;
                    }
                }
            }
            catch (Exception e)
            {
                
                
            }
        }
    }
}
