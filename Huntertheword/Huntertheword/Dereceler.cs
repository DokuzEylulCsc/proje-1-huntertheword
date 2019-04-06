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
    public partial class Dereceler : Form
    {
        public Dereceler()
        {
            InitializeComponent();
        }

        private void buton_cikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Dereceler_Load(object sender, EventArgs e)
        {
            Kaydedici kayit = new Kaydedici();
            richTextBox_Dereceler.Text = kayit.dosyaOku();
        }
    }
}