using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Huntertheword
{
    //Kaydedici sınıfı ise log ve istatistiklerden sorumlu olacaktır.
    class Kaydedici
    {
        public void dosyayaYaz(string oyuncuİsim,string oyunZorluk, int skor = 50, int sure = 60)
        {

            string dosya_yolu = @"Dereceler.txt";
            StreamWriter swrite = new StreamWriter(dosya_yolu, true);
            swrite.WriteLine($"Oyuncu:{oyuncuİsim}  Skor:{skor}       Kalan Süre: {sure}     Zorluk:{oyunZorluk} ");
            swrite.Close();
        }
        public string dosyaOku()
        {
            string veriler = string.Empty;
            try
            {
                veriler = File.ReadAllText("Dereceler.txt");
            }
            catch (Exception exp)
            {

                StreamWriter hata = new StreamWriter("Hatalar.txt", true);
                hata.WriteLine(exp.Message);
            }
            return veriler;
        }
    }
}