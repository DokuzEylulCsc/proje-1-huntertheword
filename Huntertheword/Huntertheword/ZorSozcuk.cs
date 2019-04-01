using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Huntertheword
{
    class ZorSozcuk
    {
        public void kelimeler()
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
            Random kelimeleriSec = new Random();
            int[] randomSayilar = new int[10];//randomdan gelen sayılar aynı olmasın diye gelen sayıları dizide tutuyoruz.
            Oyun zorOyun = new Oyun();
            int i = 0, denetleme;
            string[] secilenKelimeler = new string[10];
            while (i < 10)
            {
                denetleme = kelimeleriSec.Next(51);
                if (randomSayilar.Contains(denetleme) == false)//sayılar farklı olsun deyi contains metodunu kullandım(false ise farklı)
                {
                    secilenKelimeler[i] = zor[denetleme];//secilen kelimeleri yerleştirdik
                }

                i++;
            }

            zorOyun.Baslat(secilenKelimeler);//Oyun clasına kelimelerimizi gönderdik
        }
        
    }
}
