using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemizlikTeknikServisGuncel
{
    public partial class Otomasyon : Form
    {
        public Otomasyon()
        {
            InitializeComponent();
        }

        private void uyelikToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Urunler urunler = new Urunler();
            urunler.Show();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Markalar markalar = new Markalar();
            markalar.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Personeller personeller = new Personeller();
            personeller.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Izinler ızinler = new Izinler();
            ızinler.Show();
            this.Close();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Pozisyonlar pozisyonlar = new Pozisyonlar();
            pozisyonlar.Show();
            this.Close();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            UrunTurleri urunTurleri = new UrunTurleri();
            urunTurleri.Show();
            this.Close();
        }
    }
}
