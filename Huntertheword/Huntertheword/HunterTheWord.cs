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
        private bool girdiDogruMu;
        private Label labelDeneme = new Label();
        private Sozcuk AIyeSozcukTurunuGonderici;
        private int kalansure;

        public Label LabelDeneme { get => labelDeneme; set => labelDeneme = value; }
        public Sozcuk AIyeSozcukTurunuGonderici_ { get => AIyeSozcukTurunuGonderici; set => AIyeSozcukTurunuGonderici = value; }
        public int Kalansure { get => kalansure; set => kalansure = value; }

        public HunterTheWord()
        {
            InitializeComponent();
            SkorSayı.Text = Oyun.Puan.ToString();
        }


        private void kontrolEt_Click(object sender, EventArgs e)
        {

            Oyun.MyTimer.Start();
            girdiDogruMu = Oyuncu.KullanicidanGirdiAl(kelimeGirisi.Text, AIyeSozcukTurunuGonderici_);

            if (girdiDogruMu == true)
                TepkiVer();
            else
                MessageBox.Show("Hatalı Giriş!");

        }

        private void TepkiVer()
        {
            if (AI.DogruCevapSorgusu == true)
            {
                MessageBox.Show("Bildin!");
                Oyun.Puan += 10;
                SkorSayı.Text = Oyun.Puan.ToString();
            }
            else if (AI.DogruCevapSorgusu == false)
            {
                if (AI.Tutulanlar.Length != 0)
                {
                    string toDisplay = string.Join(",", AI.Tutulanlar);
                    MessageBox.Show("Bilemedin. Tutturduğun harfler: " + toDisplay);
                }
                else
                    MessageBox.Show("Eşleşen harf yok, tekrar dene!");
            }

            if (AI.KelimeSayaci == 10)
            {
                MessageBox.Show("Tüm kelimeleri bildin, tebrikler!");
            }
        }
        public void sureAl(int sure)
        {
            //sureLabel.Text = sure.ToString();
            //sure gönder metodu

            //hunterFrom başa bir threadte çalıştığı için invoke metodu ile labelımızı başka threadlerden 
            //editlenebilir yapıyoruz. çözüme ulaştığım kaynak:
            //https://social.msdn.microsoft.com/Forums/vstudio/en-US/a83a8655-76b8-4225-b38d-3b33eb67aafc/c-threading-changing-label?forum=csharpgeneral
            if (sureLabel.InvokeRequired)
            {
                sureLabel.Invoke((MethodInvoker)delegate () { sureLabel.Text = sure.ToString(); });
            }
            else
            {
                sureLabel.Text = sure.ToString();
            }

            if (Oyun.OyunSuresi == 0)
            {
                MessageBox.Show("Oyunun süresi Bitti");
                Application.Exit();
            }
        }

    }
}
