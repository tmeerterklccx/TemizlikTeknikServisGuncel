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
            UrunCMD.Parameters.AddWithValue("@UrunID", txtID.Text);
            UrunCMD.Parameters.AddWithValue("@UrunAd", txtUrunAd.Text);
            UrunCMD.Parameters.AddWithValue("@UrunBilgi", txtBilgi.Text);
            UrunCMD.Parameters.AddWithValue("@Marka_ID", markaCB.SelectedIndex);
            UrunCMD.Parameters.AddWithValue("@Urun_Tur_ID", TurCB.SelectedIndex);
            UrunCMD.Parameters.AddWithValue("@Uretim_Yili", txtYil.Text);
            UrunCMD.Parameters.AddWithValue("@Urun_Satis_Fiyati", txtFiyat.Text);
            UrunCMD.Parameters.AddWithValue("@Urun_Alis_Fiyati", txtAlisFiyati.Text);
            UrunCMD.Parameters.AddWithValue("@Urun_KDV_Orani", txtKdv.Text);
            UrunCMD.Parameters.AddWithValue("@Urun_Stok", txtStok.Text);
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
                markaCB.Items.Clear();

                foreach (DataRow row in dataTable.Rows)
                {
                    string markaAd = row["Marka_Ad"].ToString();
                    markaCB.Items.Add(markaAd);
                }
                if (markaCB.Items.Count > 0)
                {
                    markaCB.SelectedIndex = 0;
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
                TurCB.Items.Clear();

                foreach (DataRow row in dataTable.Rows)
                {
                    string markaAd = row["Tur_Adi"].ToString();
                    TurCB.Items.Add(markaAd);
                }
                if (TurCB.Items.Count > 0)
                {
                    TurCB.SelectedIndex = 0;
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
    }
}
