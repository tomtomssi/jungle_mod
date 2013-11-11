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
        private string IP;
        int keyId;

        public ClientTCP(string IP)
        {
            this.IP = IP;
        }

        public void setKeyNum(int id)
        {
            this.keyId = id;
        }

        public void sendData(int data)
        {
            try
            {
                TcpClient tcpclnt = new TcpClient();

                tcpclnt.Connect(this.IP, 3567);
                // use the ipaddress as in the server program
                Stream stream = tcpclnt.GetStream();
                

                byte[] sendByte = BitConverter.GetBytes(data);

                stream.Write(sendByte, 0, sendByte.Length);

                tcpclnt.Close();
            }

            catch (Exception e)
            {

            }
        }
    }
}
