﻿using System;
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
        }


        private void kontrolEt_Click(object sender, EventArgs e)
        {
            /*
             * burdaki 3 şu anki tahminin olması gereken uzunluk bunu bir sayaç yardımıyla ilerletmemiz lazım
             * şimdilik 3 olarak yazdım.
             */
            girdiDogruMu = Oyuncu.KullanicidanGirdiAl(kelimeGirisi.Text, 3, this.AIyeSozcukTurunuGonderici_);
            Console.WriteLine("girdi: " + girdiDogruMu);
            TepkiVer();
        }

        private void TepkiVer()
        {
            /*
             * girdi kontrolü yapıldıktan sonra kullanıcıya görsel olarak tepki verilmesi gerekiyor. 
             * Bu metodu temp olarak açtım değiştirilebilir.
             */
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
                sureLabel.Invoke((MethodInvoker)delegate() { sureLabel.Text = sure.ToString(); });
            }
            else
            {
                sureLabel.Text = sure.ToString();
            }

        }
    }
}
