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
    public partial class UrunKaydet : Form
    {
        public Urunler afrm;
        SqlConnection SqlConnection = new SqlConnection(SQLBaglanti.BaglantiCumlesiGonder());
        SqlCommand UrunCMD = new SqlCommand();
        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
        public void KomutCalistir(string sorgu)
        {
            try
            {
                SqlConnection.Open();
                UrunCMD.CommandText = sorgu;
                UrunCMD.Connection = SqlConnection;
                UrunCMD.ExecuteNonQuery();
                MessageBox.Show("Başarıyla Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                if (UrunCMD.Parameters.Count > 0)
                {
                    UrunCMD.Parameters.Clear();
                }
                SqlConnection.Close();
            }
        }
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

        private void button1_Click(object sender, EventArgs e)
        {
            string sorgu = "Insert Into Urunler values (@MarkaAd)";
            UrunCMD.Parameters.AddWithValue("@MarkaAd", textBox1.Text);
            UrunCMD.Parameters.AddWithValue("@MarkaAd", textBox1.Text);
            UrunCMD.Parameters.AddWithValue("@MarkaAd", textBox1.Text);
            UrunCMD.Parameters.AddWithValue("@MarkaAd", textBox1.Text);
            UrunCMD.Parameters.AddWithValue("@MarkaAd", textBox1.Text);
            UrunCMD.Parameters.AddWithValue("@MarkaAd", textBox1.Text);
            UrunCMD.Parameters.AddWithValue("@MarkaAd", textBox1.Text);
            UrunCMD.Parameters.AddWithValue("@MarkaAd", textBox1.Text);
            UrunCMD.Parameters.AddWithValue("@MarkaAd", textBox1.Text);
            UrunCMD.Parameters.AddWithValue("@MarkaAd", textBox1.Text);
            KomutCalistir(sorgu);
            Urunler urunler = new Urunler();
            urunler.Show();
            this.Close();
        }
    }
}
