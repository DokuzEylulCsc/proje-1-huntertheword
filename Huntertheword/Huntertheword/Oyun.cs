using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Huntertheword
{
    class Oyun
    {
        private int zorluk;
        private Random ihtimal = new Random();
        private int[] getir = new int[10];
        private Sozcuk sozcuk;

        public int Zorluk { get => zorluk; set => zorluk = value; }
        public Random Ihtimal { get => ihtimal; set => ihtimal = value; }
        public int[] Getir { get => getir; set => getir = value; }
        internal Sozcuk Sozcuk { get => sozcuk; set => sozcuk = value; }

        public void Baslat()
        {
            for(int i=0;i<10;i++)
            {
                Getir[i] = Ihtimal.Next(1, 51);
            }
            //int rastgeleSozcukler = Ihtimal.Next(1, 51);
        }
    }
}
