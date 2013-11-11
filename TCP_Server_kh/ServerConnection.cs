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
        #region Minutes, seconds and timers
        private System.Windows.Forms.Timer ob, tb, or, tr, drakeTimer, baronTimer = null;
        int obLizardMinutes, obLizardSeconds, orLizardMinutes, orLizardSeconds;
        int tbLizardMinutes, tbLizardSeconds, trLizardMinutes, trLizardSeconds;
        int drakeMinutes, drakeSeconds;
        int baronMinutes, baronSeconds;

        #endregion
        private Label connectionLabel;
        Socket s = null;
        TcpListener myList = null;
        Label[] timerLabels;

        private delegate void moveLabel(string text);
        private delegate void updateTimerLabel(int keyId, string text);

        public ServerConnection(Label connectionLabel, Label[] timerLabels)
        {
            this.or = new System.Windows.Forms.Timer() { Interval = 1000 };
            this.ob = new System.Windows.Forms.Timer() { Interval = 1000 };
            this.tr = new System.Windows.Forms.Timer() { Interval = 1000 };
            this.tb = new System.Windows.Forms.Timer() { Interval = 1000 };
            this.drakeTimer = new System.Windows.Forms.Timer() { Interval = 1000 };
            this.baronTimer = new System.Windows.Forms.Timer() { Interval = 1000 };
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

        //Does nothing except change the label atm
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
                    ourRed();
                    break;
                default:
                    break;
            }
        }

        #region Timers
        private void ourRed()
        {
            orLizardMinutes = 5;
            orLizardSeconds = 0;
            or.Tick += new EventHandler(OrfiveMinTick);
            or.Start();
        }
        #endregion

        #region onTick Methods
        void OrfiveMinTick(object sender, EventArgs e)
        {
            if (orLizardMinutes == 0 && orLizardSeconds == 0)
            {
                or.Stop();
                or.Tick -= new EventHandler(OrfiveMinTick);
                return;
            }

            if (orLizardSeconds == 0 && orLizardMinutes != 0)
            {
                --orLizardMinutes;
                orLizardSeconds = 60;
            }
            if (orLizardSeconds != 0 && orLizardMinutes == 0)
            {
                --orLizardSeconds;
                updateTimerDelegate(0, orLizardSeconds.ToString());
            }
            else
            {
                --orLizardSeconds;
                updateTimerDelegate(0, orLizardMinutes + ":" + orLizardSeconds);
            }
        }

        #endregion

    }
}
