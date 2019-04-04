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
            this.canLabel = new System.Windows.Forms.Label();
            this.can = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // kontrolEt
            // 
            this.kontrolEt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kontrolEt.Location = new System.Drawing.Point(188, 283);
            this.kontrolEt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.kontrolEt.Name = "kontrolEt";
            this.kontrolEt.Size = new System.Drawing.Size(188, 34);
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
            this.Skor.Location = new System.Drawing.Point(10, 11);
            this.Skor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Skor.Name = "Skor";
            this.Skor.Size = new System.Drawing.Size(51, 20);
            this.Skor.TabIndex = 1;
            this.Skor.Text = "Skor:";
            // 
            // SkorSayı
            // 
            this.SkorSayı.AutoSize = true;
            this.SkorSayı.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SkorSayı.ForeColor = System.Drawing.Color.Red;
            this.SkorSayı.Location = new System.Drawing.Point(62, 11);
            this.SkorSayı.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SkorSayı.Name = "SkorSayı";
            this.SkorSayı.Size = new System.Drawing.Size(19, 20);
            this.SkorSayı.TabIndex = 2;
            this.SkorSayı.Text = "0";
            // 
            // kelimeGirisi
            // 
            this.kelimeGirisi.Location = new System.Drawing.Point(224, 223);
            this.kelimeGirisi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.kelimeGirisi.Name = "kelimeGirisi";
            this.kelimeGirisi.Size = new System.Drawing.Size(114, 20);
            this.kelimeGirisi.TabIndex = 3;
            // 
            // canLabel
            // 
            this.canLabel.AutoSize = true;
            this.canLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.canLabel.ForeColor = System.Drawing.Color.Red;
            this.canLabel.Location = new System.Drawing.Point(11, 44);
            this.canLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.canLabel.Name = "canLabel";
            this.canLabel.Size = new System.Drawing.Size(46, 20);
            this.canLabel.TabIndex = 5;
            this.canLabel.Text = "Can:";
            // 
            // can
            // 
            this.can.AutoSize = true;
            this.can.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.can.ForeColor = System.Drawing.Color.Red;
            this.can.Location = new System.Drawing.Point(60, 44);
            this.can.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.can.Name = "can";
            this.can.Size = new System.Drawing.Size(29, 20);
            this.can.TabIndex = 6;
            this.can.Text = "10\r\n";
            // 
            // HunterTheWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 366);
            this.Controls.Add(this.can);
            this.Controls.Add(this.canLabel);
            this.Controls.Add(this.kelimeGirisi);
            this.Controls.Add(this.SkorSayı);
            this.Controls.Add(this.Skor);
            this.Controls.Add(this.kontrolEt);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.Label canLabel;
        private System.Windows.Forms.Label can;
    }
}