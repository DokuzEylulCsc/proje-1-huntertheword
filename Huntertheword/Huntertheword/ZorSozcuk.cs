using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Huntertheword
{
    class ZorSozcuk : Sozcuk
    {
        string[] zor =
    {
            "ikon",
            "püre",
            "süre",
            "apse",
            "çıra",
            "aşçı",
            "ekşi",
            "şike",//8 tane 4 harfli
            "çarşı",
            "beton",
            "çinko",
            "süper",
            "soylu",
            "aile",
            "reji",
            "buhar",
            "kefen",
            "yemiş",
            "dekor",
            "kirve",//12 tane 5 harfli
            "bayram",
            "yarğıç",
            "alerji",
            "şalvar",
            "yoksul",
            "kadran",
            "kafiye",
            "kafein",
            "absürt",
            "adliye",
            "acente",
            "aforoz",
            "içerik",
            "buhran",
            "künefe",
            "orkide",
            "ketçap",
            "başlık",
            "temsil",
            "teslim",
            "paydos",
            "balkon",//22 tane 6 harfli
            "kadayıf",
            "kadırga",
            "akrobat",
            "altıgen",
            "anatomi",
            "arabesk",
            "asosyal",
            "avokado",//8 tane 7 harfli
        };

        public override string[] kelimeGetir()
        {
            string[] secilenKelimeler = new string[10];

            Random random = new Random();
            List<int> randomNumbers = new List<int>();
            int number;


            for (int i = 0; i < 10; i++)
            {
                do
                {
                    number = random.Next(0, 50);
                } while (randomNumbers.Contains(number));

                randomNumbers.Add(number);
                secilenKelimeler[i] = zor[number];
            }

            return secilenKelimeler;
        }
    }
}
