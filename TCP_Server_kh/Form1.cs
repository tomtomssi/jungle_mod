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
        #region Minutes, seconds and timers
        private System.Threading.Timer ob, tb, or, tr, drakeTimer, baronTimer = null;
        int obLizardMinutes, obLizardSeconds, orLizardMinutes, orLizardSeconds;
        int tbLizardMinutes, tbLizardSeconds, trLizardMinutes, trLizardSeconds;
        int drakeMinutes, drakeSeconds;
        int baronMinutes, baronSeconds;
        #endregion
        Thread t = null;
        Label[] timerLabels;
        private static ServerForm thisForm;
        ServerConnection srv = null;

        public ServerForm()
        {
            InitializeComponent();
            thisForm = this;
            timerLabels = new Label[6] { OurBlueT, OurRedT, TheirBlueT, TheirRedT, DrakeT, BaronT };
            thisForm.or = new System.Threading.Timer(new TimerCallback(orCallBack), null, Timeout.Infinite, Timeout.Infinite);
            thisForm.ob = new System.Threading.Timer(new TimerCallback(obCallBack), null, Timeout.Infinite, Timeout.Infinite);
            thisForm.tr = new System.Threading.Timer(new TimerCallback(trCallBack), null, Timeout.Infinite, Timeout.Infinite);
            thisForm.tb = new System.Threading.Timer(new TimerCallback(tbCallBack), null, Timeout.Infinite, Timeout.Infinite);
            thisForm.drakeTimer = new System.Threading.Timer(new TimerCallback(drakeCallBack), null, Timeout.Infinite, Timeout.Infinite);
            thisForm.baronTimer = new System.Threading.Timer(new TimerCallback(baronCallBack), null, Timeout.Infinite, Timeout.Infinite);

        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            t = new Thread(new ThreadStart(TCPProcedure));
            t.Start();
        }

        //Loops the TCP connection thread while the server is open
        private void TCPProcedure()
        {
            srv = new ServerConnection(connectionLabel, timerLabels);
            srv.openConnection();
            Thread.Sleep(100);
        }

        //Abort thread on form close
        private void ServerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            srv.closeConn();
        }

        private void closeConnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            srv.closeConn();
            if (t != null)
            {
                t.Abort();
            }
        }

        #region Timers
        public static void ourRed()
        {
            thisForm.orLizardMinutes = 5;
            thisForm.orLizardSeconds = 0;
            thisForm.or.Change(0, 1000);
        }
        public static void ourBlue()
        {
            thisForm.obLizardMinutes = 5;
            thisForm.obLizardSeconds = 0;
            thisForm.ob.Change(0, 1000);
        }
        public static void theirRed()
        {
            thisForm.trLizardMinutes = 5;
            thisForm.trLizardSeconds = 0;
            thisForm.tr.Change(0, 1000);
        }
        public static void theirBlue()
        {
            thisForm.tbLizardMinutes = 5;
            thisForm.tbLizardSeconds = 0;
            thisForm.tb.Change(0, 1000);
        }
        public static void drake()
        {
            thisForm.drakeMinutes = 5;
            thisForm.drakeSeconds = 0;
            thisForm.drakeTimer.Change(0, 1000);
        }
        public static void baron()
        {
            thisForm.baronMinutes = 5;
            thisForm.baronSeconds = 0;
            thisForm.baronTimer.Change(0, 1000);
        }
        #endregion

        #region onTick Methods
        static void orCallBack(Object s)
        {
            if (thisForm.orLizardMinutes == 0 && thisForm.orLizardSeconds == 0)
            {
                return;
            }

            if (thisForm.orLizardSeconds == 0 && thisForm.orLizardMinutes != 0)
            {
                --thisForm.orLizardMinutes;
                thisForm.orLizardSeconds = 60;
            }
            if (thisForm.orLizardSeconds != 0 && thisForm.orLizardMinutes == 0)
            {
                --thisForm.orLizardSeconds;
                int tmpInt = thisForm.orLizardSeconds;
                thisForm.OurRedT.Text = tmpInt.ToString();
            }
            else
            {
                --thisForm.orLizardSeconds;
                thisForm.OurRedT.Text = thisForm.orLizardMinutes + ":" + thisForm.orLizardSeconds;
            }
        }
        static void obCallBack(Object s)
        {
            if (thisForm.obLizardMinutes == 0 && thisForm.obLizardSeconds == 0)
            {
                return;
            }

            if (thisForm.obLizardSeconds == 0 && thisForm.obLizardMinutes != 0)
            {
                --thisForm.obLizardMinutes;
                thisForm.obLizardSeconds = 60;
            }
            if (thisForm.obLizardSeconds != 0 && thisForm.obLizardMinutes == 0)
            {
                --thisForm.obLizardSeconds;
                int tmpInt = thisForm.obLizardSeconds;
                thisForm.OurBlueT.Text = tmpInt.ToString();
            }
            else
            {
                --thisForm.obLizardSeconds;
                thisForm.OurBlueT.Text = thisForm.obLizardMinutes + ":" + thisForm.obLizardSeconds;
            }
        }
        static void trCallBack(Object s)
        {
            if (thisForm.trLizardMinutes == 0 && thisForm.trLizardSeconds == 0)
            {
                return;
            }

            if (thisForm.trLizardSeconds == 0 && thisForm.trLizardMinutes != 0)
            {
                --thisForm.trLizardMinutes;
                thisForm.trLizardSeconds = 60;
            }
            if (thisForm.trLizardSeconds != 0 && thisForm.trLizardMinutes == 0)
            {
                --thisForm.trLizardSeconds;
                int tmpInt = thisForm.trLizardSeconds;
                thisForm.TheirRedT.Text = tmpInt.ToString();
            }
            else
            {
                --thisForm.trLizardSeconds;
                thisForm.TheirRedT.Text = thisForm.trLizardMinutes + ":" + thisForm.trLizardSeconds;
            }
        }
        static void tbCallBack(Object s)
        {
            if (thisForm.tbLizardMinutes == 0 && thisForm.tbLizardSeconds == 0)
            {
                return;
            }

            if (thisForm.tbLizardSeconds == 0 && thisForm.tbLizardMinutes != 0)
            {
                --thisForm.tbLizardMinutes;
                thisForm.tbLizardSeconds = 60;
            }
            if (thisForm.tbLizardSeconds != 0 && thisForm.tbLizardMinutes == 0)
            {
                --thisForm.tbLizardSeconds;
                int tmpInt = thisForm.tbLizardSeconds;
                thisForm.TheirBlueT.Text = tmpInt.ToString();
            }
            else
            {
                --thisForm.tbLizardSeconds;
                thisForm.TheirBlueT.Text = thisForm.tbLizardMinutes + ":" + thisForm.tbLizardSeconds;
            }
        }
        static void drakeCallBack(Object s)
        {
            if (thisForm.drakeMinutes == 0 && thisForm.drakeSeconds == 0)
            {
                return;
            }

            if (thisForm.drakeSeconds == 0 && thisForm.drakeMinutes != 0)
            {
                --thisForm.drakeMinutes;
                thisForm.drakeSeconds = 60;
            }
            if (thisForm.drakeSeconds != 0 && thisForm.drakeMinutes == 0)
            {
                --thisForm.drakeSeconds;
                int tmpInt = thisForm.drakeSeconds;
                thisForm.DrakeT.Text = tmpInt.ToString();
            }
            else
            {
                --thisForm.drakeSeconds;
                thisForm.DrakeT.Text = thisForm.drakeMinutes + ":" + thisForm.drakeSeconds;
            }
        }
        static void baronCallBack(Object s)
        {
            if (thisForm.baronMinutes == 0 && thisForm.baronSeconds == 0)
            {
                return;
            }

            if (thisForm.baronSeconds == 0 && thisForm.baronMinutes != 0)
            {
                --thisForm.baronMinutes;
                thisForm.baronSeconds = 60;
            }
            if (thisForm.baronSeconds != 0 && thisForm.baronMinutes == 0)
            {
                --thisForm.baronSeconds;
                int tmpInt = thisForm.baronSeconds;
                thisForm.BaronT.Text = tmpInt.ToString();
            }
            else
            {
                --thisForm.baronSeconds;
                thisForm.BaronT.Text = thisForm.baronMinutes + ":" + thisForm.baronSeconds;
            }
        }
        #endregion
    }
}
