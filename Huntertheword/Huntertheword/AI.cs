using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Huntertheword
{
    //AI sınıfı sözcük seçme, Oyuncunun sınıfının örneklerinden gelecek tahminlere cevap verme gibi görevleri yerine getirecektir.
    public static class AI
    {
        private static int kelimeSayaci = -1;
        private static string[] rastgele = new string[10];
        private static bool dogruCevapSorgusu = false;
        private static char[] tutulanlar;

        public static int KelimeSayaci { get => kelimeSayaci; set => kelimeSayaci = value; }
        public static string[] Rastgele { get => rastgele; set => rastgele = value; }
        public static bool DogruCevapSorgusu { get => dogruCevapSorgusu; set => dogruCevapSorgusu = value; }
        public static char[] Tutulanlar { get => tutulanlar; set => tutulanlar = value; }

        public static string[] kelimeSun(Sozcuk sozcuk)
        {
            return sozcuk.kelimeGetir();
        }

        public static void TahmineCevapVer(string kullaniciTahmini, Sozcuk sozcuk)
        {
            if (KelimeSayaci == -1) // kelimesayaci = -1 => yani bir kez rastgele alsin, aksi halde o kelimeleri kullansin.
            {
                Rastgele = kelimeSun(sozcuk);
                Rastgele = Rastgele.OrderBy(eleman => eleman.Length).ToArray(); // kelimeler uzunluguna gore sirali gelsin.
                KelimeSayaci++;
            }

            if (KelimeSayaci < 10)
            {
                if (Rastgele[KelimeSayaci] == kullaniciTahmini)
                {
                    Console.WriteLine("bildin kelime şuydu: " + Rastgele[KelimeSayaci]);
                    KelimeSayaci++;
                    DogruCevapSorgusu = true;
                }
                else
                {
                    var tutulanKelime = Rastgele[KelimeSayaci].ToCharArray();
                    var tahminEdilenKelime = kullaniciTahmini.ToCharArray();

                    var ortakHarfler = tutulanKelime.Intersect(tahminEdilenKelime);
                    Tutulanlar = ortakHarfler.ToArray();

                    Console.WriteLine("bilemedin kelime şuydu: " + Rastgele[KelimeSayaci] + " tahminin: " + kullaniciTahmini);
                    DogruCevapSorgusu = false;
                }
            }
            else if (KelimeSayaci == 10)
                Console.WriteLine("hepsini bildin");

        }
    }
}
