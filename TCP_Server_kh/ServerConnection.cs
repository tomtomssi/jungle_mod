using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;
using System.IO;
using System.Windows.Forms;

namespace TCP_Server_kh
{
    class ServerConnection
    {
        private Label connectionLabel;
        Socket s = null;
        private string receivedStr;
        TcpListener myList = null;

        private delegate void moveLabel(string text);

        public ServerConnection(Label connectionLabel)
        {
            this.connectionLabel = connectionLabel;

            try
            {
                IPAddress ipAd = IPAddress.Any;
                // use local m/c IP address, and 
                // use the same in the client

                /* Initializes the Listener */
                myList = new TcpListener(ipAd, 3567);

                updateLabel("Server open");
            }

            catch (Exception)
            {
                updateLabel("Disconnected");
            }
        }

        public void openConnection()
        {
            /* Start Listeneting at the specified port */
            updateLabel("Connection open");

            myList.Start();

            if (!myList.Pending())
            {
                updateLabel("Connection open");
            }

            else
            {
                s = myList.AcceptSocket();

                byte[] b = new byte[100];
                int k = s.Receive(b);
                for (int i = 0; i < k; i++)
                    receivedStr += Convert.ToChar(b[i]);

                updateLabel(receivedStr);
                /* clean up */
                s.Close();
                myList.Stop();
            }

        }

        public void closeConn()
        {
            updateLabel("Disconnected");
        }

        private void updateLabel(string text)
        {
            if (this.connectionLabel.InvokeRequired)
            {
                moveLabel m = new moveLabel(updateLabel);
                this.connectionLabel.Invoke(m, new object[] { text });
            }
            else
            {
                this.connectionLabel.Text = text;
            }
        }
    }
}
