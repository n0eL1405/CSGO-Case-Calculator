using System;

namespace CSGO_Case_Calculator
{
    partial class Form_Options {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Options));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnChangeCurrency = new System.Windows.Forms.Button();
            this.lblChooseCurrency = new System.Windows.Forms.Label();
            this.lLblDonate = new System.Windows.Forms.LinkLabel();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lLblTwitter = new System.Windows.Forms.LinkLabel();
            this.grpBxCalcTimer = new System.Windows.Forms.GroupBox();
            this.btnHelpTimer = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblLimitation = new System.Windows.Forms.Label();
            this.rTxtBxTimerTime = new System.Windows.Forms.RichTextBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblMadeBy = new System.Windows.Forms.Label();
            this.btnImportOldXML = new System.Windows.Forms.Button();
            this.calcTimer = new System.Windows.Forms.Timer(this.components);
            this.cmbBxCurrency = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.grpBxCalcTimer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.cmbBxCurrency);
            this.panel1.Controls.Add(this.btnChangeCurrency);
            this.panel1.Controls.Add(this.lblChooseCurrency);
            this.panel1.Controls.Add(this.lLblDonate);
            this.panel1.Controls.Add(this.lblVersion);
            this.panel1.Controls.Add(this.lLblTwitter);
            this.panel1.Controls.Add(this.grpBxCalcTimer);
            this.panel1.Controls.Add(this.lblMadeBy);
            this.panel1.Controls.Add(this.btnImportOldXML);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(740, 424);
            this.panel1.TabIndex = 0;
            // 
            // btnChangeCurrency
            // 
            this.btnChangeCurrency.BackColor = System.Drawing.Color.Gray;
            this.btnChangeCurrency.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChangeCurrency.Location = new System.Drawing.Point(331, 32);
            this.btnChangeCurrency.Name = "btnChangeCurrency";
            this.btnChangeCurrency.Size = new System.Drawing.Size(58, 21);
            this.btnChangeCurrency.TabIndex = 195;
            this.btnChangeCurrency.Text = "Change";
            this.btnChangeCurrency.UseVisualStyleBackColor = false;
            this.btnChangeCurrency.Click += new System.EventHandler(this.btnChangeCurrency_Click);
            // 
            // lblChooseCurrency
            // 
            this.lblChooseCurrency.AutoSize = true;
            this.lblChooseCurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChooseCurrency.Location = new System.Drawing.Point(270, 12);
            this.lblChooseCurrency.Name = "lblChooseCurrency";
            this.lblChooseCurrency.Size = new System.Drawing.Size(119, 17);
            this.lblChooseCurrency.TabIndex = 194;
            this.lblChooseCurrency.Text = "Choose currency:";
            // 
            // lLblDonate
            // 
            this.lLblDonate.ActiveLinkColor = System.Drawing.Color.White;
            this.lLblDonate.AutoSize = true;
            this.lLblDonate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lLblDonate.LinkColor = System.Drawing.Color.White;
            this.lLblDonate.Location = new System.Drawing.Point(229, 402);
            this.lLblDonate.Name = "lLblDonate";
            this.lLblDonate.Size = new System.Drawing.Size(42, 13);
            this.lLblDonate.TabIndex = 192;
            this.lLblDonate.TabStop = true;
            this.lLblDonate.Text = "Donate";
            this.lLblDonate.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lLblDonate_LinkClicked);
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(677, 402);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(60, 13);
            this.lblVersion.TabIndex = 191;
            this.lblVersion.Text = "Version 1.2";
            // 
            // lLblTwitter
            // 
            this.lLblTwitter.ActiveLinkColor = System.Drawing.Color.White;
            this.lLblTwitter.AutoSize = true;
            this.lLblTwitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lLblTwitter.LinkColor = System.Drawing.Color.Cyan;
            this.lLblTwitter.Location = new System.Drawing.Point(184, 402);
            this.lLblTwitter.Name = "lLblTwitter";
            this.lLblTwitter.Size = new System.Drawing.Size(39, 13);
            this.lLblTwitter.TabIndex = 154;
            this.lLblTwitter.TabStop = true;
            this.lLblTwitter.Text = "Twitter";
            this.lLblTwitter.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // grpBxCalcTimer
            // 
            this.grpBxCalcTimer.Controls.Add(this.btnHelpTimer);
            this.grpBxCalcTimer.Controls.Add(this.btnStop);
            this.grpBxCalcTimer.Controls.Add(this.btnStart);
            this.grpBxCalcTimer.Controls.Add(this.lblLimitation);
            this.grpBxCalcTimer.Controls.Add(this.rTxtBxTimerTime);
            this.grpBxCalcTimer.Controls.Add(this.lblTime);
            this.grpBxCalcTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBxCalcTimer.ForeColor = System.Drawing.Color.White;
            this.grpBxCalcTimer.Location = new System.Drawing.Point(12, 12);
            this.grpBxCalcTimer.Name = "grpBxCalcTimer";
            this.grpBxCalcTimer.Size = new System.Drawing.Size(235, 149);
            this.grpBxCalcTimer.TabIndex = 153;
            this.grpBxCalcTimer.TabStop = false;
            this.grpBxCalcTimer.Text = "Calculation Timer";
            // 
            // btnHelpTimer
            // 
            this.btnHelpTimer.BackColor = System.Drawing.Color.Gray;
            this.btnHelpTimer.Cursor = System.Windows.Forms.Cursors.Help;
            this.btnHelpTimer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHelpTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnHelpTimer.Location = new System.Drawing.Point(205, 11);
            this.btnHelpTimer.Name = "btnHelpTimer";
            this.btnHelpTimer.Size = new System.Drawing.Size(24, 25);
            this.btnHelpTimer.TabIndex = 156;
            this.btnHelpTimer.Text = "?";
            this.btnHelpTimer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnHelpTimer.UseVisualStyleBackColor = false;
            this.btnHelpTimer.Click += new System.EventHandler(this.btnHelpTimer_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.Gray;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnStop.Location = new System.Drawing.Point(121, 99);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(98, 40);
            this.btnStop.TabIndex = 155;
            this.btnStop.Text = "Stop";
            this.btnStop.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Gray;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnStart.Location = new System.Drawing.Point(17, 99);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(98, 40);
            this.btnStart.TabIndex = 154;
            this.btnStart.Text = "Start";
            this.btnStart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblLimitation
            // 
            this.lblLimitation.AutoSize = true;
            this.lblLimitation.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLimitation.Location = new System.Drawing.Point(15, 72);
            this.lblLimitation.Name = "lblLimitation";
            this.lblLimitation.Size = new System.Drawing.Size(186, 12);
            this.lblLimitation.TabIndex = 2;
            this.lblLimitation.Text = "Choose a number between 5 and 60 minutes";
            // 
            // rTxtBxTimerTime
            // 
            this.rTxtBxTimerTime.BackColor = System.Drawing.Color.Silver;
            this.rTxtBxTimerTime.Location = new System.Drawing.Point(17, 48);
            this.rTxtBxTimerTime.Multiline = false;
            this.rTxtBxTimerTime.Name = "rTxtBxTimerTime";
            this.rTxtBxTimerTime.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rTxtBxTimerTime.Size = new System.Drawing.Size(116, 21);
            this.rTxtBxTimerTime.TabIndex = 1;
            this.rTxtBxTimerTime.Text = "";
            this.rTxtBxTimerTime.TextChanged += new System.EventHandler(this.rTxtBxTimerTime_TextChanged);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(14, 30);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(172, 15);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "Minutes between calculations:";
            // 
            // lblMadeBy
            // 
            this.lblMadeBy.AutoSize = true;
            this.lblMadeBy.Location = new System.Drawing.Point(3, 402);
            this.lblMadeBy.Name = "lblMadeBy";
            this.lblMadeBy.Size = new System.Drawing.Size(175, 13);
            this.lblMadeBy.TabIndex = 152;
            this.lblMadeBy.Text = "Made by Leon aka Noel_the_N00B";
            // 
            // btnImportOldXML
            // 
            this.btnImportOldXML.BackColor = System.Drawing.Color.Gray;
            this.btnImportOldXML.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnImportOldXML.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnImportOldXML.Location = new System.Drawing.Point(12, 184);
            this.btnImportOldXML.Name = "btnImportOldXML";
            this.btnImportOldXML.Size = new System.Drawing.Size(126, 63);
            this.btnImportOldXML.TabIndex = 151;
            this.btnImportOldXML.Text = "Import old \"cases.xml\"";
            this.btnImportOldXML.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnImportOldXML.UseVisualStyleBackColor = false;
            this.btnImportOldXML.Click += new System.EventHandler(this.btnImportOldXML_Click);
            // 
            // calcTimer
            // 
            this.calcTimer.Tick += new System.EventHandler(this.CalcTimer_Tick);
            // 
            // cmbBxCurrency
            // 
            this.cmbBxCurrency.BackColor = System.Drawing.Color.Silver;
            this.cmbBxCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBxCurrency.FormattingEnabled = true;
            this.cmbBxCurrency.Items.AddRange(new object[] {
            "$",
            "£",
            "€"});
            this.cmbBxCurrency.Location = new System.Drawing.Point(273, 32);
            this.cmbBxCurrency.Name = "cmbBxCurrency";
            this.cmbBxCurrency.Size = new System.Drawing.Size(52, 21);
            this.cmbBxCurrency.TabIndex = 196;
            // 
            // Form_Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(740, 424);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form_Options";
            this.Text = "CS:GO Case Calculator - Options";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Options_Exit);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grpBxCalcTimer.ResumeLayout(false);
            this.grpBxCalcTimer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnImportOldXML;
        private System.Windows.Forms.Label lblMadeBy;
        private System.Windows.Forms.GroupBox grpBxCalcTimer;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button btnHelpTimer;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblLimitation;
        private System.Windows.Forms.RichTextBox rTxtBxTimerTime;
        private System.Windows.Forms.LinkLabel lLblTwitter;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Timer calcTimer;
        private System.Windows.Forms.LinkLabel lLblDonate;
        private System.Windows.Forms.Label lblChooseCurrency;
        private System.Windows.Forms.Button btnChangeCurrency;
        internal System.Windows.Forms.ComboBox cmbBxCurrency;
    }
}