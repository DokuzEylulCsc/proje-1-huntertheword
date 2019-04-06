namespace Huntertheword
{
    partial class Dereceler
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
            this.richTextBox_Dereceler = new System.Windows.Forms.RichTextBox();
            this.buton_cikis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox_Dereceler
            // 
            this.richTextBox_Dereceler.Location = new System.Drawing.Point(12, 12);
            this.richTextBox_Dereceler.Name = "richTextBox_Dereceler";
            this.richTextBox_Dereceler.ReadOnly = true;
            this.richTextBox_Dereceler.Size = new System.Drawing.Size(606, 515);
            this.richTextBox_Dereceler.TabIndex = 0;
            this.richTextBox_Dereceler.Text = "";
            // 
            // buton_cikis
            // 
            this.buton_cikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buton_cikis.ForeColor = System.Drawing.Color.Red;
            this.buton_cikis.Location = new System.Drawing.Point(645, 457);
            this.buton_cikis.Name = "buton_cikis";
            this.buton_cikis.Size = new System.Drawing.Size(107, 70);
            this.buton_cikis.TabIndex = 1;
            this.buton_cikis.Text = "Çıkış";
            this.buton_cikis.UseVisualStyleBackColor = true;
            this.buton_cikis.Click += new System.EventHandler(this.buton_cikis_Click);
            // 
            // Dereceler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 539);
            this.Controls.Add(this.buton_cikis);
            this.Controls.Add(this.richTextBox_Dereceler);
            this.MaximizeBox = false;
            this.Name = "Dereceler";
            this.Text = "Dereceler";
            this.Load += new System.EventHandler(this.Dereceler_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox_Dereceler;
        private System.Windows.Forms.Button buton_cikis;
    }
}