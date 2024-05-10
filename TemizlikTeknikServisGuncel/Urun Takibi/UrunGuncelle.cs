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
    public partial class UrunGuncelle : Form
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
                MessageBox.Show("Başarıyla Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        public UrunGuncelle()
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
            string sorgu = "Update Urunler set Urun_Ad,Urun_Bilgi,Marka_ID,Urun_Tur_ID,Uretim_Yili,Urun_Satis_Fiyati,Garanti_Suresi_Day,Urun_Alis_Fiyati,Urun_KDV_Orani,Urun_Stok = @UrunAd,@UrunBilgi,@MarkaID,@UrunTurID,@UretimYili,@UrunSatisFiyati,@GarantiSuresi,@UrunAlisFiyati,@UrunKDVOrani,@UrunStok WHERE Urun_ID = @UrunID";
            UrunCMD.Parameters.AddWithValue("@UrunID", IDTBox.Text);
            UrunCMD.Parameters.AddWithValue("@UrunAd", urunAdiTBox.Text);
            UrunCMD.Parameters.AddWithValue("@UrunBilgi", bilgiTBox.Text);
            UrunCMD.Parameters.AddWithValue("@Marka_ID", markaCBox.SelectedIndex);
            UrunCMD.Parameters.AddWithValue("@Urun_Tur_ID", turCBox.SelectedIndex);
            UrunCMD.Parameters.AddWithValue("@Uretim_Yili", yilTBox.Text);
            KomutCalistir(sorgu);
            Urunler urunler = new Urunler();
            urunler.Show();
            this.Close();
        }

        private void UrunGuncelle_Load(object sender, EventArgs e)
        {
            MarkalariGetir();
            TurleriGetir();
        }
        private void MarkalariGetir()
        {
            UrunCMD.CommandText = "SELECT * FROM Markalar";
            UrunCMD.Connection = SqlConnection;

            try
            {
                SqlConnection.Open();

                SqlDataReader reader = UrunCMD.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                markaCBox.Items.Clear();

                foreach (DataRow row in dataTable.Rows)
                {
                    string markaAd = row["Marka_Ad"].ToString();
                    markaCBox.Items.Add(markaAd);
                }
                if (markaCBox.Items.Count > 0)
                {
                    markaCBox.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanı işlemi sırasında hata oluştu: " + ex.Message);
            }
            finally
            {
                SqlConnection.Close();
            }


        }
        private void TurleriGetir()
        {
            UrunCMD.CommandText = "SELECT * FROM Urun_Turleri";
            UrunCMD.Connection = SqlConnection;

            try
            {
                SqlConnection.Open();

                SqlDataReader reader = UrunCMD.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                turCBox.Items.Clear();

                foreach (DataRow row in dataTable.Rows)
                {
                    string markaAd = row["Tur_Adi"].ToString();
                    turCBox.Items.Add(markaAd);
                }
                if (turCBox.Items.Count > 0)
                {
                    turCBox.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanı işlemi sırasında hata oluştu: " + ex.Message);
            }
            finally
            {
                SqlConnection.Close();
            }


        }

        private void çıkışYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkış yapmak istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
