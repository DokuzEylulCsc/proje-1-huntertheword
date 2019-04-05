using System;
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
            Application.Run(new Form1()); 

        }
    }
}
