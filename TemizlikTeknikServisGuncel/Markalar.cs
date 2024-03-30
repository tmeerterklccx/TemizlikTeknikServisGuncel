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
    public partial class Markalar : Form
    {
        public Markalar()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MarkaEkle markaEkle = new MarkaEkle();
            markaEkle.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MarkaGuncelle markaGuncelle = new MarkaGuncelle();
            markaGuncelle.Show();
            this.Close();
        }

        private void otomasyonaGitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Otomasyon otomasyon = new Otomasyon();
            otomasyon.Show();
            this.Close();
        }
    }
}
