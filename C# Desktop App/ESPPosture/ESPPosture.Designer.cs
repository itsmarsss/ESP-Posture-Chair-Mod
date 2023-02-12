﻿namespace ESPPosture
{
    partial class Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.portBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.logs = new System.Windows.Forms.ListBox();
            this.updateBtn = new System.Windows.Forms.Button();
            this.notifyTop = new System.Windows.Forms.NotifyIcon(this.components);
            this.notifySleep = new System.Windows.Forms.NotifyIcon(this.components);
            this.notifyTest = new System.Windows.Forms.NotifyIcon(this.components);
            this.notifyBack = new System.Windows.Forms.NotifyIcon(this.components);
            this.notifyMove = new System.Windows.Forms.NotifyIcon(this.components);
            this.notifyBoth = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // portBox
            // 
            this.portBox.Location = new System.Drawing.Point(87, 9);
            this.portBox.Name = "portBox";
            this.portBox.Size = new System.Drawing.Size(187, 43);
            this.portBox.TabIndex = 3;
            this.portBox.Text = "8080";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "Port:";
            // 
            // logs
            // 
            this.logs.FormattingEnabled = true;
            this.logs.ItemHeight = 37;
            this.logs.Location = new System.Drawing.Point(12, 58);
            this.logs.Name = "logs";
            this.logs.Size = new System.Drawing.Size(776, 374);
            this.logs.TabIndex = 4;
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(292, 9);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(168, 43);
            this.updateBtn.TabIndex = 5;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // notifyTop
            // 
            this.notifyTop.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            this.notifyTop.BalloonTipText = "Alert: Neck";
            this.notifyTop.BalloonTipTitle = "ESP Posture Chair";
            this.notifyTop.Text = "ESPPostureChair";
            // 
            // notifySleep
            // 
            this.notifySleep.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifySleep.BalloonTipText = "ESP has gone to sleep...";
            this.notifySleep.BalloonTipTitle = "ESP Posture Chair";
            this.notifySleep.Text = "ESP Posture Chair";
            // 
            // notifyTest
            // 
            this.notifyTest.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyTest.BalloonTipText = "ESP has sent a test message...";
            this.notifyTest.BalloonTipTitle = "ESP Posture Chair";
            this.notifyTest.Text = "ESP Posture Chair";
            // 
            // notifyBack
            // 
            this.notifyBack.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            this.notifyBack.BalloonTipText = "Alert: Back";
            this.notifyBack.BalloonTipTitle = "ESP Posture Chair";
            this.notifyBack.Text = "ESP Posture Chair";
            // 
            // notifyMove
            // 
            this.notifyMove.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyMove.BalloonTipText = "Move detected...";
            this.notifyMove.BalloonTipTitle = "ESP Posture Chair";
            this.notifyMove.Text = "ESP Posture Chair";
            // 
            // notifyBoth
            // 
            this.notifyBoth.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            this.notifyBoth.BalloonTipText = "Alert: Neck and Back";
            this.notifyBoth.BalloonTipTitle = "ESP Posture Chair";
            this.notifyBoth.Text = "ESP Posture Chair";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.logs);
            this.Controls.Add(this.portBox);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form";
            this.Text = "ESPPostureLogs";
            this.Load += new System.EventHandler(this.Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox portBox;
        private Label label2;
        private ListBox logs;
        private Button updateBtn;
        private NotifyIcon notifyTop;
        private NotifyIcon notifySleep;
        private NotifyIcon notifyTest;
        private NotifyIcon notifyBack;
        private NotifyIcon notifyMove;
        private NotifyIcon notifyBoth;
    }
}