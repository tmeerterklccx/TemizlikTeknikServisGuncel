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
                if(SqlConnection.State != ConnectionState.Open)
                {
                    SqlConnection.Open();
                }
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

        private void ComboboxaTurGotur()
        {
            UrunGuncelle urunGuncelle = new UrunGuncelle();
            string sorgu5 = "SELECT Tur_Adi FROM Urun_Turleri WHERE Tur_ID = @turid";
            if (SqlConnection.State != ConnectionState.Open)
            {
                SqlConnection.Open();
            }
            UrunCMD.Parameters.Clear();
            UrunCMD.Connection = SqlConnection;
            UrunCMD.CommandText = sorgu5;
            UrunCMD.Parameters.AddWithValue("@turid", turid.Text);
            SqlDataReader sqlDataReader = UrunCMD.ExecuteReader();
            if (sqlDataReader.Read())
            {
                string turAdi = sqlDataReader["Tur_Adi"].ToString();
                if (turAdi.Trim() != "")
                {
                    turCBox.SelectedItem = turAdi;
                }
                else
                {
                    MessageBox.Show("Veri boş.");
                }

            }
            else
            {
                urunGuncelle.turCBox.Text = "404";
            }
            SqlConnection.Close();
        }
        private void ComboboxaMarkaGotur()
        {
            UrunGuncelle urunGuncelle = new UrunGuncelle();
            string sorgu5 = "SELECT Marka_Ad FROM Markalar WHERE Marka_ID = @Marka_ID";
            if (SqlConnection.State != ConnectionState.Open)
            {
                SqlConnection.Open();
            }
            UrunCMD.Parameters.Clear();
            UrunCMD.Connection = SqlConnection;
            UrunCMD.CommandText = sorgu5;
            UrunCMD.Parameters.AddWithValue("@Marka_ID", markaidd.Text);
            SqlDataReader sqlDataReader = UrunCMD.ExecuteReader();
            if (sqlDataReader.Read())
            {
                string turAdi = sqlDataReader["Marka_Ad"].ToString();
                if (turAdi.Trim() != "")
                {
                    markaCBox.SelectedItem = turAdi;
                }
                else
                {
                    MessageBox.Show("Veri boş.");
                }

            }
            else
            {
                urunGuncelle.turCBox.Text = "404";
            }
            SqlConnection.Close();
        }
        private void button1_Click(object sender, EventArgs e)
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

            string sorgu = "Update Urunler set Urun_Ad,Urun_Bilgi,Marka_ID,Urun_Tur_ID,Uretim_Yili,Urun_Satis_Fiyati,Garanti_Suresi_Day,Urun_Alis_Fiyati,Urun_KDV_Orani,Urun_Stok = @UrunAd,@UrunBilgi,@MarkaID,@UrunTurID,@UretimYili,@UrunSatisFiyati,@GarantiSuresi,@UrunAlisFiyati,@UrunKDVOrani,@UrunStok WHERE Urun_ID = @UrunID";
            UrunCMD.Parameters.AddWithValue("@UrunID", IDTBox.Text);
            UrunCMD.Parameters.AddWithValue("@UrunAd", urunAdiTBox.Text);
            UrunCMD.Parameters.AddWithValue("@UrunBilgi", bilgiTBox.Text);
            UrunCMD.Parameters.AddWithValue("@Marka_ID", markaID);
            UrunCMD.Parameters.AddWithValue("@Urun_Tur_ID", turID);
            UrunCMD.Parameters.AddWithValue("@Uretim_Yili", yilTBox.Text);
            KomutCalistir(sorgu);
            SqlConnection.Close();
            Urunler urunler = new Urunler();
            urunler.Show();
            this.Close();
        }

        private void UrunGuncelle_Load(object sender, EventArgs e)
        {
            MarkalariGetir();
            TurleriGetir();
            ComboboxaMarkaGotur();
            ComboboxaTurGotur();
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
