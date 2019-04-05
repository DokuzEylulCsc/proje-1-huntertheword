using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Huntertheword
{
    //Oyuncu sınıfı ise kullanıcıdan alacağı girdi ışığında AI ile iletişime geçerek kullanıcıdan aldığı bilgileri
    //AI sınıfına/nesnesine göndermek ve gelen sonuçları program kullanıcısına bildirmekle görevlidir.

    //skor ve can bilgisi property olarak eklenecek
    public static class Oyuncu
    {

        private static void TahminiYapayZekayaGonder(string kullaniciTahmini)
        {
            AI.TahmineCevapVer(kullaniciTahmini);
        }

        public static bool KullanicidanGirdiAl(string kullaniciTahmini, int tahminUzunlugu)
        {
            if (Tahmin.girdiDogruMu(kullaniciTahmini, tahminUzunlugu))
            {
                TahminiYapayZekayaGonder(kullaniciTahmini);
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
