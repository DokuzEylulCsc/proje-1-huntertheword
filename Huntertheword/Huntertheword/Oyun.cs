using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Huntertheword
{
    public class Oyun
    {
        private Sozcuk sozcukhaznem;

        public Sozcuk SozcukHaznem { get => sozcukhaznem; set => sozcukhaznem = value; }

        //Oyun sınıfı ise oyunu başlatma ve bitirme görevlerini yerine getirecektir.
        public Oyun(string zorluk)
        {
            if (zorluk == "kolay")
                this.SozcukHaznem = new KolaySozcuk();
            else if (zorluk == "orta")
                this.SozcukHaznem = new OrtaSozcuk();
            else if (zorluk == "zor")
                this.SozcukHaznem = new ZorSozcuk();
        }

        public void Baslat()
        {
            //string[] oyunKelimeleri = new string[1];
            //HunterTheWord formaGonder = new HunterTheWord();
            //formaGonder.Show();
            //formaGonder.kelimeleriGoster(oyunKelimeleri);
        }

        public void Bitir()
        {

        }

        public void Dongu()
        {

        }
    }
}
