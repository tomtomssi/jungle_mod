namespace TCP_Server_kh
{
    partial class ServerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeConnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.IPbox = new System.Windows.Forms.Label();
            this.connectButton = new System.Windows.Forms.Button();
            this.connectionLabel = new System.Windows.Forms.Label();
            this.asd = new System.Windows.Forms.Label();
            this.darkeabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.obLabel = new System.Windows.Forms.Label();
            this.BaronT = new System.Windows.Forms.Label();
            this.DrakeT = new System.Windows.Forms.Label();
            this.TheirRedT = new System.Windows.Forms.Label();
            this.TheirBlueT = new System.Windows.Forms.Label();
            this.OurRedT = new System.Windows.Forms.Label();
            this.OurBlueT = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeConnToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // closeConnToolStripMenuItem
            // 
            this.closeConnToolStripMenuItem.Name = "closeConnToolStripMenuItem";
            this.closeConnToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.closeConnToolStripMenuItem.Text = "Close conn";
            this.closeConnToolStripMenuItem.Click += new System.EventHandler(this.closeConnToolStripMenuItem_Click);
            // 
            // IPbox
            // 
            this.IPbox.AutoSize = true;
            this.IPbox.Location = new System.Drawing.Point(88, 346);
            this.IPbox.Name = "IPbox";
            this.IPbox.Size = new System.Drawing.Size(96, 13);
            this.IPbox.TabIndex = 1;
            this.IPbox.Text = "IP Address: not set";
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(97, 320);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(75, 23);
            this.connectButton.TabIndex = 2;
            this.connectButton.Text = "Start Server";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // connectionLabel
            // 
            this.connectionLabel.AutoSize = true;
            this.connectionLabel.Location = new System.Drawing.Point(99, 33);
            this.connectionLabel.Name = "connectionLabel";
            this.connectionLabel.Size = new System.Drawing.Size(73, 13);
            this.connectionLabel.TabIndex = 3;
            this.connectionLabel.Text = "Disconnected";
            // 
            // asd
            // 
            this.asd.AutoSize = true;
            this.asd.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.asd.ForeColor = System.Drawing.Color.DarkMagenta;
            this.asd.Location = new System.Drawing.Point(31, 266);
            this.asd.Name = "asd";
            this.asd.Size = new System.Drawing.Size(68, 18);
            this.asd.TabIndex = 23;
            this.asd.Text = "Baron:";
            // 
            // darkeabel
            // 
            this.darkeabel.AutoSize = true;
            this.darkeabel.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.darkeabel.ForeColor = System.Drawing.Color.LightSalmon;
            this.darkeabel.Location = new System.Drawing.Point(32, 228);
            this.darkeabel.Name = "darkeabel";
            this.darkeabel.Size = new System.Drawing.Size(68, 18);
            this.darkeabel.TabIndex = 22;
            this.darkeabel.Text = "Drake:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(32, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 18);
            this.label5.TabIndex = 21;
            this.label5.Text = "Their Red:";
            // 
            // tbLabel
            // 
            this.tbLabel.AutoSize = true;
            this.tbLabel.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLabel.ForeColor = System.Drawing.Color.Cyan;
            this.tbLabel.Location = new System.Drawing.Point(32, 147);
            this.tbLabel.Name = "tbLabel";
            this.tbLabel.Size = new System.Drawing.Size(118, 18);
            this.tbLabel.TabIndex = 20;
            this.tbLabel.Text = "Their Blue:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(31, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 18);
            this.label3.TabIndex = 19;
            this.label3.Text = "Our Red:";
            // 
            // obLabel
            // 
            this.obLabel.AutoSize = true;
            this.obLabel.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.obLabel.ForeColor = System.Drawing.Color.Cyan;
            this.obLabel.Location = new System.Drawing.Point(31, 72);
            this.obLabel.Name = "obLabel";
            this.obLabel.Size = new System.Drawing.Size(98, 18);
            this.obLabel.TabIndex = 18;
            this.obLabel.Text = "Our Blue:";
            // 
            // BaronT
            // 
            this.BaronT.AutoSize = true;
            this.BaronT.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BaronT.ForeColor = System.Drawing.Color.Lime;
            this.BaronT.Location = new System.Drawing.Point(185, 262);
            this.BaronT.Name = "BaronT";
            this.BaronT.Size = new System.Drawing.Size(0, 20);
            this.BaronT.TabIndex = 29;
            // 
            // DrakeT
            // 
            this.DrakeT.AutoSize = true;
            this.DrakeT.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DrakeT.ForeColor = System.Drawing.Color.Lime;
            this.DrakeT.Location = new System.Drawing.Point(185, 224);
            this.DrakeT.Name = "DrakeT";
            this.DrakeT.Size = new System.Drawing.Size(0, 20);
            this.DrakeT.TabIndex = 28;
            // 
            // TheirRedT
            // 
            this.TheirRedT.AutoSize = true;
            this.TheirRedT.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TheirRedT.ForeColor = System.Drawing.Color.Lime;
            this.TheirRedT.Location = new System.Drawing.Point(185, 185);
            this.TheirRedT.Name = "TheirRedT";
            this.TheirRedT.Size = new System.Drawing.Size(0, 20);
            this.TheirRedT.TabIndex = 27;
            // 
            // TheirBlueT
            // 
            this.TheirBlueT.AutoSize = true;
            this.TheirBlueT.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TheirBlueT.ForeColor = System.Drawing.Color.Lime;
            this.TheirBlueT.Location = new System.Drawing.Point(185, 143);
            this.TheirBlueT.Name = "TheirBlueT";
            this.TheirBlueT.Size = new System.Drawing.Size(0, 20);
            this.TheirBlueT.TabIndex = 26;
            // 
            // OurRedT
            // 
            this.OurRedT.AutoSize = true;
            this.OurRedT.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OurRedT.ForeColor = System.Drawing.Color.Lime;
            this.OurRedT.Location = new System.Drawing.Point(185, 107);
            this.OurRedT.Name = "OurRedT";
            this.OurRedT.Size = new System.Drawing.Size(0, 20);
            this.OurRedT.TabIndex = 25;
            // 
            // OurBlueT
            // 
            this.OurBlueT.AutoSize = true;
            this.OurBlueT.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OurBlueT.ForeColor = System.Drawing.Color.Lime;
            this.OurBlueT.Location = new System.Drawing.Point(185, 68);
            this.OurBlueT.Name = "OurBlueT";
            this.OurBlueT.Size = new System.Drawing.Size(0, 20);
            this.OurBlueT.TabIndex = 24;
            // 
            // ServerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(284, 368);
            this.Controls.Add(this.BaronT);
            this.Controls.Add(this.DrakeT);
            this.Controls.Add(this.TheirRedT);
            this.Controls.Add(this.TheirBlueT);
            this.Controls.Add(this.OurRedT);
            this.Controls.Add(this.OurBlueT);
            this.Controls.Add(this.asd);
            this.Controls.Add(this.darkeabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.obLabel);
            this.Controls.Add(this.connectionLabel);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.IPbox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(300, 406);
            this.MinimumSize = new System.Drawing.Size(300, 406);
            this.Name = "ServerForm";
            this.Text = "Server";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ServerForm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.Label IPbox;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Label connectionLabel;
        private System.Windows.Forms.ToolStripMenuItem closeConnToolStripMenuItem;
        private System.Windows.Forms.Label asd;
        private System.Windows.Forms.Label darkeabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label tbLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label obLabel;
        private System.Windows.Forms.Label BaronT;
        private System.Windows.Forms.Label DrakeT;
        private System.Windows.Forms.Label TheirRedT;
        private System.Windows.Forms.Label TheirBlueT;
        private System.Windows.Forms.Label OurRedT;
        private System.Windows.Forms.Label OurBlueT;
    }
}

