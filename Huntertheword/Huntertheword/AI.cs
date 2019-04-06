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

        public static string[] kelimeSun(Sozcuk sozcuk)
        {
            return sozcuk.kelimeGetir();
        }

        public static void TahmineCevapVer(string kullaniciTahmini, Sozcuk sozcuk)
        {
            foreach ( var element in kelimeSun(sozcuk))
            {
                Console.WriteLine(element);
            }

            //if(kullaniciTahmini == AI'in tuttugu)
            //        Console.WriteLine("bildin");
        }
    }
}
