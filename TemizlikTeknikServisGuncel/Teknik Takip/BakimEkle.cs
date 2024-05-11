using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace TemizlikTeknikServisGuncel
{
    public partial class BakimEkle : Form
    {
        public Bakimlar afrm;
        SqlConnection SqlConnection = new SqlConnection(SQLBaglanti.BaglantiCumlesiGonder());
        SqlCommand bakimCMD = new SqlCommand();
        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
        public void KomutCalistir(string sorgu)
        {
            try
            {
                SqlConnection.Open();
                bakimCMD.CommandText = sorgu;
                bakimCMD.Connection = SqlConnection;
                bakimCMD.ExecuteNonQuery();
                MessageBox.Show("Başarıyla Kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                if (bakimCMD.Parameters.Count > 0)
                {
                    bakimCMD.Parameters.Clear();
                }
                SqlConnection.Close();
            }
        }
        public BakimEkle()
        {
            InitializeComponent();
        }
        private void UrunDoldur()
        {
            string sorgu = "SELECT Urun_Ad FROM Urunler";
            if (SqlConnection.State != ConnectionState.Open)
            {
                SqlConnection.Open();
            }
            bakimCMD.Connection = SqlConnection;
            bakimCMD.Parameters.Clear();
            bakimCMD.CommandText = sorgu;
            SqlDataReader sqlDataReader = bakimCMD.ExecuteReader();

            List<string> urunAdListesi = new List<string>(); // Ürün adlarını tutmak için bir liste oluşturuldu

            while (sqlDataReader.Read())
            {
                string urunAdi = sqlDataReader["Urun_Ad"].ToString();
                urunAdListesi.Add(urunAdi); // Her bir ürün adını listeye ekleyin
            }

            // Döngü dışında, tüm ürün adlarını ComboBox'a ekleyin
            foreach (var item in urunAdListesi)
            {
                urunCBox.Items.Add(item);
            }
            SqlConnection.Close( );
        }
        private void MusteriDoldur()
        {
            string sorgu = "SELECT Ad FROM Musteriler";
            if (SqlConnection.State != ConnectionState.Open)
            {
                SqlConnection.Open();
            }
            bakimCMD.Connection = SqlConnection;
            bakimCMD.Parameters.Clear();
            bakimCMD.CommandText = sorgu;
            SqlDataReader sqlDataReader = bakimCMD.ExecuteReader();
            while (sqlDataReader.Read())
            {
                List<string> musteriAdListesi = new List<string>();
                string musteriAdi = sqlDataReader["Ad"].ToString();
                if (musteriAdi != null)
                {
                    musteriAdListesi.Add(musteriAdi);
                }

                foreach (var item in musteriAdListesi)
                {
                    musteriCBox.Items.Add(item);
                }
            }
            
            SqlConnection.Close();
        }

        private void PersonelDoldur()
        {
            string sorgu = "SELECT Ad FROM Calisanlar";
            if (SqlConnection.State != ConnectionState.Open)
            {
                SqlConnection.Open();
            }

            bakimCMD.Connection = SqlConnection;
            bakimCMD.Parameters.Clear();
            bakimCMD.CommandText = sorgu;
            SqlDataReader sqlDataReader = bakimCMD.ExecuteReader();
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

        private void TurDoldur()
        {
            string sorgu = "SELECT Tur_Adi FROM Bakim_Turleri";
            if (SqlConnection.State != ConnectionState.Open)
            {
                SqlConnection.Open();
            }
            bakimCMD.Connection = SqlConnection;
            bakimCMD.Parameters.Clear();
            bakimCMD.CommandText = sorgu;
            SqlDataReader sqlDataReader = bakimCMD.ExecuteReader();
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


        private void BakimEkle_Load(object sender, EventArgs e)
        {
            UrunDoldur();
            MusteriDoldur();
            PersonelDoldur();
            TurDoldur();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string sorgu = "Insert Into Bakimlar values (@Musteri,@Urun,@Personel,@Bilgi,@Tutar,@Tarih,@Tur,@Statu)";
                SqlConnection.Open();

                string secilenUrunAdi = urunCBox.SelectedItem.ToString();
                string urunIDSorgusu = "SELECT Urun_ID FROM Urunler WHERE Urun_Ad = @UrunAd";
                bakimCMD.Parameters.Clear();
                bakimCMD.CommandText = urunIDSorgusu;
                bakimCMD.Parameters.AddWithValue("@UrunAd", secilenUrunAdi);
                int idUrun = (int)bakimCMD.ExecuteScalar();

                // Müşteri adına göre TC'yi almak için veritabanına sorgu gönder
                string secilenMusteriAdi = musteriCBox.SelectedItem.ToString();
                string musteriTCSorgusu = "SELECT Musteri_TC FROM Musteriler WHERE Ad = @MusteriAd";
                bakimCMD.Parameters.Clear();
                bakimCMD.CommandText = musteriTCSorgusu;
                bakimCMD.Parameters.AddWithValue("@MusteriAd", secilenMusteriAdi);
                string musteriTC = bakimCMD.ExecuteScalar().ToString();

                // Personel adına göre TC'yi almak için veritabanına sorgu gönder
                string secilenPersonelAdi = personelCBox.SelectedItem.ToString();
                string personelTCSorgusu = "SELECT TC FROM Calisanlar WHERE Ad = @PersonelAd";
                bakimCMD.Parameters.Clear();
                bakimCMD.CommandText = personelTCSorgusu;
                bakimCMD.Parameters.AddWithValue("@PersonelAd", secilenPersonelAdi);
                string personelTC = bakimCMD.ExecuteScalar().ToString();

                string secilenTurAdi = turCBox.SelectedItem.ToString();
                string turIDSorgusu = "SELECT Bakim_Turu_ID FROM Bakim_Turleri WHERE Tur_Adi = @turAdi";
                bakimCMD.Parameters.Clear();
                bakimCMD.CommandText = turIDSorgusu;
                bakimCMD.Parameters.AddWithValue("@turAdi", secilenTurAdi);
                string turID = bakimCMD.ExecuteScalar().ToString();

                bakimCMD.Parameters.AddWithValue("@Musteri", musteriTC);
                bakimCMD.Parameters.AddWithValue("@Urun", idUrun);
                bakimCMD.Parameters.AddWithValue("@Personel", personelTC);
                bakimCMD.Parameters.AddWithValue("@Bilgi", bilgiTBox.Text);
                bakimCMD.Parameters.AddWithValue("@Tutar", tutarTBox.Text);
                bakimCMD.Parameters.AddWithValue("@Tarih", tarihTBox.Text);
                bakimCMD.Parameters.AddWithValue("@Tur", turID);
                bakimCMD.Parameters.AddWithValue("@Statu", true);
                SqlConnection.Close();
                KomutCalistir(sorgu);
                Bakimlar bakimlar = new Bakimlar();
                bakimlar.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void otomasyonaGitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Otomasyon otomasyon = new Otomasyon();
            otomasyon.Show();
            this.Close();
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
