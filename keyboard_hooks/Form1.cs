using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Timers;
using System.Threading;
using System.Diagnostics;

namespace keyboard_hooks
{

    public partial class Form1 : Form
    {

        #region Initialize
        Color defaultTransparencyKey;
        Thread t = null;
        Thread sendData = null;
        //Arvolla katsotaan onko borderit formissa näkyvissä vai ei. Käytetään myös, kun liikutetaan hiirellä borderless formia
        bool isVisible = true;
        Point lastFormLocation;
        //string wav_loc = @"C:\Users\Tatu\Documents\Visual Studio 2012\Projects\keyboard_hooks\resoures\wav\";
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        private System.Windows.Forms.Timer ob, tb, or, tr, drakeTimer, baronTimer = null;
        int obLizardMinutes, obLizardSeconds, orLizardMinutes, orLizardSeconds;
        int tbLizardMinutes, tbLizardSeconds, trLizardMinutes, trLizardSeconds;
        int drakeMinutes, drakeSeconds;
        int baronMinutes, baronSeconds;
        string IP = null;
        private bool isHooked = false;
        #endregion

        public Form1()
        {
            this.Icon = keyboard_hooks.Properties.Resources.exe_icox;
            this.or = new System.Windows.Forms.Timer() { Interval = 1000 };
            this.ob = new System.Windows.Forms.Timer() { Interval = 1000 };
            this.tr = new System.Windows.Forms.Timer() { Interval = 1000 };
            this.tb = new System.Windows.Forms.Timer() { Interval = 1000 };
            this.drakeTimer = new System.Windows.Forms.Timer() { Interval = 1000 };
            this.baronTimer = new System.Windows.Forms.Timer() { Interval = 1000 };
            InitializeComponent();
        }

        GlobalKeyboardHook gHook;
        
        private void Form1_Load(object sender, EventArgs e)
        {
            this.CenterToParent();
            this.defaultTransparencyKey = this.TransparencyKey;
            gHook = new GlobalKeyboardHook();
            gHook.KeyDown += new KeyEventHandler(gHook_KeyDown);
            foreach (Keys key in Enum.GetValues(typeof(Keys)))
            {
                gHook.HookedKeys.Add(key);
            }
        }

        #region On KeyDown Methods
        public void gHook_KeyDown(object sender, KeyEventArgs e)
        {
            //Num7
            if (e.KeyValue == 36 && or.Enabled == false)
            {
                sendTimerToServer(1);
                ourRed();
            }
            else if (e.KeyValue == 36 && or.Enabled == true)
            {
                sendTimerToServer(1);
                orLizardMinutes = 5;
                orLizardSeconds = 0;
            }
            //Num8
            if (e.KeyValue == 38 && ob.Enabled == false)
            {
                sendTimerToServer(2);
                ourBlue();
            }
            else if (e.KeyValue == 38 && ob.Enabled == true)
            {
                sendTimerToServer(2);
                obLizardMinutes = 5;
                obLizardSeconds = 0;
            }
            //Num4
            if (e.KeyValue == 37 && tr.Enabled == false)
            {
                sendTimerToServer(3);
                theirRed();
            }
            else if (e.KeyValue == 37 && tr.Enabled == true)
            {
                sendTimerToServer(3);
                trLizardMinutes = 5;
                trLizardSeconds = 0;
            }
            //Num5
            if (e.KeyValue == 12 && tb.Enabled == false)
            {
                sendTimerToServer(4);
                theirBlue();
            }
            else if (e.KeyValue == 12 && tb.Enabled == true)
            {
                sendTimerToServer(4);
                tbLizardMinutes = 5;
                tbLizardSeconds = 0;
            }
            //Num6
            if (e.KeyValue == 40 && baronTimer.Enabled == false)
            {
                sendTimerToServer(6);
                baron();
            }
            else if (e.KeyValue == 40 && baronTimer.Enabled == true)
            {
                sendTimerToServer(6);
                baronMinutes = 7;
                baronSeconds = 0;
            }
            //Num9
            if (e.KeyValue == 35 && drakeTimer.Enabled == false)
            {
                sendTimerToServer(5);
                drake();
            }
            else if (e.KeyValue == 35 && drakeTimer.Enabled == true)
            {
                sendTimerToServer(5);
                drakeSeconds = 0;
                drakeMinutes = 6;
            }

            if (e.KeyValue == 45 && isVisible == true)
            {
                isVisible = false;
                visibilityModeTrue();
            }
            else if (e.KeyValue == 45 && isVisible == false)
            {
                isVisible = true;
                visibilityModeFalse();
            }
        }

        private void visibilityModeTrue()
        {
            this.TopMost = true;
            this.TransparencyKey = Color.DimGray;
            this.FormBorderStyle = FormBorderStyle.None;
            hook.Visible = false;
            unhook.Visible = false;
            this.menuStrip1.Visible = false;
            this.isRunning.Visible = false;
        }
        private void visibilityModeFalse()
        {
            this.TopMost = false;
            this.TransparencyKey = defaultTransparencyKey;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            obLabel.ForeColor = Color.Cyan;
            tbLabel.ForeColor = Color.Cyan;
            hook.Visible = true;
            unhook.Visible = true;
            this.menuStrip1.Visible = true;
            this.isRunning.Visible = true;
        }

