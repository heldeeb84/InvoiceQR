namespace InvoiceQR
{
    partial class InvoiceQR
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
            this.label1 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.VATTotalTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.totalWithVatTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimeTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TRNtextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.generateQRBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Saller name";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(155, 73);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(258, 24);
            this.nameTextBox.TabIndex = 1;
            this.nameTextBox.Text = "شركة العطاء";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Invoice Data";
            // 
            // VATTotalTextBox
            // 
            this.VATTotalTextBox.Location = new System.Drawing.Point(155, 258);
            this.VATTotalTextBox.Name = "VATTotalTextBox";
            this.VATTotalTextBox.Size = new System.Drawing.Size(258, 24);
            this.VATTotalTextBox.TabIndex = 4;
            this.VATTotalTextBox.Text = "675.00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "VAT Total";
            // 
            // totalWithVatTextBox
            // 
            this.totalWithVatTextBox.Location = new System.Drawing.Point(155, 211);
            this.totalWithVatTextBox.Name = "totalWithVatTextBox";
            this.totalWithVatTextBox.Size = new System.Drawing.Size(258, 24);
            this.totalWithVatTextBox.TabIndex = 6;
            this.totalWithVatTextBox.Text = "4500.00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Total With Vat";
            // 
            // dateTimeTextBox
            // 
            this.dateTimeTextBox.Location = new System.Drawing.Point(155, 164);
            this.dateTimeTextBox.Name = "dateTimeTextBox";
            this.dateTimeTextBox.Size = new System.Drawing.Size(258, 24);
            this.dateTimeTextBox.TabIndex = 8;
            this.dateTimeTextBox.Text = "2021-12-28 11:30";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Date/Time";
            // 
            // TRNtextBox
            // 
            this.TRNtextBox.Location = new System.Drawing.Point(155, 117);
            this.TRNtextBox.Name = "TRNtextBox";
            this.TRNtextBox.Size = new System.Drawing.Size(258, 24);
            this.TRNtextBox.TabIndex = 10;
            this.TRNtextBox.Text = "123456789123456";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Saller\'s TRN";
            // 
            // generateQRBtn
            // 
            this.generateQRBtn.Location = new System.Drawing.Point(155, 307);
            this.generateQRBtn.Name = "generateQRBtn";
            this.generateQRBtn.Size = new System.Drawing.Size(112, 33);
            this.generateQRBtn.TabIndex = 11;
            this.generateQRBtn.Text = "Generate QR";
            this.generateQRBtn.UseVisualStyleBackColor = true;
            this.generateQRBtn.Click += new System.EventHandler(this.generateQRBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(595, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(262, 300);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(28, 371);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(933, 183);
            this.richTextBox1.TabIndex = 13;
            this.richTextBox1.Text = "";
            // 
            // InvoiceQR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 566);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.generateQRBtn);
            this.Controls.Add(this.TRNtextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimeTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.totalWithVatTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.VATTotalTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label1);
            this.Name = "InvoiceQR";
            this.Text = "InvoiceQR";
            this.Load += new System.EventHandler(this.InvoiceQR_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox VATTotalTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox totalWithVatTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox dateTimeTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TRNtextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button generateQRBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

