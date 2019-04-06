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
    public partial class HunterTheWord : Form
    {
        private bool girdiDogruMu;

        public HunterTheWord()
        {
            InitializeComponent();
        }


        private void kontrolEt_Click(object sender, EventArgs e)
        {
            /*
             * burdaki 3 şu anki tahminin olması gereken uzunluk bunu bir sayaç yardımıyla ilerletmemiz lazım
             * şimdilik 3 olarak yazdım.
             */
            girdiDogruMu = Oyuncu.KullanicidanGirdiAl(kelimeGirisi.Text, 3);
            Console.WriteLine("girdi: " + girdiDogruMu);
            TepkiVer();
        }

        private void TepkiVer()
        {
            /*
             * girdi kontrolü yapıldıktan sonra kullanıcıya görsel olarak tepki verilmesi gerekiyor. 
             * Bu metodu temp olarak açtım değiştirilebilir.
             */
        }
        public void sureGonder(int sure)
        {
            sureLabel.Text = " " + sure;
        }
    }
}