        private void hook_Click(object sender, EventArgs e)
        {

            if (!isHooked)
            {
                isRunning.Text = "Running...";
                gHook.hook();
                isHooked = true;
            }
        }

        private void unhook_Click(object sender, EventArgs e)
        {
            isHooked = false;
            clearTimers();
            isRunning.Text = "Stopped...";
            gHook.unhook();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (t != null)
            {
                t.Abort();
            }
            gHook.unhook();
        }
        #endregion

        #region Timers
        private void ourRed()
        {
            orLizardMinutes = 5;
            orLizardSeconds = 0;
            or.Tick += new EventHandler(OrfiveMinTick);
            or.Start();
        }
        private void ourBlue()
        {
            obLizardMinutes = 5;
            obLizardSeconds = 0;
            ob.Tick += new EventHandler(ObfiveMinTick);
            ob.Start();
        }
        private void theirRed()
        {
            trLizardMinutes = 5;
            trLizardSeconds = 0;
            tr.Tick += new EventHandler(TrfiveMinTick);
            tr.Start();
        }
        private void theirBlue()
        {
            tbLizardMinutes = 5;
            tbLizardSeconds = 0;
            tb.Tick += new EventHandler(TbfiveMinTick);
            tb.Start();
        }
        private void drake()
        {
            drakeMinutes = 6;
            drakeSeconds = 0;
            drakeTimer.Tick += new EventHandler(drakeTick);
            drakeTimer.Start();
        }
        private void baron()
        {
            baronMinutes = 7;
            baronSeconds = 0;
            baronTimer.Tick += new EventHandler(baronTick);
            baronTimer.Start();
        }
        #endregion

        #region onTick Methods
        void ObfiveMinTick(object sender, EventArgs e)
        {
            changeColor(obLizardMinutes, obLizardSeconds, ourBlueT);
            if (obLizardMinutes == 0 && obLizardSeconds == 0)
            {
                //playSound(wav_loc + "ob.wav");
                ob.Stop();
                //Poistetaan event handler, jotta timerin mennessä 0, se ei luo vanhan vierelle toista
                ob.Tick -= new EventHandler(ObfiveMinTick);
                return;
            }

            if (obLizardSeconds == 0 && obLizardMinutes != 0)
            {
                --obLizardMinutes;
                obLizardSeconds = 60;
            }
            if (obLizardSeconds != 0 && obLizardMinutes == 0)
            {
                --obLizardSeconds;
                ourBlueT.Text = obLizardSeconds.ToString();
            }
            else
            {
                --obLizardSeconds;
                ourBlueT.Text = obLizardMinutes + ":" + obLizardSeconds;
            }


        }
        void OrfiveMinTick(object sender, EventArgs e)
        {
            changeColor(orLizardMinutes, orLizardSeconds, OurRedT);
            if (orLizardMinutes == 0 && orLizardSeconds == 0)
            {
                //playSound(wav_loc + "or.wav");
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
                OurRedT.Text = orLizardSeconds.ToString();
            }
            else
            {
                --orLizardSeconds;
                OurRedT.Text = orLizardMinutes + ":" + orLizardSeconds;
            }


        }
        void TrfiveMinTick(object sender, EventArgs e)
        {
            changeColor(trLizardMinutes, trLizardSeconds, TheirRedT);
            if (trLizardMinutes == 0 && trLizardSeconds == 0)
            {
                //playSound(wav_loc + "tr.wav");
                tr.Stop();
                tr.Tick -= new EventHandler(TrfiveMinTick);
                return;
            }

            if (trLizardSeconds == 0 && trLizardMinutes != 0)
            {
                --trLizardMinutes;
                trLizardSeconds = 60;
            }
            if (trLizardSeconds != 0 && trLizardMinutes == 0)
            {
                --trLizardSeconds;
                TheirRedT.Text = trLizardSeconds.ToString();
            }
            else
            {
                --trLizardSeconds;
                TheirRedT.Text = trLizardMinutes + ":" + trLizardSeconds;
            }


        }
        void TbfiveMinTick(object sender, EventArgs e)
        {
            changeColor(tbLizardMinutes, tbLizardSeconds, TheirBlueT);
            if (tbLizardMinutes == 0 && tbLizardSeconds == 0)
            {
               // playSound(wav_loc + "tb.wav");
                tb.Stop();
                tb.Tick -= new EventHandler(TbfiveMinTick);
                return;
            }

            if (tbLizardSeconds == 0 && tbLizardMinutes != 0)
            {
                --tbLizardMinutes;
                tbLizardSeconds = 60;
            }
            if (tbLizardSeconds != 0 && tbLizardMinutes == 0)
            {
                --tbLizardSeconds;
                TheirBlueT.Text = tbLizardSeconds.ToString();
            }
            else
            {
                --tbLizardSeconds;
                TheirBlueT.Text = tbLizardMinutes + ":" + tbLizardSeconds;
            }


        }
        void drakeTick(object sender, EventArgs e)
        {
            changeColor(drakeMinutes, drakeSeconds, DrakeT);

            if (drakeMinutes == 0 && drakeSeconds == 0)
            {
                drakeTimer.Stop();
                drakeTimer.Tick -= new EventHandler(drakeTick);
                return;
            }

            if (drakeSeconds == 0 && drakeMinutes != 0)
            {
                --drakeMinutes;
                drakeSeconds = 60;
            }
            if (drakeSeconds != 0 && drakeMinutes == 0)
            {
                --drakeSeconds;
                DrakeT.Text = drakeSeconds.ToString();
            }
            else
            {
                --drakeSeconds;
                DrakeT.Text = drakeMinutes + ":" + drakeSeconds;
            }

        }
        void baronTick(object sender, EventArgs e)
        {
            changeColor(baronMinutes, baronSeconds, BaronT);

            if (baronMinutes == 0 && baronSeconds == 0)
            {
                baronTimer.Stop();
                baronTimer.Tick -= new EventHandler(baronTick);
                return;
            }

            if (baronSeconds == 0 && baronMinutes != 0)
            {
                --baronMinutes;
                baronSeconds = 60;
            }
            if (baronSeconds != 0 && baronMinutes == 0)
            {
                --baronSeconds;
                BaronT.Text = baronSeconds.ToString();
            }
            else
            {
                --baronSeconds;
                BaronT.Text = baronMinutes + ":" + baronSeconds;
            }

        }
        #endregion

