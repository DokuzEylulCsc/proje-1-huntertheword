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
            "atatürk",
            "sütlaç",
            "niçin",
            "sivrisinek",
            "kuşburnu",
            "aslanağzı",
            "gecekondu",
            "uyurgezer",
            "mirasyedi",
            "biçerdöver",
            "başmüdür",
            "boşboğaz",
            "yurtsever",
            "canciğer",
            "demirbaş",
            "cumartesi",
            "afyonkarahisar",
            "öğretmenevi",
            "kaynana",
            "emretmek",
            "hissetmek",
            "affetmek",
            "akciğer",
            "keçiboynuzu",
            "başbakan ",
            "ateşkes",
            "çekyat",
            "bilgisayar",
            "ağaçkakan",
            "hacıyatmaz",
            "güngörmüş",
            "çıtkırıldım",
            "imambayıldı",
            "huzurevi",
            "beyanname",
            "zannetmek",
            "hapsetmek",
            "külbastı",
            "yapıvermek",
            "gidedurmak",
            "düşeyazmak",
            "dershane",
            "hastane",
            "azledilmek",
            "hükmetmek",
            "karmakarışık",
            "bahşetmek",
            "akşamüzeri",
            "suçüstü",
            "kahvehane",
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
