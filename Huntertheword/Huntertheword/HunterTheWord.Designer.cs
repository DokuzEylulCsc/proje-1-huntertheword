using System.Windows.Forms;

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
            this.label1 = new System.Windows.Forms.Label();
            this.sureLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // kontrolEt
            // 
            this.kontrolEt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kontrolEt.Location = new System.Drawing.Point(239, 442);
            this.kontrolEt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.Skor.Location = new System.Drawing.Point(13, 14);
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
            this.SkorSayı.Location = new System.Drawing.Point(83, 14);
            this.SkorSayı.Name = "SkorSayı";
            this.SkorSayı.Size = new System.Drawing.Size(24, 25);
            this.SkorSayı.TabIndex = 2;
            this.SkorSayı.Text = "0";
            // 
            // kelimeGirisi
            // 
            this.kelimeGirisi.Location = new System.Drawing.Point(239, 401);
            this.kelimeGirisi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kelimeGirisi.Name = "kelimeGirisi";
            this.kelimeGirisi.Size = new System.Drawing.Size(251, 22);
            this.kelimeGirisi.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(576, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Süre:";
            // 
            // sureLabel
            // 
            this.sureLabel.AutoSize = true;
            this.sureLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sureLabel.ForeColor = System.Drawing.Color.Red;
            this.sureLabel.Location = new System.Drawing.Point(674, 14);
            this.sureLabel.Name = "sureLabel";
            this.sureLabel.Size = new System.Drawing.Size(54, 25);
            this.sureLabel.TabIndex = 5;
            this.sureLabel.Text = "süre";
            // 
            // HunterTheWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::Huntertheword.Properties.Resources.izmir_saat_kulesi_genel_gorunum;
            this.ClientSize = new System.Drawing.Size(740, 508);
            this.Controls.Add(this.sureLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kelimeGirisi);
            this.Controls.Add(this.SkorSayı);
            this.Controls.Add(this.Skor);
            this.Controls.Add(this.kontrolEt);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label sureLabel;

    }
}