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
    public partial class UrunKaydet : Form
    {
        public UrunKaydet()
        {
            InitializeComponent();
        }

        private void otomasyonaGitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Otomasyon otomasyon = new Otomasyon();
            otomasyon.Show();
        }
    }
}
