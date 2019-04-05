namespace Huntertheword
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
            this.Baslat = new System.Windows.Forms.Button();
            this.KolayButton = new System.Windows.Forms.RadioButton();
            this.OrtaButton = new System.Windows.Forms.RadioButton();
            this.ZorButton = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bilgiButonu = new System.Windows.Forms.Button();
            this.derecelerButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Baslat
            // 
            this.Baslat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Baslat.Location = new System.Drawing.Point(138, 455);
            this.Baslat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Baslat.Name = "Baslat";
            this.Baslat.Size = new System.Drawing.Size(361, 50);
            this.Baslat.TabIndex = 1;
            this.Baslat.Text = "YENİ OYUN";
            this.Baslat.UseVisualStyleBackColor = true;
            this.Baslat.Click += new System.EventHandler(this.Baslat_Click);
            // 
            // KolayButton
            // 
            this.KolayButton.AutoSize = true;
            this.KolayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KolayButton.Location = new System.Drawing.Point(138, 407);
            this.KolayButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.KolayButton.Name = "KolayButton";
            this.KolayButton.Size = new System.Drawing.Size(80, 21);
            this.KolayButton.TabIndex = 3;
            this.KolayButton.TabStop = true;
            this.KolayButton.Text = "KOLAY";
            this.KolayButton.UseVisualStyleBackColor = true;
            this.KolayButton.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // OrtaButton
            // 
            this.OrtaButton.AutoSize = true;
            this.OrtaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OrtaButton.Location = new System.Drawing.Point(276, 407);
            this.OrtaButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OrtaButton.Name = "OrtaButton";
            this.OrtaButton.Size = new System.Drawing.Size(72, 21);
            this.OrtaButton.TabIndex = 4;
            this.OrtaButton.TabStop = true;
            this.OrtaButton.Text = "ORTA";
            this.OrtaButton.UseVisualStyleBackColor = true;
            // 
            // ZorButton
            // 
            this.ZorButton.AutoSize = true;
            this.ZorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ZorButton.Location = new System.Drawing.Point(437, 407);
            this.ZorButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ZorButton.Name = "ZorButton";
            this.ZorButton.Size = new System.Drawing.Size(62, 21);
            this.ZorButton.TabIndex = 5;
            this.ZorButton.TabStop = true;
            this.ZorButton.Text = "ZOR";
            this.ZorButton.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(640, 359);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // bilgiButonu
            // 
            this.bilgiButonu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bilgiButonu.ForeColor = System.Drawing.Color.Coral;
            this.bilgiButonu.Location = new System.Drawing.Point(12, 425);
            this.bilgiButonu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bilgiButonu.Name = "bilgiButonu";
            this.bilgiButonu.Size = new System.Drawing.Size(87, 80);
            this.bilgiButonu.TabIndex = 7;
            this.bilgiButonu.Text = "Bilgi";
            this.bilgiButonu.UseVisualStyleBackColor = true;
            this.bilgiButonu.Click += new System.EventHandler(this.bilgiButonu_Click);
            // 
            // derecelerButton
            // 
            this.derecelerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.derecelerButton.ForeColor = System.Drawing.Color.Coral;
            this.derecelerButton.Location = new System.Drawing.Point(523, 425);
            this.derecelerButton.Name = "derecelerButton";
            this.derecelerButton.Size = new System.Drawing.Size(105, 80);
            this.derecelerButton.TabIndex = 8;
            this.derecelerButton.Text = "Dereceler";
            this.derecelerButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 554);
            this.Controls.Add(this.derecelerButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bilgiButonu);
            this.Controls.Add(this.ZorButton);
            this.Controls.Add(this.OrtaButton);
            this.Controls.Add(this.KolayButton);
            this.Controls.Add(this.Baslat);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Hunter The Word";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Baslat;
        private System.Windows.Forms.RadioButton KolayButton;
        private System.Windows.Forms.RadioButton OrtaButton;
        private System.Windows.Forms.RadioButton ZorButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bilgiButonu;
        private System.Windows.Forms.Button derecelerButton;
    }
}

