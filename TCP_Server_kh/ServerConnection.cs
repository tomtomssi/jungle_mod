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
        TcpListener myList = null;
        Label[] timerLabels;
        bool isRunning = true;

        private delegate void moveLabel(string text);
        private delegate void updateTimerLabel(int keyId, string text);

        public ServerConnection(Label connectionLabel, Label[] timerLabels)
        {
            
            this.connectionLabel = connectionLabel;
            this.timerLabels = timerLabels;

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


            while (isRunning)
            {
                myList.Start();

                if (!myList.Pending())
                {

                }

                else
                {
                    s = myList.AcceptSocket();

                    byte[] b = new byte[100];
                    int k = s.Receive(b);
                    int keyId = BitConverter.ToInt16(b, 0) - 1;

                    selectTimerLabel(keyId);
                    /* clean up */
                    s.Close();
                    myList.Stop();
                } 
            }

        }

        //Does nothing except change the label atm
        public void closeConn()
        {
            isRunning = false;
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

        private void updateTimerDelegate(int keyId, string text)
        {
            if (this.timerLabels[keyId].InvokeRequired)
            {
                updateTimerLabel m = new updateTimerLabel(updateTimerDelegate);
                this.timerLabels[keyId].Invoke(m, new object[] { keyId });
            }
            else
            {
                this.timerLabels[keyId].Text = text;
            }
        }

        private void selectTimerLabel(int keyId)
        {
            switch (keyId)
            {
                case 0:
                    ServerForm.ourRed();
                    break;
                case 1:
                    ServerForm.ourBlue();
                    break;
                case 2:
                    ServerForm.theirRed();
                    break;
                case 3:
                    ServerForm.theirBlue();
                    break;
                case 4:
                    ServerForm.drake();
                    break;
                case 5:
                    ServerForm.baron();
                    break;
                default:
                    break;
            }
        }

        

    }
}
