using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Huntertheword
{
    static class Tahmin // interface kullanilabilir
    {

        public static bool girdiDogruMu(string kullaniciTahmin, int tahminUzunluk) // exc handling eklenecek
        {
            if (kullaniciTahmin.Length == 0 || kullaniciTahmin.Length != tahminUzunluk)
                return false;

            if (kullaniciTahmin.IndexOfAny("xqwQWX1234567890".ToCharArray()) != -1)
                return false;

            char[] tahmin = kullaniciTahmin.ToCharArray();
            for (int i = 0; i < tahmin.Length; i++)
            {
                if (!Char.IsLetterOrDigit(tahmin[i]))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
