using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Huntertheword
{
    class KolaySozcuk:Sozcuk
    {
        
        public void  kelimeler()
        {
            Random kelimeleriSec = new Random();
            int[] randomSayilar = new int[10];//randomdan gelen sayılar aynı olmasın diye gelen sayıları dizide tutuyoruz.
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
            Oyun kolayOyun = new Oyun();
            int i = 0,denetleme;
            string[] secilenKelimeler = new string[10];
            while(i<10)
            {
                denetleme = kelimeleriSec.Next(51);
                if (randomSayilar.Contains(denetleme)==false)//sayılar farklı olsun deyi contains metodunu kullandım(false ise farklı)
                {
                    secilenKelimeler[i] = kolay[denetleme];//secilen kelimeleri yerleştirdik
                }

                
                i++;
            }
    
           kolayOyun.Baslat(secilenKelimeler);//Oyun clasına kelimelerimizi gönderdik
            
        }
    }
}
