using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Huntertheword
{
    class Tahmin // interface kullanilabilir
    {
        private char[] tahmin;
        private int tahminSayisi;
        private DateTime tahminBaslangic;
        private DateTime tahminBitis;
        private int[] alfabeSayac;

        Tahmin()
        {
            for (int i = 0; i < 28; i++)
                alfabeSayac[i] = 0;
        }

        public void GecersizTahmin() // exc handling eklenecek
        {
            try
            {
                
            }
            catch
            {

            }
        }
    }
}
