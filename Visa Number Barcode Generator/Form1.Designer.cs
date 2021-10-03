namespace Visa_Number_Barcode_Generator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.visaNumberLabel = new System.Windows.Forms.Label();
            this.visaNumberTextBox = new System.Windows.Forms.TextBox();
            this.passportNoLabel = new System.Windows.Forms.Label();
            this.passportNoTextBox = new System.Windows.Forms.TextBox();
            this.fullNameTextBox = new System.Windows.Forms.TextBox();
            this.fullNameLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.generateBarcodeBtn = new System.Windows.Forms.Button();
            this.generatePdfBtn = new System.Windows.Forms.Button();
            this.visaNumberBarcodeLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.sponsorNameTextBox = new System.Windows.Forms.TextBox();
            this.sponsorNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // visaNumberLabel
            // 
            this.visaNumberLabel.AutoSize = true;
            this.visaNumberLabel.Location = new System.Drawing.Point(70, 145);
            this.visaNumberLabel.Name = "visaNumberLabel";
            this.visaNumberLabel.Size = new System.Drawing.Size(67, 13);
            this.visaNumberLabel.TabIndex = 0;
            this.visaNumberLabel.Text = "Visa Number";
            // 
            // visaNumberTextBox
            // 
            this.visaNumberTextBox.Location = new System.Drawing.Point(167, 142);
            this.visaNumberTextBox.Name = "visaNumberTextBox";
            this.visaNumberTextBox.Size = new System.Drawing.Size(163, 20);
            this.visaNumberTextBox.TabIndex = 1;
            // 
            // passportNoLabel
            // 
            this.passportNoLabel.AutoSize = true;
            this.passportNoLabel.Location = new System.Drawing.Point(70, 187);
            this.passportNoLabel.Name = "passportNoLabel";
            this.passportNoLabel.Size = new System.Drawing.Size(68, 13);
            this.passportNoLabel.TabIndex = 2;
            this.passportNoLabel.Text = "Passport No.";
            // 
            // passportNoTextBox
            // 
            this.passportNoTextBox.Location = new System.Drawing.Point(167, 184);
            this.passportNoTextBox.Name = "passportNoTextBox";
            this.passportNoTextBox.Size = new System.Drawing.Size(163, 20);
            this.passportNoTextBox.TabIndex = 3;
            // 
            // fullNameTextBox
            // 
            this.fullNameTextBox.Location = new System.Drawing.Point(167, 220);
            this.fullNameTextBox.Name = "fullNameTextBox";
            this.fullNameTextBox.Size = new System.Drawing.Size(163, 20);
            this.fullNameTextBox.TabIndex = 5;
            // 
            // fullNameLabel
            // 
            this.fullNameLabel.AutoSize = true;
            this.fullNameLabel.Location = new System.Drawing.Point(70, 223);
            this.fullNameLabel.Name = "fullNameLabel";
            this.fullNameLabel.Size = new System.Drawing.Size(54, 13);
            this.fullNameLabel.TabIndex = 4;
            this.fullNameLabel.Text = "Full Name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(89, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(198, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // generateBarcodeBtn
            // 
            this.generateBarcodeBtn.Location = new System.Drawing.Point(89, 293);
            this.generateBarcodeBtn.Name = "generateBarcodeBtn";
            this.generateBarcodeBtn.Size = new System.Drawing.Size(110, 23);
            this.generateBarcodeBtn.TabIndex = 7;
            this.generateBarcodeBtn.Text = "Generate Barcode";
            this.generateBarcodeBtn.UseVisualStyleBackColor = true;
            this.generateBarcodeBtn.Click += new System.EventHandler(this.generateBarcodeBtn_Click);
            // 
            // generatePdfBtn
            // 
            this.generatePdfBtn.Location = new System.Drawing.Point(226, 293);
            this.generatePdfBtn.Name = "generatePdfBtn";
            this.generatePdfBtn.Size = new System.Drawing.Size(86, 23);
            this.generatePdfBtn.TabIndex = 8;
            this.generatePdfBtn.Text = "Generate Pdf";
            this.generatePdfBtn.UseVisualStyleBackColor = true;
            this.generatePdfBtn.Click += new System.EventHandler(this.generatePdfBtn_Click);
            // 
            // visaNumberBarcodeLabel
            // 
            this.visaNumberBarcodeLabel.AutoSize = true;
            this.visaNumberBarcodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visaNumberBarcodeLabel.Location = new System.Drawing.Point(147, 70);
            this.visaNumberBarcodeLabel.Name = "visaNumberBarcodeLabel";
            this.visaNumberBarcodeLabel.Size = new System.Drawing.Size(0, 15);
            this.visaNumberBarcodeLabel.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 337);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(399, 22);
            this.panel1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(2, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(373, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "©2019 Developed by Nabil Mohammd Khalifa   Contact us: 00251966686856";
            // 
            // sponsorNameTextBox
            // 
            this.sponsorNameTextBox.Location = new System.Drawing.Point(167, 255);
            this.sponsorNameTextBox.Name = "sponsorNameTextBox";
            this.sponsorNameTextBox.Size = new System.Drawing.Size(163, 20);
            this.sponsorNameTextBox.TabIndex = 12;
            // 
            // sponsorNameLabel
            // 
            this.sponsorNameLabel.AutoSize = true;
            this.sponsorNameLabel.Location = new System.Drawing.Point(70, 258);
            this.sponsorNameLabel.Name = "sponsorNameLabel";
            this.sponsorNameLabel.Size = new System.Drawing.Size(77, 13);
            this.sponsorNameLabel.TabIndex = 11;
            this.sponsorNameLabel.Text = "Sponsor Name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 359);
            this.Controls.Add(this.sponsorNameTextBox);
            this.Controls.Add(this.sponsorNameLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.visaNumberBarcodeLabel);
            this.Controls.Add(this.generatePdfBtn);
            this.Controls.Add(this.generateBarcodeBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.fullNameTextBox);
            this.Controls.Add(this.fullNameLabel);
            this.Controls.Add(this.passportNoTextBox);
            this.Controls.Add(this.passportNoLabel);
            this.Controls.Add(this.visaNumberTextBox);
            this.Controls.Add(this.visaNumberLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visa Number Barcode Generator";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label visaNumberLabel;
        private System.Windows.Forms.TextBox visaNumberTextBox;
        private System.Windows.Forms.Label passportNoLabel;
        private System.Windows.Forms.TextBox passportNoTextBox;
        private System.Windows.Forms.TextBox fullNameTextBox;
        private System.Windows.Forms.Label fullNameLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button generateBarcodeBtn;
        private System.Windows.Forms.Button generatePdfBtn;
        private System.Windows.Forms.Label visaNumberBarcodeLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sponsorNameTextBox;
        private System.Windows.Forms.Label sponsorNameLabel;
    }
}

