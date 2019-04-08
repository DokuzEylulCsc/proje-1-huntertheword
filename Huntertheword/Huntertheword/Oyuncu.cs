using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Huntertheword
{
    //Oyuncu sınıfı ise kullanıcıdan alacağı girdi ışığında AI ile iletişime geçerek kullanıcıdan aldığı bilgileri
    //AI sınıfına/nesnesine göndermek ve gelen sonuçları program kullanıcısına bildirmekle görevlidir.

    public static class Oyuncu
    {

        private static void TahminiYapayZekayaGonder(string kullaniciTahmini, Sozcuk sozcuk)
        {
            AI.TahmineCevapVer(kullaniciTahmini, sozcuk);
        }

        public static bool KullanicidanGirdiAl(string kullaniciTahmini, Sozcuk sozcuk) // girdi kontrolu
        {
            TahminiYapayZekayaGonder(kullaniciTahmini, sozcuk);

            if (kullaniciTahmini == "")
                return false;
            else return true;
        }
    }
}
