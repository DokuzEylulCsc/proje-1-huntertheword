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
        "çaycı",
        "bencil",
        "yavrucak",
        "kuzucuk",
        "uzunca",
        "vatandaş",
        "geceleyin",
        "güneşli",
        "kömürlük",
        "iyimser",
        "çamurumsu",
        "sarımtırak",
        "ellinci",
        "dokuzar",
        "tutsak",
        "geleneksel",
        "çocuksu",
        "tuzsuz",
        "kanamak",
        "benimsemek",
        "düzelmek",
        "taşlamak",
        "umutlanmak",
        "iyileşmek",
        "garipsemek",
        "içecek",
        "çizelge",
        "basamak",
        "gelenek",
        "gülücük",
        "bölge",
        "süzgeç",
        "saygı",
        "yangın",
        "bulaşıcı",
        "soluk",
        "bilmece",
        "göçmen",
        "görüntü",
        "çöküş",
        "boğulmak",
        "doyurmak",
        "çarpışmak",
        "simitçi",
        "giyeceksiz",
        "bildirge",
        "işlevsellik",
        "dondurmacı",
        "bilgilendirmek",
        "başlangıç",
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
