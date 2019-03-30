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
    public partial class Form1 : Form
    {
        public Form1()
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            InitializeComponent();
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Baslat_Click(object sender, EventArgs e)
        {
            if(KolayButton.Checked==true)
            {
                HunterTheWord oyunForm = new HunterTheWord();
                oyunForm.Show();
            }
            else if(OrtaButton.Checked==true)
            {
                HunterTheWord oyunForm = new HunterTheWord();
                oyunForm.Show();
            }
            else
            {
                HunterTheWord oyunForm = new HunterTheWord();
                oyunForm.Show();
            }
        }
    }
}
