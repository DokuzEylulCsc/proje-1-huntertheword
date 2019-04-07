using System;
using System.Diagnostics;
using System.Timers;

namespace Huntertheword
{
    public class Oyun
    {
        private static System.Timers.Timer myTimer;
        private static Stopwatch sw = new Stopwatch();
        private Sozcuk sozcukhaznem;
        private int oyunSuresi = 60; // oyun suresi simdilik 60 sn
        //private static int sayac = 0;

        private static HunterTheWord hunterForm = new HunterTheWord(); // Form

        public Sozcuk SozcukHaznem { get => sozcukhaznem; set => sozcukhaznem = value; }
        public static HunterTheWord HunterForm { get => hunterForm; set => hunterForm = value; }

        //Oyun sınıfı ise oyunu başlatma ve bitirme görevlerini yerine getirecektir.
        public Oyun(string zorluk)
        {
            if (zorluk == "kolay")
                SozcukHaznem = new KolaySozcuk();
            else if (zorluk == "orta")
                SozcukHaznem = new OrtaSozcuk();
            else if (zorluk == "zor")
                SozcukHaznem = new ZorSozcuk();
        }

        public void Baslat()
        {
            Console.WriteLine("oyun basladi");

            sw.Start(); // stopwatch basladi

            myTimer = new Timer(2000); // 5 dakika oyun süresi 5 * 60 * birSaniye
            if (sw.Elapsed.Seconds < oyunSuresi)
                myTimer.Elapsed += OyunDongusu;
            myTimer.AutoReset = true;
            myTimer.Enabled = true;

        }

        internal void Bitir(string v, object oyuncuİsimi)
        {
            throw new NotImplementedException();
        }

        private void OyunDongusu(Object source, ElapsedEventArgs e)
        {
            //Console.WriteLine(yapayZeka.kelimeSun(this.SozcukHaznem)[sayac]);
            //sayac++;

            if (sw.Elapsed.Seconds < oyunSuresi)
            {
                Console.WriteLine(sw.Elapsed.Seconds);
                oyunSuresi--;
                hunterForm.sureAl(oyunSuresi);
            }

            if (sw.Elapsed.Seconds >= oyunSuresi)
            {
                sw.Stop();
                this.Bitir();
            }


        }

        public void Bitir()
        {
            Console.WriteLine("oyun bitti");
        }
        public void kaydediciBilgiGönder(string oyuncuİsmi, string zorluk)
        {
            Kaydedici kayit = new Kaydedici();
            kayit.dosyayaYaz(oyuncuİsmi, zorluk, 50, 60);// kaydediciye skor ve süre gidecek
        }

        public HunterTheWord GetirForm()
        {
            HunterForm.AIyeSozcukTurunuGonderici_ = SozcukHaznem;
            HunterForm.sureAl(sw.Elapsed.Seconds);
            return HunterForm;
        }
    }
}
