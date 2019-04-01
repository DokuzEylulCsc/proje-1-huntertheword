namespace Huntertheword
{
    partial class HunterTheWord
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
            this.kontrolEt = new System.Windows.Forms.Button();
            this.Skor = new System.Windows.Forms.Label();
            this.SkorSayı = new System.Windows.Forms.Label();
            this.kelimeGirisi = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.canLabel = new System.Windows.Forms.Label();
            this.can = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // kontrolEt
            // 
            this.kontrolEt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kontrolEt.Location = new System.Drawing.Point(251, 348);
            this.kontrolEt.Name = "kontrolEt";
            this.kontrolEt.Size = new System.Drawing.Size(251, 42);
            this.kontrolEt.TabIndex = 0;
            this.kontrolEt.Text = "KONTROL ET";
            this.kontrolEt.UseVisualStyleBackColor = true;
            this.kontrolEt.Click += new System.EventHandler(this.kontrolEt_Click);
            // 
            // Skor
            // 
            this.Skor.AutoSize = true;
            this.Skor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Skor.ForeColor = System.Drawing.Color.Red;
            this.Skor.Location = new System.Drawing.Point(13, 13);
            this.Skor.Name = "Skor";
            this.Skor.Size = new System.Drawing.Size(64, 25);
            this.Skor.TabIndex = 1;
            this.Skor.Text = "Skor:";
            // 
            // SkorSayı
            // 
            this.SkorSayı.AutoSize = true;
            this.SkorSayı.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SkorSayı.ForeColor = System.Drawing.Color.Red;
            this.SkorSayı.Location = new System.Drawing.Point(83, 13);
            this.SkorSayı.Name = "SkorSayı";
            this.SkorSayı.Size = new System.Drawing.Size(24, 25);
            this.SkorSayı.TabIndex = 2;
            this.SkorSayı.Text = "0";
            // 
            // kelimeGirisi
            // 
            this.kelimeGirisi.Location = new System.Drawing.Point(299, 275);
            this.kelimeGirisi.Name = "kelimeGirisi";
            this.kelimeGirisi.Size = new System.Drawing.Size(151, 22);
            this.kelimeGirisi.TabIndex = 3;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(299, 136);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 84);
            this.listBox1.TabIndex = 4;
            // 
            // canLabel
            // 
            this.canLabel.AutoSize = true;
            this.canLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.canLabel.ForeColor = System.Drawing.Color.Red;
            this.canLabel.Location = new System.Drawing.Point(15, 54);
            this.canLabel.Name = "canLabel";
            this.canLabel.Size = new System.Drawing.Size(59, 25);
            this.canLabel.TabIndex = 5;
            this.canLabel.Text = "Can:";
            // 
            // can
            // 
            this.can.AutoSize = true;
            this.can.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.can.ForeColor = System.Drawing.Color.Red;
            this.can.Location = new System.Drawing.Point(80, 54);
            this.can.Name = "can";
            this.can.Size = new System.Drawing.Size(36, 25);
            this.can.TabIndex = 6;
            this.can.Text = "10\r\n";
            // 
            // HunterTheWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 450);
            this.Controls.Add(this.can);
            this.Controls.Add(this.canLabel);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.kelimeGirisi);
            this.Controls.Add(this.SkorSayı);
            this.Controls.Add(this.Skor);
            this.Controls.Add(this.kontrolEt);
            this.MaximizeBox = false;
            this.Name = "HunterTheWord";
            this.Text = "Hunter The Word";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button kontrolEt;
        private System.Windows.Forms.Label Skor;
        private System.Windows.Forms.Label SkorSayı;
        private System.Windows.Forms.TextBox kelimeGirisi;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label canLabel;
        private System.Windows.Forms.Label can;
    }
}