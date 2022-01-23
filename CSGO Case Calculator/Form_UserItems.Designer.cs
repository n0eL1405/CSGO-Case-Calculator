
namespace CSGO_Case_Calculator
{
    partial class Form_UserItems
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_UserItems));
            this.rTxtBxChromaA = new System.Windows.Forms.RichTextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblLink = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rTxtBxChromaA
            // 
            this.rTxtBxChromaA.BackColor = System.Drawing.Color.Silver;
            this.rTxtBxChromaA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rTxtBxChromaA.Location = new System.Drawing.Point(12, 39);
            this.rTxtBxChromaA.Name = "rTxtBxChromaA";
            this.rTxtBxChromaA.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rTxtBxChromaA.Size = new System.Drawing.Size(164, 32);
            this.rTxtBxChromaA.TabIndex = 42;
            this.rTxtBxChromaA.Text = "";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.Silver;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(182, 39);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.richTextBox1.Size = new System.Drawing.Size(98, 32);
            this.richTextBox1.TabIndex = 43;
            this.richTextBox1.Text = "0";
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.Color.Silver;
            this.richTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox2.Location = new System.Drawing.Point(286, 39);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.richTextBox2.Size = new System.Drawing.Size(280, 32);
            this.richTextBox2.TabIndex = 44;
            this.richTextBox2.Text = "";
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(7, 10);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(103, 26);
            this.lblName.TabIndex = 156;
            this.lblName.Text = "Name:";
            // 
            // lblAmount
            // 
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(182, 10);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(103, 26);
            this.lblAmount.TabIndex = 157;
            this.lblAmount.Text = "Amount:";
            // 
            // lblLink
            // 
            this.lblLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLink.Location = new System.Drawing.Point(281, 10);
            this.lblLink.Name = "lblLink";
            this.lblLink.Size = new System.Drawing.Size(285, 26);
            this.lblLink.TabIndex = 158;
            this.lblLink.Text = "Steam Community Market Link:";
            // 
            // Form_UserItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(577, 450);
            this.Controls.Add(this.lblLink);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.rTxtBxChromaA);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_UserItems";
            this.Text = "Customs Itmes";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.RichTextBox rTxtBxChromaA;
        public System.Windows.Forms.RichTextBox richTextBox1;
        public System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblLink;
    }
}