        //Poistaa event handlerit, jos niitä on timereillä ollut
        private void clearTimers()
        {
            if (ob.Enabled)
            {
                ob.Stop();
                ob.Tick -= new EventHandler(ObfiveMinTick);
                ourBlueT.Text = "";
            }
            if (or.Enabled)
            {
                or.Stop();
                or.Tick -= new EventHandler(OrfiveMinTick);
                OurRedT.Text = "";
            }
            if (tr.Enabled)
            {
                tr.Stop();
                tr.Tick -= new EventHandler(TrfiveMinTick);
                TheirRedT.Text = "";
            }
            if (tb.Enabled)
            {
                tb.Stop();
                tb.Tick -= new EventHandler(TbfiveMinTick);
                TheirBlueT.Text = "";
            }
            if (drakeTimer.Enabled)
            {
                drakeTimer.Stop();
                drakeTimer.Tick -= new EventHandler(drakeTick);
                DrakeT.Text = "";
            }
            if (baronTimer.Enabled)
            {
                baronTimer.Stop();
                baronTimer.Tick -= new EventHandler(baronTick);
                BaronT.Text = "";
            }
        }

        //Vaihtaa aika-labelin väriä oranssiksi @ 2min ja punaiseksi @ 0.45
        private void changeColor(int min, int s, Label l)
        {
            if (min > 2)
            {
                l.ForeColor = System.Drawing.Color.Lime;
            }
            if (min == 2 && s == 0)
            {
                l.ForeColor = System.Drawing.Color.OrangeRed;
            }
            if (min == 0 && s == 45)
            {
                l.ForeColor = System.Drawing.Color.Red;
            }
        }

        //Soittaa äänitiedoston, kun jokin timereistä on 0
        /*private void playSound(string loc)
        {
            player.SoundLocation = loc;
            player.Play();
        }*/

        #region start About Form
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            t = new Thread(new ThreadStart(aboutProc));
            t.Start();
        }
        private void aboutProc()
        {
            Application.Run(new About());
        }
        #endregion

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (t != null)
            {
                t.Abort();
            }
            Application.Exit();
        }

        //Mouse eventit formin liikuttamiseen
        #region Mouse Movements
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            lastFormLocation = e.Location;
        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastFormLocation.X;
                this.Top += e.Y - lastFormLocation.Y; 
            }
        }
        #endregion

        private void serverIPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowMyDialogBox();
        }

        public void ShowMyDialogBox()
        {
            EnterServerIP testDialog = new EnterServerIP();

            // Show testDialog as a modal dialog and determine if DialogResult = OK.
            if (testDialog.ShowDialog(this) == DialogResult.OK)
            {
                // Read the contents of testDialog's TextBox.
                menuIPbox.Text = testDialog.getIP();
                this.IP = testDialog.getIP();
            }

            else
            {
                menuIPbox.Text = "No IP set";
            }
            testDialog.Dispose();
        }

        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (IP != null)
            {
                sendData = new Thread(new ParameterizedThreadStart(sendDataProc));
                sendData.Start();
            }
        }

        private void sendDataProc(object keyId)
        {
            ClientTCP conn = new ClientTCP(IP);
            conn.sendData((int)keyId);
        }

        private void sendTimerToServer(int id)
        {
            if (IP != null)
            {
                sendData = new Thread(new ParameterizedThreadStart(sendDataProc));
                sendData.Start(id);
            }
        }
    }
}
