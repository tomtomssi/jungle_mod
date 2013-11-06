namespace keyboard_hooks
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.hook = new System.Windows.Forms.Button();
            this.unhook = new System.Windows.Forms.Button();
            this.obLabel = new System.Windows.Forms.Label();
            this.aTimer = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.tbLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TheirRedT = new System.Windows.Forms.Label();
            this.TheirBlueT = new System.Windows.Forms.Label();
            this.OurRedT = new System.Windows.Forms.Label();
            this.ourBlueT = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BaronT = new System.Windows.Forms.Label();
            this.DrakeT = new System.Windows.Forms.Label();
            this.asd = new System.Windows.Forms.Label();
            this.darkeabel = new System.Windows.Forms.Label();
            this.isRunning = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // hook
            // 
            this.hook.Location = new System.Drawing.Point(37, 296);
            this.hook.Name = "hook";
            this.hook.Size = new System.Drawing.Size(75, 23);
            this.hook.TabIndex = 1;
            this.hook.Text = "Hook";
            this.hook.UseVisualStyleBackColor = true;
            this.hook.Click += new System.EventHandler(this.hook_Click);
            // 
            // unhook
            // 
            this.unhook.Location = new System.Drawing.Point(156, 296);
            this.unhook.Name = "unhook";
            this.unhook.Size = new System.Drawing.Size(75, 23);
            this.unhook.TabIndex = 2;
            this.unhook.Text = "Unhook";
            this.unhook.UseVisualStyleBackColor = true;
            this.unhook.Click += new System.EventHandler(this.unhook_Click);
            // 
            // obLabel
            // 
            this.obLabel.AutoSize = true;
            this.obLabel.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.obLabel.ForeColor = System.Drawing.Color.Cyan;
            this.obLabel.Location = new System.Drawing.Point(33, 55);
            this.obLabel.Name = "obLabel";
            this.obLabel.Size = new System.Drawing.Size(98, 18);
            this.obLabel.TabIndex = 4;
            this.obLabel.Text = "Our Blue:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(33, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Our Red:";
            // 
            // tbLabel
            // 
            this.tbLabel.AutoSize = true;
            this.tbLabel.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLabel.ForeColor = System.Drawing.Color.Cyan;
            this.tbLabel.Location = new System.Drawing.Point(34, 130);
            this.tbLabel.Name = "tbLabel";
            this.tbLabel.Size = new System.Drawing.Size(118, 18);
            this.tbLabel.TabIndex = 9;
            this.tbLabel.Text = "Their Blue:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(34, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Their Red:";
            // 
            // TheirRedT
            // 
            this.TheirRedT.AutoSize = true;
            this.TheirRedT.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TheirRedT.ForeColor = System.Drawing.Color.Lime;
            this.TheirRedT.Location = new System.Drawing.Point(179, 170);
            this.TheirRedT.Name = "TheirRedT";
            this.TheirRedT.Size = new System.Drawing.Size(0, 20);
            this.TheirRedT.TabIndex = 14;
            // 
            // TheirBlueT
            // 
            this.TheirBlueT.AutoSize = true;
            this.TheirBlueT.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TheirBlueT.ForeColor = System.Drawing.Color.Lime;
            this.TheirBlueT.Location = new System.Drawing.Point(179, 128);
            this.TheirBlueT.Name = "TheirBlueT";
            this.TheirBlueT.Size = new System.Drawing.Size(0, 20);
            this.TheirBlueT.TabIndex = 13;
            // 
            // OurRedT
            // 
            this.OurRedT.AutoSize = true;
            this.OurRedT.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OurRedT.ForeColor = System.Drawing.Color.Lime;
            this.OurRedT.Location = new System.Drawing.Point(179, 92);
            this.OurRedT.Name = "OurRedT";
            this.OurRedT.Size = new System.Drawing.Size(0, 20);
            this.OurRedT.TabIndex = 12;
            // 
            // ourBlueT
            // 
            this.ourBlueT.AutoSize = true;
            this.ourBlueT.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ourBlueT.ForeColor = System.Drawing.Color.Lime;
            this.ourBlueT.Location = new System.Drawing.Point(179, 53);
            this.ourBlueT.Name = "ourBlueT";
            this.ourBlueT.Size = new System.Drawing.Size(0, 20);
            this.ourBlueT.TabIndex = 11;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Gray;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.aboutToolStripMenuItem.Text = "About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.exitToolStripMenuItem.Text = "Exit...";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // BaronT
            // 
            this.BaronT.AutoSize = true;
            this.BaronT.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BaronT.ForeColor = System.Drawing.Color.Lime;
            this.BaronT.Location = new System.Drawing.Point(179, 247);
            this.BaronT.Name = "BaronT";
            this.BaronT.Size = new System.Drawing.Size(0, 20);
            this.BaronT.TabIndex = 19;
            // 
            // DrakeT
            // 
            this.DrakeT.AutoSize = true;
            this.DrakeT.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DrakeT.ForeColor = System.Drawing.Color.Lime;
            this.DrakeT.Location = new System.Drawing.Point(179, 209);
            this.DrakeT.Name = "DrakeT";
            this.DrakeT.Size = new System.Drawing.Size(0, 20);
            this.DrakeT.TabIndex = 18;
            // 
            // asd
            // 
            this.asd.AutoSize = true;
            this.asd.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.asd.ForeColor = System.Drawing.Color.DarkMagenta;
            this.asd.Location = new System.Drawing.Point(33, 249);
            this.asd.Name = "asd";
            this.asd.Size = new System.Drawing.Size(68, 18);
            this.asd.TabIndex = 17;
            this.asd.Text = "Baron:";
            // 
            // darkeabel
            // 
            this.darkeabel.AutoSize = true;
            this.darkeabel.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.darkeabel.ForeColor = System.Drawing.Color.LightSalmon;
            this.darkeabel.Location = new System.Drawing.Point(34, 211);
            this.darkeabel.Name = "darkeabel";
            this.darkeabel.Size = new System.Drawing.Size(68, 18);
            this.darkeabel.TabIndex = 16;
            this.darkeabel.Text = "Drake:";
            // 
            // isRunning
            // 
            this.isRunning.AutoSize = true;
            this.isRunning.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.isRunning.Location = new System.Drawing.Point(107, 338);
            this.isRunning.Name = "isRunning";
            this.isRunning.Size = new System.Drawing.Size(56, 13);
            this.isRunning.TabIndex = 20;
            this.isRunning.Text = "Stopped...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(284, 368);
            this.Controls.Add(this.isRunning);
            this.Controls.Add(this.BaronT);
            this.Controls.Add(this.DrakeT);
            this.Controls.Add(this.asd);
            this.Controls.Add(this.darkeabel);
            this.Controls.Add(this.TheirRedT);
            this.Controls.Add(this.TheirBlueT);
            this.Controls.Add(this.OurRedT);
            this.Controls.Add(this.ourBlueT);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.obLabel);
            this.Controls.Add(this.unhook);
            this.Controls.Add(this.hook);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(300, 406);
            this.MinimumSize = new System.Drawing.Size(300, 406);
            this.Name = "Form1";
            this.Text = "Objective Timers";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button hook;
        private System.Windows.Forms.Button unhook;
        private System.Windows.Forms.Label obLabel;
        private System.Windows.Forms.Timer aTimer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label tbLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label TheirRedT;
        private System.Windows.Forms.Label TheirBlueT;
        private System.Windows.Forms.Label OurRedT;
        private System.Windows.Forms.Label ourBlueT;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label BaronT;
        private System.Windows.Forms.Label DrakeT;
        private System.Windows.Forms.Label asd;
        private System.Windows.Forms.Label darkeabel;
        private System.Windows.Forms.Label isRunning;
    }
}

