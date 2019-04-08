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
        private int oyunSuresi = 0; // 5dk oyun süresi + 1 => formda 300 gozukmesi icin
        private static HunterTheWord hunterForm = new HunterTheWord(); // Form
        private static int puan = 0;

        public Sozcuk SozcukHaznem { get => sozcukhaznem; set => sozcukhaznem = value; }
        public static HunterTheWord HunterForm { get => hunterForm; set => hunterForm = value; }
        public int OyunSuresi { get => oyunSuresi; set => oyunSuresi = value; }
        public static int Puan { get => puan; set => puan = value; }

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
            Console.WriteLine("oyun basladi");//Silinecek

            sw.Start(); // stopwatch basladi
            
            myTimer = new Timer(1000);
            if (sw.Elapsed.Seconds < OyunSuresi)
                myTimer.Elapsed += OyunDongusu;
            myTimer.AutoReset = true;
            myTimer.Enabled = true;

        }

        private void OyunDongusu(Object source, ElapsedEventArgs e)
        {
            if (sw.Elapsed.Seconds < OyunSuresi)
            {
                hunterForm.sureAl(OyunSuresi - sw.Elapsed.Seconds);
                Console.WriteLine(sw.Elapsed.Seconds);
            }

            if (sw.Elapsed.Seconds >= OyunSuresi)
            {
                sw.Stop();
                this.Bitir();
            }
        }

        public void Bitir()
        {
            Console.WriteLine("oyun bitti");//Silinecek form MessageBox ile cikti eklenecek
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
