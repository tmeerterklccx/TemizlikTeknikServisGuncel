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
    public partial class IzinEkle : Form
    {
        SqlConnection SqlConnection = new SqlConnection(SQLBaglanti.BaglantiCumlesiGonder());
        SqlCommand izinCMD = new SqlCommand();
        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
        public void KomutCalistir(string sorgu)
        {
            try
            {
                SqlConnection.Open();
                izinCMD.CommandText = sorgu;
                izinCMD.Connection = SqlConnection;
                izinCMD.ExecuteNonQuery();
                MessageBox.Show("Başarıyla Eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                if (izinCMD.Parameters.Count > 0)
                {
                    izinCMD.Parameters.Clear();
                }
                SqlConnection.Close();
            }
        }
        public IzinEkle()
        {
            InitializeComponent();
        }

        private void otomasyonaGitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Otomasyon otomasyon = new Otomasyon();
            otomasyon.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sorgu = "Insert Into Izinler values (@PersonelTC,@Baslangic,@Bitis,@Tur,@Statu)";
            izinCMD.Parameters.AddWithValue("@PersonelTC", textBox2.Text);
            izinCMD.Parameters.AddWithValue("@Baslangic", baslangic.Text);
            izinCMD.Parameters.AddWithValue("@Bitis", bitis.Text);
            izinCMD.Parameters.AddWithValue("@Tur", textBox1.Text);
            izinCMD.Parameters.AddWithValue("@Statu", true);
            KomutCalistir(sorgu);
            Izinler izinler = new Izinler();
            izinler.Show();
            this.Close();
        }

        private void IzinEkle_Load(object sender, EventArgs e)
        {

        }
    }
}
