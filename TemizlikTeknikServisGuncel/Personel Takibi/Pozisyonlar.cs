using Microsoft.Data.SqlClient;
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
        SqlConnection SqlConnection = new SqlConnection(SQLBaglanti.BaglantiCumlesiGonder());
        public DataTable VeriDoldur(string sorgu)
        {
            DataTable tablo = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sorgu, SqlConnection);
            sqlDataAdapter.Fill(tablo);
            return tablo;
        }
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

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
