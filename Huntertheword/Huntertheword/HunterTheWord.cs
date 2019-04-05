using System;
using System.Windows.Forms;

namespace Huntertheword
{
    public partial class HunterTheWord : Form
    {
        private bool girdiDogruMu;
        Oyun oyun;

        public HunterTheWord(Oyun oyun)
        {
            this.oyun = oyun;
            InitializeComponent();
            sureLabel.Text = oyun.OyunSuresi.ToString();
        }


        private void kontrolEt_Click(object sender, EventArgs e)
        {


            //oyun süresi bitmişse tekrar başlatamamsı için if kontrolü
            if (oyun.OyunSuresi > 0)
            {
                /*
             * burdaki 3 şu anki tahminin olması gereken uzunluk bunu bir sayaç yardımıyla ilerletmemiz lazım
             * şimdilik 3 olarak yazdım.
             */

                //girdi kontrolü yapıp kullanıcıya tepki veriyor.
                girdiDogruMu = Oyuncu.KullanicidanGirdiAl(kelimeGirisi.Text, 3);
                if (!girdiDogruMu)
                {
                    TepkiVer("Tahmininiz olmaması gereken bir karakter içeriyor!");
                }
                else
                {
                    oyunBitti.Visible = false;
                }

                //oyun süresini ilk tahmin gönderilene kadar başlatmıyoruz.
                timer1.Start();

            }
        }

        private void TepkiVer(string tepki)
        {
            //kullanıcıya bu metod sayesinde tepki veriyoruz.
            oyunBitti.Visible = true;
            oyunBitti.Text = tepki;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //her saniye oyun süresinden azalıyor.oyunun bitip bitmediğini kontrol edip kullanıcıya tepki veriyor.
            oyun.OyunSuresi--;
            sureLabel.Text = oyun.OyunSuresi.ToString();
            timer1.Start();

            if (oyun.OyunSuresi == 0)
            {
                timer1.Stop();
                TepkiVer("Süreniz Doldu!");
                oyun.sureBitti();
            }
        }
    }
}
