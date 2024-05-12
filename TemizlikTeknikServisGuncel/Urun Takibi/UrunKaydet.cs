using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
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
                if (SqlConnection.State != ConnectionState.Open) { SqlConnection.Open(); }
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
        private void TurDoldur()
        {
            string sorgu = "SELECT Tur_Adi FROM Urun_Turleri";
            if (SqlConnection.State != ConnectionState.Open)
            {
                SqlConnection.Open();
            }
            UrunCMD.Connection = SqlConnection;
            UrunCMD.Parameters.Clear();
            UrunCMD.CommandText = sorgu;
            SqlDataReader sqlDataReader = UrunCMD.ExecuteReader();
            while (sqlDataReader.Read())
            {
                List<string> turAdlariListesi = new List<string>();
                string turAdi = sqlDataReader["Tur_Adi"].ToString();
                if (turAdi != null)
                {
                    turAdlariListesi.Add(turAdi);
                }

                foreach (var item in turAdlariListesi)
                {
                    turCBox.Items.Add(item);
                }
            }
            SqlConnection.Close();
        }
        private void MarkaDoldur()
        {
            string sorgu = "SELECT Marka_Ad FROM Markalar";
            if (SqlConnection.State != ConnectionState.Open)
            {
                SqlConnection.Open();
            }
            UrunCMD.Connection = SqlConnection;
            UrunCMD.Parameters.Clear();
            UrunCMD.CommandText = sorgu;
            SqlDataReader sqlDataReader = UrunCMD.ExecuteReader();
            while (sqlDataReader.Read())
            {
                List<string> markaAdlariListesi = new List<string>();
                string markaAdi = sqlDataReader["Marka_Ad"].ToString();
                if (markaAdi != null)
                {
                    markaAdlariListesi.Add(markaAdi);
                }

                foreach (var item in markaAdlariListesi)
                {
                    markaCBox.Items.Add(item);
                }
            }
            SqlConnection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection.Open();

                string secilenTurAdi = turCBox.SelectedItem.ToString();
                string urunIDSorgusu = "SELECT Tur_ID FROM Urun_Turleri WHERE Tur_Adi = @turAdi";
                UrunCMD.Parameters.Clear();
                UrunCMD.CommandText = urunIDSorgusu;
                UrunCMD.Connection = SqlConnection;
                UrunCMD.Parameters.AddWithValue("@turAdi", secilenTurAdi);
                int turID = (int)UrunCMD.ExecuteScalar();
                UrunCMD.Parameters.Clear();


                string secilenMarkaAdi = markaCBox.SelectedItem.ToString();
                string markaIDSorgusu = "SELECT Marka_ID FROM Markalar WHERE Marka_Ad = @markaAd";
                UrunCMD.Parameters.Clear();
                UrunCMD.Connection = SqlConnection;
                UrunCMD.CommandText = markaIDSorgusu;
                UrunCMD.Parameters.AddWithValue("@markaAd", secilenMarkaAdi);
                int markaID = (int)UrunCMD.ExecuteScalar();
                UrunCMD.Parameters.Clear();

                string sorgu = "Insert Into Urunler values (@Ad,@Bilgi,@Marka_ID,@Tur_ID,@Yil)";
                UrunCMD.Parameters.Clear();
                UrunCMD.Parameters.AddWithValue("@Ad", urunAdiTBox.Text);
                UrunCMD.Parameters.AddWithValue("@Bilgi", bilgiTBox.Text);
                UrunCMD.Parameters.AddWithValue("@Marka_ID", markaID);
                UrunCMD.Parameters.AddWithValue("@Tur_ID", turID);
                UrunCMD.Parameters.AddWithValue("@Yil", yilTBox.Text);

                KomutCalistir(sorgu);
                SqlConnection.Close();
                Urunler urunler = new Urunler();
                urunler.Show();
                this.Close();
            }
            catch
            (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void çıkışYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkış yapmak istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void UrunKaydet_Load(object sender, EventArgs e)
        {
            TurDoldur();
            MarkaDoldur();
        }
    }
}
