using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Huntertheword
{
    public  class Sozcuk
    {
        private int harfSayisi;

        public void deneme(string zorlukDerecesi)
        {
            //form sayfasından gelen bilgiyle hangi sozcuk clasndan verileri çekecegimize karar verdirdim(kolaySozcuk,OrtaSozcuk,ZorSozcuk)
            if(zorlukDerecesi=="kolay")
            {
                KolaySozcuk basla = new KolaySozcuk();
                basla.kelimeler();
            }
            else if(zorlukDerecesi=="orta")
            {
                OrtaSozcuk basla = new OrtaSozcuk();
                basla.kelimeler();

            }
            else
            {
                ZorSozcuk basla = new ZorSozcuk();
                basla.kelimeler();

            }
        }
    }
}
