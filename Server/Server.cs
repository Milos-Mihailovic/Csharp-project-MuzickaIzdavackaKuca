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

namespace Server
{
    public class ServerMIK
    {
        Socket soket;
        public bool pokreniServer()
        {
            try
            {
                soket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IPEndPoint ep = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 12000);
                soket.Bind(ep);
                Thread nit = new Thread(osluskuj);
                nit.IsBackground = true;
                nit.Start();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
            
        }

        public bool zaustaviServer()
        {
            try
            {
                soket.Close();
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void osluskuj()
        {
            try
            { soket.Listen(8);
                while (true)
                {
                   
                    Socket klijent = soket.Accept();
                    NetworkStream tok = new NetworkStream(klijent);
                    ObradaKlijenta ok = new ObradaKlijenta(tok);
                    Thread nit = new Thread(ok.obradi);
                    nit.Start();
                    nit.IsBackground = true;
                }
            }
            catch (Exception)
            {

                
            }
        }
    }
}
