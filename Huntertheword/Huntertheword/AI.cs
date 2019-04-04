using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Huntertheword
{
    //AI sınıfı sözcük seçme, Oyuncunun sınıfının örneklerinden gelecek tahminlere cevap verme gibi görevleri yerine getirecektir.
    public class AI
    {
        public AI()
        {

        }

        public string[] kelimeSun(Sozcuk sozcuk)
        {
            return sozcuk.kelimeGetir();
        }

        public void tahminlereCevapVer()
        {

        }
    }
}
