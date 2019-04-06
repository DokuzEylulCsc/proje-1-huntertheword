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
        /*
         * aşağıdaki kurallar değiştirilebilir
         * 
         kolay = 1 => süresi: 6dk
         orta = 2 => süresi: 5dk
         zor = 3 => süresi: 4dk
             */

        private Oyun oyun;

        public Form1()
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            InitializeComponent();
        }
              

        private void bilgiButonu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Oyun 3 derece zorluktan oluşur." +
                "Her oyun için 10 kelime önünüze çıkacak ve her kelime için 10 hakkınız olacak." +
                "Her doğru cevabınızda 10 puan kazanacaksınız.");
        }

        private void kolayBtn_Click(object sender, EventArgs e)
        {
            oyunOlustur(1, 360);
        }

        private void ortaBtn_Click(object sender, EventArgs e)
        {
            oyunOlustur(2, 300);
        }

        private void zorBtn_Click(object sender, EventArgs e)
        {
            oyunOlustur(3,240);
        }

        //bu metod verilen zorluğa ve süreye göre yeni oyun oluşturuyor.
        private void oyunOlustur(int zorluk,int sure)
        {
            oyun = new Oyun(1);
            oyun.OyunSuresi = sure;
        }

        private void derecelerButton_Click(object sender, EventArgs e)
        {
            Dereceler basarilar = new Dereceler();
            basarilar.ShowDialog();
        }
    }
}
