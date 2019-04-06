using System;

namespace Huntertheword
{
    public class Oyun
    {
        private Sozcuk sozcukhaznem;
        /*
         *oyun suresi simdilik 60 sn 
         * AYŞE=> timerı forma aldım. Buraya 1 adet static metod ekledim. süre dolduğunda bu metodu çağırıyorum.
         * 
        */
        private int oyunSuresi;

        private HunterTheWord hunterForm; // Form

        public Sozcuk SozcukHaznem { get => sozcukhaznem; set => sozcukhaznem = value; }
        public int OyunSuresi { get => oyunSuresi; set => oyunSuresi = value; }

        //Oyun sınıfı ise oyunu başlatma ve bitirme görevlerini yerine getirecektir.
        public Oyun(int zorluk)
        {
            if (zorluk == 1)
                this.SozcukHaznem = new KolaySozcuk();
            else if (zorluk == 2)
                this.SozcukHaznem = new OrtaSozcuk();
            else if (zorluk == 3)
                this.SozcukHaznem = new ZorSozcuk();
            hunterForm = new HunterTheWord(this);
            /*
            oyun formuna Oyun nesnesinin referansını gönderiyoruz. bu şekilde oyun ekranından
            oyun nesnesine erişebiliyoruz.
            */
            Baslat();
        }

        private void Baslat()
        {
            hunterForm.Show();
        }

        public void sureBitti()
        {
            //bu metodu süre bittiğinde çağrıyorum. gereksiz görünürse bu metod silinebilir.
        }


        public void Bitir()
        {
            Kaydedici kayit = new Kaydedici();
            kayit.dosyayaYaz(50, 60);// kaydediciye skor ve süre gidecek
            Console.WriteLine("oyun bitti");
        }

    }
}
