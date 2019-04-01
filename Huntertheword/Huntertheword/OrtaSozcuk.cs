using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Huntertheword
{
    class OrtaSozcuk
    {
        public void kelimeler()
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
            Random kelimeleriSec = new Random();
            int[] randomSayilar = new int[10];//randomdan gelen sayılar aynı olmasın diye gelen sayıları dizide tutuyoruz.
            Oyun ortaOyun = new Oyun();
            int i = 0, denetleme;
            string[] secilenKelimeler = new string[10];
            while (i < 10)
            {
                denetleme = kelimeleriSec.Next(51);
                if (randomSayilar.Contains(denetleme) == false)//sayılar farklı olsun deyi contains metodunu kullandım(false ise farklı)
                {
                    secilenKelimeler[i] = orta[denetleme];//secilen kelimeleri yerleştirdik
                }


                i++;
            }

            ortaOyun.Baslat(secilenKelimeler);//Oyun clasına kelimelerimizi gönderdik
        }
        
    }
}
