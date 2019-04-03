using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Huntertheword
{
    public partial class HunterTheWord : Form
    {
        public HunterTheWord()
        {
            InitializeComponent();
        }

        private void kontrolEt_Click(object sender, EventArgs e)
        {
            
        }

        public void kelimeleriGoster(string[] oyunKelimeleri)
        {
            //MessageBox.Show("geldim buradayım");
            for (int i = 0; i <oyunKelimeleri.Length; i++)
             {
                 listBox1.Items.Add(oyunKelimeleri[i]);
             }
        }
    }
}
