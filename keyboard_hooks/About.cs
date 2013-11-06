using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace keyboard_hooks
{
    public partial class About : Form
    {
        public About()
        {
            this.Location = new Point(1200, 1500);
            InitializeComponent();
            this.Icon = keyboard_hooks.Properties.Resources.exe_icox;
            imageBox.Image = keyboard_hooks.Properties.Resources.about;
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void About_Load(object sender, EventArgs e)
        {
            this.CenterToParent();
        }
    }
}
