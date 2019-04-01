using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Huntertheword
{
    class Oyun
    {
      
        public void Baslat(string[] oyunKelimeleri)
        {
            HunterTheWord formaGonder = new HunterTheWord();
            formaGonder.kelimeleriGöster(oyunKelimeleri);
        }
    }
}
