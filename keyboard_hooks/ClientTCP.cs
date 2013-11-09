using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.IO;

namespace keyboard_hooks
{
    class ClientTCP
    {
        public ClientTCP(string IP)
        {
            try
            {
                TcpClient tcpclnt = new TcpClient();

                tcpclnt.Connect(IP, 3567);
                // use the ipaddress as in the server program
                Stream stream = tcpclnt.GetStream();
                ASCIIEncoding asen = new ASCIIEncoding();

                byte[] sendByte = asen.GetBytes("OK");

                stream.Write(sendByte, 0, sendByte.Length);

                tcpclnt.Close();
            }

            catch (Exception e)
            {
                
            }
        }
    }
}
