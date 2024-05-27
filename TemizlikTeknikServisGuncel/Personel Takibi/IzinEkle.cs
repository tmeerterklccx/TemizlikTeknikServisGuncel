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
                if(SqlConnection.State != System.Data.ConnectionState.Open)
                {
                    SqlConnection.Open();
                }
               
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
        private void PersonelDoldur()
        {
            string sorgu = "SELECT Ad FROM Calisanlar";
            if (SqlConnection.State != ConnectionState.Open)
            {
                SqlConnection.Open();
            }

            izinCMD.Connection = SqlConnection;
            izinCMD.Parameters.Clear();
            izinCMD.CommandText = sorgu;
            SqlDataReader sqlDataReader = izinCMD.ExecuteReader();
            while (sqlDataReader.Read())
            {
                List<string> personelAdListesi = new List<string>();
                string personelAdi = sqlDataReader["Ad"].ToString();
                if (personelAdi != null)
                {
                    personelAdListesi.Add(personelAdi);
                }

                foreach (var item in personelAdListesi)
                {
                    personelCBox.Items.Add(item);
                }
            }
            SqlConnection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(SqlConnection.State != ConnectionState.Open)
            {
                SqlConnection.Open();
            }
            string secilenPersonelAdi = personelCBox.SelectedItem.ToString();
            string personelTCSorgusu = "SELECT TC FROM Calisanlar WHERE Ad = @PersonelAd";
            izinCMD.Parameters.Clear();
            izinCMD.CommandText = personelTCSorgusu;
            izinCMD.Parameters.AddWithValue("@PersonelAd", secilenPersonelAdi);
            string personelTC = izinCMD.ExecuteScalar().ToString();

            string sorgu = "Insert Into Izinler values (@PersonelTC,@Baslangic,@Bitis,@Tur,@Statu)";
            izinCMD.Parameters.AddWithValue("@PersonelTC", personelTC);
            izinCMD.Parameters.AddWithValue("@Baslangic", BaslangicTBox.Text);
            izinCMD.Parameters.AddWithValue("@Bitis", BitisTBox.Text);
            izinCMD.Parameters.AddWithValue("@Tur", TurTBox.Text);
            izinCMD.Parameters.AddWithValue("@Statu", true);
            KomutCalistir(sorgu);
            Izinler izinler = new Izinler();
            izinler.Show();
            this.Close();
        }

        private void IzinEkle_Load(object sender, EventArgs e)
        {
            PersonelDoldur();
        }

        private void çıkışYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkış yapmak istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tcBox_Click(object sender, EventArgs e)
        {

        }

        private void tcBox_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
