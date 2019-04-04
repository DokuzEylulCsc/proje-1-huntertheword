using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Huntertheword
{
    class OrtaSozcuk : Sozcuk
    {
        string[] orta =
    {
            "kov",
            "düş",
            "süt",
            "yaz",
            "son",
            "sağ",
            "çek",
            "jet",
            "not",
            "oje",
            "kek",//11 tane 3 harfli         
            "kedi",
            "öğüt",
            "keçi",
            "bekçi",
            "yara",
            "ayar",
            "meze",
            "bira",
            "dart",
            "ölüm",
            "bölü",
            "duyu",
            "uydu",
            "onur",
            "soru",
            "baca",
            "kaba",//17 tane 4 harfli
            "radar",
            "yazar",
            "piyaz",
            "köpek",
            "bizon",
            "jeton",
            "soğan",
            "beyaz",
            "siyah",
            "söğüt",
            "bölüm",
            "duygu",
            "sorun",
            "bitki",
            "biber",
            "bacak",
            "hepsi",//17 tane 5 harfli
            "kabile",
            "yağmur",
            "rüzğar",
            "yaprak",
            "toprak",//5 tane 6 harfli
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
                secilenKelimeler[i] = orta[number];
            }

            return secilenKelimeler;
        }
    }
}
