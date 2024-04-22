using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TemizlikTeknikServisGuncel.Musteri_Takibi;
using TemizlikTeknikServisGuncel.Sigorta_Takibi;

namespace TemizlikTeknikServisGuncel
{
    public partial class Otomasyon : Form
    {
        public Form1 afrm;
        public Otomasyon()
        {
            InitializeComponent();
        }
        public Otomasyon(string ad)
        {

        }

        private void uyelikToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ıconButton1_Click(object sender, EventArgs e)
        {
            Urunler urunler = new Urunler();
            urunler.Show();
            this.Close();
        }

        private void ıconButton2_Click(object sender, EventArgs e)
        {
            UrunTurleri urunTurleri = new UrunTurleri();
            urunTurleri.Show();
            this.Close();
        }

        private void ıconButton4_Click(object sender, EventArgs e)
        {
            Personeller personeller = new Personeller();
            personeller.Show();
            this.Close();
        }

        private void ıconButton5_Click(object sender, EventArgs e)
        {
            Izinler ızinler = new Izinler();
            ızinler.Show();
            this.Close();
        }

        private void ıconButton3_Click(object sender, EventArgs e)
        {
            Bakimlar bakimlar = new Bakimlar();
            bakimlar.Show();
            this.Close();
        }

        private void ıconButton8_Click(object sender, EventArgs e)
        {
            Musteriler musteriler = new Musteriler();
            musteriler.Show();
            this.Close();
        }

        private void ıconButton6_Click(object sender, EventArgs e)
        {

            Markalar markalar = new Markalar();
            markalar.Show();
            this.Close();
        }

        private void ıconButton7_Click(object sender, EventArgs e)
        {
            Sigortalar sigortalar = new Sigortalar();
            sigortalar.Show();
            this.Close();
        }

        private void Otomasyon_Load(object sender, EventArgs e)
        {

        }
    }
}
