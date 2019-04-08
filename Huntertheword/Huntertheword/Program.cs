using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Huntertheword
{
    static class Program
    {
        //Programınızın giriş noktası olan Program sınıfındaki
        //Main metodu ise yalnızca Oyun sınıfının bir örneğine sahip olacaktır.

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1()); // ilk ekran, oyun zorluk secimi simdilik asagidaki sekilde secilsin

            Oyun oyun1 = new Oyun("zor");
            oyun1.Baslat();
            Application.Run(oyun1.GetirForm());
        }
    }
}
