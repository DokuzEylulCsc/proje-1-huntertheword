using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Huntertheword
{
    public class KolaySozcuk : Sozcuk
    {
        string[] kolay = {
                "ad",
                "at",
                "af",
                "ak",
                "aş",
                "ev",
                "iş",//7 tane 2 harfli
                "dua",
                "göl",
                "çam",
                "maç",
                "tuş",
                "çağ",
                "ilk",
                "son",
                "aşk",
                "cam",
                "tüm",
                "ana",
                "çin",
                "din",
                "ayı",
                "arı",
                "ray",
                "ada",
                "şut",
                "kaş",
                "tüm",
                "mit",
                "iki",
                "duy",
                "ölü",//23 tane 3 harfli
                "fare",
                "keçi",
                "adam",
                "dama",
                "kıta",
                "atık",
                "tren",
                "dinç",
                "ayıp",
                "ağaç",
                "maket",
                "rüya",
                "bina",
                "yapı",//14 tane 4 harfli
                "dünya",
                "meyve",
                "sebze",
                "çiçek",
                "deniz",
                "tatil",//6 tane 5 harfli
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
                secilenKelimeler[i] = kolay[number];
            }

            return secilenKelimeler;
        }
    }
}
