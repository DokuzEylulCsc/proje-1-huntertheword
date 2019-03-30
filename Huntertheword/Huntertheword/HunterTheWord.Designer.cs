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
            this.button1 = new System.Windows.Forms.Button();
            this.Skor = new System.Windows.Forms.Label();
            this.SkorSayı = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(251, 348);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(251, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "KONTROL ET";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(299, 275);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(151, 22);
            this.textBox1.TabIndex = 3;
            // 
            // HunterTheWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.SkorSayı);
            this.Controls.Add(this.Skor);
            this.Controls.Add(this.button1);
            this.Name = "HunterTheWord";
            this.Text = "Hunter The Word";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Skor;
        private System.Windows.Forms.Label SkorSayı;
        private System.Windows.Forms.TextBox textBox1;
    }
}