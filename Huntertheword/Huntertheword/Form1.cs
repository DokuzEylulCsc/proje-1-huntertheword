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

        private void  Baslat_Click(object sender, EventArgs e)
        {
            Sozcuk derece = new Sozcuk();
            // radio butonunda seçilen zorluk derecesine göre sozcuk clasına zorluk derecesini yönlendirdim.
            if (KolayButton.Checked==true)
            {
                
                HunterTheWord oyunForm = new HunterTheWord();
                derece.deneme("kolay");
                oyunForm.Show();
              
            }
            else if(OrtaButton.Checked==true)
            {
                HunterTheWord oyunForm = new HunterTheWord();
                derece.deneme("orta");
                oyunForm.Show();
            }
            else
            {
                HunterTheWord oyunForm = new HunterTheWord();
                derece.deneme("zor");
                oyunForm.Show();
            }
        }

        private void bilgiButonu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Oyun 3 derece zorluktan oluşur." +
                "Her oyun için 10 kelime önünüze çıkacak ve her kelime için 10 hakkınız olacak." +
                "Her doğru cevabınızda 10 puan kazanacaksınız.");
        }
    }
}
