using System.Windows.Forms;

namespace CBW
{
    partial class autoLauncher
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
            this.lblCBW = new System.Windows.Forms.Label();
            this.chkCBW = new System.Windows.Forms.CheckBox();
            this.lblShowMenuStrip = new System.Windows.Forms.Label();
            this.chkShowMenuStrip = new System.Windows.Forms.CheckBox();
            this.buttonLaunchCemu = new System.Windows.Forms.Button();
            this.buttonCloseCemu = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonSwitchScreens = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCBW
            // 
            this.lblCBW.AutoSize = true;
            this.lblCBW.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCBW.Location = new System.Drawing.Point(7, 9);
            this.lblCBW.Name = "lblCBW";
            this.lblCBW.Size = new System.Drawing.Size(128, 16);
            this.lblCBW.TabIndex = 0;
            this.lblCBW.Text = "Borderless Window:";
            // 
            // chkCBW
            // 
            this.chkCBW.AutoSize = true;
            this.chkCBW.Location = new System.Drawing.Point(179, 11);
            this.chkCBW.Name = "chkCBW";
            this.chkCBW.Size = new System.Drawing.Size(15, 14);
            this.chkCBW.TabIndex = 1;
            this.chkCBW.UseVisualStyleBackColor = true;
            this.chkCBW.CheckedChanged += new System.EventHandler(this.chkCBW_CheckedChanged);
            // 
            // lblShowMenuStrip
            // 
            this.lblShowMenuStrip.AutoSize = true;
            this.lblShowMenuStrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowMenuStrip.Location = new System.Drawing.Point(7, 33);
            this.lblShowMenuStrip.Name = "lblShowMenuStrip";
            this.lblShowMenuStrip.Size = new System.Drawing.Size(110, 16);
            this.lblShowMenuStrip.TabIndex = 2;
            this.lblShowMenuStrip.Text = "Show Menu Strip:";
            // 
            // chkShowMenuStrip
            // 
            this.chkShowMenuStrip.AutoSize = true;
            this.chkShowMenuStrip.Location = new System.Drawing.Point(179, 35);
            this.chkShowMenuStrip.Name = "chkShowMenuStrip";
            this.chkShowMenuStrip.Size = new System.Drawing.Size(15, 14);
            this.chkShowMenuStrip.TabIndex = 3;
            this.chkShowMenuStrip.AutoCheck = false;
            this.chkShowMenuStrip.Enabled = false;
            this.chkShowMenuStrip.UseVisualStyleBackColor = true;
            this.chkShowMenuStrip.CheckedChanged += new System.EventHandler(this.chkShowMenuStrip_CheckedChanged);
            // 
            // buttonLaunchCemu
            // 
            this.buttonLaunchCemu.AutoSize = true;
            this.buttonLaunchCemu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLaunchCemu.Location = new System.Drawing.Point(7, 55);
            this.buttonLaunchCemu.Name = "buttonLaunchCemu";
            this.buttonLaunchCemu.Size = new System.Drawing.Size(187, 26);
            this.buttonLaunchCemu.TabIndex = 4;
            this.buttonLaunchCemu.Text = "Launch Cemu";
            this.buttonLaunchCemu.Click += new System.EventHandler(this.buttonLaunchCemu_Click);
            // 
            // buttonCloseCemu
            // 
            this.buttonCloseCemu.AutoSize = true;
            this.buttonCloseCemu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCloseCemu.Location = new System.Drawing.Point(7, 118);
            this.buttonCloseCemu.Name = "buttonCloseCemu";
            this.buttonCloseCemu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonCloseCemu.Size = new System.Drawing.Size(187, 26);
            this.buttonCloseCemu.TabIndex = 5;
            this.buttonCloseCemu.Text = "Close Cemu";
            this.buttonCloseCemu.Click += new System.EventHandler(this.buttonCloseCemu_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.AutoSize = true;
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(7, 150);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(187, 26);
            this.buttonExit.TabIndex = 6;
            this.buttonExit.Text = "Exit";
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonSwitchScreens
            // 
            this.buttonSwitchScreens.AutoSize = true;
            this.buttonSwitchScreens.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSwitchScreens.Location = new System.Drawing.Point(7, 86);
            this.buttonSwitchScreens.Name = "buttonSwitchScreens";
            this.buttonSwitchScreens.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonSwitchScreens.Size = new System.Drawing.Size(187, 26);
            this.buttonSwitchScreens.TabIndex = 7;
            this.buttonSwitchScreens.Text = "Switch Screens";
            this.buttonSwitchScreens.Click += new System.EventHandler(this.buttonSwitchScreens_Click);
            // 
            // autoLauncher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(201, 184);
            this.Controls.Add(this.buttonSwitchScreens);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.chkShowMenuStrip);
            this.Controls.Add(this.lblShowMenuStrip);
            this.Controls.Add(this.chkCBW);
            this.Controls.Add(this.lblCBW);
            this.Controls.Add(this.buttonLaunchCemu);
            this.Controls.Add(this.buttonCloseCemu);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "autoLauncher";
            this.Text = "Cemu Borderless Window Mode";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCBW;
        private System.Windows.Forms.CheckBox chkCBW;
        private System.Windows.Forms.Label lblShowMenuStrip;
        private System.Windows.Forms.CheckBox chkShowMenuStrip;
        private System.Windows.Forms.Button buttonLaunchCemu;
        private System.Windows.Forms.Button buttonCloseCemu;
        private System.Windows.Forms.Button buttonExit;
        private Button buttonSwitchScreens;
    }
}

