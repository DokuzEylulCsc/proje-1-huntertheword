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
        private static void dosyayaYaz()
        {
            string dosya_yolu = @"C:\Dereceler.txt";
           
            FileStream fs = new FileStream(dosya_yolu, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);



            sw.Flush();           
            sw.Close();
            fs.Close();
        }
    }
}
