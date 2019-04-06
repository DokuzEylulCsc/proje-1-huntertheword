using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Huntertheword
{
    public partial class Form1 : Form
    {
        // Yeniden yazilacak
        private string oyuncuİsmi;
        Oyun oyun1;
        public Form1()
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            InitializeComponent();

        }


        private void derecelerButton_Click(object sender, EventArgs e)
        {
            Dereceler basarilar = new Dereceler();
            basarilar.ShowDialog();
        }

       

        private void bilgiButonu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Oyun 3 derece zorluktan oluşur." +
                "Her oyun için 10 kelime önünüze çıkacak ve her zorlukta süreniz farklı olacak." +
                "Her doğru cevabınızda 10 puan kazanacaksınız.");
        }
        private void kolayBtn_Click(object sender, EventArgs e)
        {
            oyuncuİsmi = textBoxOyuncuİsmi.Text;
            oyun1 = new Oyun("kolay");
            oyun1.kaydediciBilgiGönder(oyuncuİsmi,"kolay");
        }
        private void ortaBtn_Click(object sender, EventArgs e)
        {
            oyuncuİsmi = textBoxOyuncuİsmi.Text;
            oyun1 = new Oyun("orta");
            oyun1.kaydediciBilgiGönder(oyuncuİsmi, "orta");
        }

        private void zorBtn_Click(object sender, EventArgs e)
        {
            oyuncuİsmi = textBoxOyuncuİsmi.Text;
            oyun1 = new Oyun("zor");
            oyun1.kaydediciBilgiGönder(oyuncuİsmi, "zor");
        }
        
    }
}
