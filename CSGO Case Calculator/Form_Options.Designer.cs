namespace CSGO_Case_Calculator
{
    partial class Form_Options
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Options));
            this.panel1 = new System.Windows.Forms.Panel();
            this.grpBxCalcTimer = new System.Windows.Forms.GroupBox();
            this.btnHelpTimer = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblLimitation = new System.Windows.Forms.Label();
            this.rTxtBxTimerTime = new System.Windows.Forms.RichTextBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblMadeBy = new System.Windows.Forms.Label();
            this.btnImportOldXML = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.grpBxCalcTimer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.grpBxCalcTimer);
            this.panel1.Controls.Add(this.lblMadeBy);
            this.panel1.Controls.Add(this.btnImportOldXML);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(987, 522);
            this.panel1.TabIndex = 0;
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
            this.grpBxCalcTimer.Location = new System.Drawing.Point(16, 15);
            this.grpBxCalcTimer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpBxCalcTimer.Name = "grpBxCalcTimer";
            this.grpBxCalcTimer.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpBxCalcTimer.Size = new System.Drawing.Size(313, 183);
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
            this.btnHelpTimer.Location = new System.Drawing.Point(273, 14);
            this.btnHelpTimer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHelpTimer.Name = "btnHelpTimer";
            this.btnHelpTimer.Size = new System.Drawing.Size(32, 31);
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
            this.btnStop.Location = new System.Drawing.Point(161, 122);
            this.btnStop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(131, 49);
            this.btnStop.TabIndex = 155;
            this.btnStop.Text = "Stop";
            this.btnStop.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnStop.UseVisualStyleBackColor = false;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Gray;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnStart.Location = new System.Drawing.Point(23, 122);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(131, 49);
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
            this.lblLimitation.Location = new System.Drawing.Point(20, 89);
            this.lblLimitation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLimitation.Name = "lblLimitation";
            this.lblLimitation.Size = new System.Drawing.Size(255, 15);
            this.lblLimitation.TabIndex = 2;
            this.lblLimitation.Text = "Choose an integer between 5 and 60 minutes";
            // 
            // rTxtBxTimerTime
            // 
            this.rTxtBxTimerTime.BackColor = System.Drawing.Color.Silver;
            this.rTxtBxTimerTime.Location = new System.Drawing.Point(23, 59);
            this.rTxtBxTimerTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rTxtBxTimerTime.Multiline = false;
            this.rTxtBxTimerTime.Name = "rTxtBxTimerTime";
            this.rTxtBxTimerTime.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rTxtBxTimerTime.Size = new System.Drawing.Size(153, 25);
            this.rTxtBxTimerTime.TabIndex = 1;
            this.rTxtBxTimerTime.Text = "";
            this.rTxtBxTimerTime.TextChanged += new System.EventHandler(this.rTxtBxTimerTime_TextChanged);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(19, 37);
            this.lblTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(205, 18);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "Minutes between calculations:";
            // 
            // lblMadeBy
            // 
            this.lblMadeBy.AutoSize = true;
            this.lblMadeBy.Location = new System.Drawing.Point(749, 495);
            this.lblMadeBy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMadeBy.Name = "lblMadeBy";
            this.lblMadeBy.Size = new System.Drawing.Size(229, 17);
            this.lblMadeBy.TabIndex = 152;
            this.lblMadeBy.Text = "Made by Leon aka Noel_the_N00B";
            // 
            // btnImportOldXML
            // 
            this.btnImportOldXML.BackColor = System.Drawing.Color.Gray;
            this.btnImportOldXML.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnImportOldXML.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnImportOldXML.Location = new System.Drawing.Point(16, 226);
            this.btnImportOldXML.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnImportOldXML.Name = "btnImportOldXML";
            this.btnImportOldXML.Size = new System.Drawing.Size(168, 78);
            this.btnImportOldXML.TabIndex = 151;
            this.btnImportOldXML.Text = "Import old XML-file";
            this.btnImportOldXML.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnImportOldXML.UseVisualStyleBackColor = false;
            this.btnImportOldXML.Click += new System.EventHandler(this.btnImportOldXML_Click);
            // 
            // Form_Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(987, 522);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Form_Options";
            this.Text = "CS:GO Case Calculator - Options";
            this.Load += new System.EventHandler(this.Form_Options_Load);
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
    }
}