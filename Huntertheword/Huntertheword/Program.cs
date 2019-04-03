using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Huntertheword
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Oyun oyun1 = new Oyun("orta");
            oyun1.Baslat();
            for(int i = 0; i < oyun1.SozcukHaznem.kelimeGetir().Length; i++)
            {
                Console.WriteLine(oyun1.SozcukHaznem.kelimeGetir()[i]);
            }


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
