using System;
using System.Diagnostics;
using System.Timers;

namespace Huntertheword
{
    public class Oyun
    {
        private static Timer myTimer;
        private static Stopwatch sw = new Stopwatch();
        private Sozcuk sozcukhaznem;
        private static int oyunSuresi = 0;
        private static HunterTheWord hunterForm = new HunterTheWord(); // Form
        private static int puan = 0;

        public Sozcuk SozcukHaznem { get => sozcukhaznem; set => sozcukhaznem = value; }
        public static HunterTheWord HunterForm { get => hunterForm; set => hunterForm = value; }
        public static int OyunSuresi { get => oyunSuresi; set => oyunSuresi = value; }
        public static int Puan { get => puan; set => puan = value; }
        public static Timer MyTimer { get => myTimer; set => myTimer = value; }

        //Oyun sınıfı ise oyunu başlatma ve bitirme görevlerini yerine getirecektir.
        public Oyun(string zorluk)
        {
            if (zorluk == "kolay")
            {
                SozcukHaznem = new KolaySozcuk();
                OyunSuresi = 241; // 4dk + 1sn
            }
            else if (zorluk == "orta")
            {
                SozcukHaznem = new OrtaSozcuk();
                OyunSuresi = 301; // 5dk + 1sn
            }
            else if (zorluk == "zor")
            {
                SozcukHaznem = new ZorSozcuk();
                OyunSuresi = 361; // 6dk + 1sn
            }
        }

        public void Baslat()
        {
            Console.WriteLine("oyun basladi");
            
            MyTimer = new Timer(1000);
            myTimer.Elapsed += OyunDongusu;

        }

        private void OyunDongusu(Object source, ElapsedEventArgs e)
        {
            Console.WriteLine(oyunSuresi);

            OyunSuresi--;
            hunterForm.sureAl(oyunSuresi);
            myTimer.Start();

            if (OyunSuresi <= 0)
            {
                myTimer.Stop();
            }
        }

        public static void Bitir()
        {
            Console.WriteLine("oyun bitti");
        }

        public void kaydediciBilgiGönder(string oyuncuİsmi, string zorluk)
        {
            Kaydedici kayit = new Kaydedici();
            kayit.dosyayaYaz(oyuncuİsmi, zorluk,puan,OyunSuresi);// kaydediciye skor ve süre gidecek
        }

        public HunterTheWord GetirForm()
        {
            HunterForm.AIyeSozcukTurunuGonderici_ = SozcukHaznem;
            HunterForm.sureAl(sw.Elapsed.Seconds);
            return HunterForm;
        }
    }
}
