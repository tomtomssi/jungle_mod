using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCP_Server_kh
{
    public partial class ServerForm : Form
    {
        Thread t = null;
        bool isServerRunning = false;
        Label[] timerLabels;

        ServerConnection srv = null;

        public ServerForm()
        {
            InitializeComponent();
            timerLabels = new Label[6]{ourBlueT, OurRedT, TheirBlueT, TheirRedT, DrakeT, BaronT};
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            isServerRunning = true;
            t = new Thread(new ThreadStart(TCPProcedure));
            t.Start();
        }

        //Loops the TCP connection thread while the server is open
        private void TCPProcedure()
        {
            srv = new ServerConnection(connectionLabel, timerLabels);

            while (isServerRunning)
            {
                srv.openConnection();
                Thread.Sleep(100);
            }
        }

        //Abort thread on form close
        private void ServerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            isServerRunning = false;
        }

        private void closeConnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isServerRunning = false;
            srv.closeConn();
            if (t != null)
            {
                t.Abort();
            }
        }
    }
}
