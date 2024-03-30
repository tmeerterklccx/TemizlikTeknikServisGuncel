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
    public partial class Pozisyonlar : Form
    {
        public Pozisyonlar()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            PozisyonEkle pozisyonEkle = new PozisyonEkle();
            pozisyonEkle.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PozisyonGuncelle pozisyonGuncelle = new PozisyonGuncelle();
            pozisyonGuncelle.Show();
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
