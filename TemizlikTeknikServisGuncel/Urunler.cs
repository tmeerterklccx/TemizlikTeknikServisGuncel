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
    public partial class Urunler : Form
    {
        public Urunler()
        {
            InitializeComponent();
        }

        private void Urunler_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            UrunKaydet urunKaydet = new UrunKaydet();
            urunKaydet.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            UrunGuncelle urunGuncelle = new UrunGuncelle();
            urunGuncelle.Show();

        }
    }
}
