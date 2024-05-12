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
    public partial class BakimGuncelle : Form
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
                MessageBox.Show("Başarıyla Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            SqlConnection.Close();
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

        public BakimGuncelle()
        {
            InitializeComponent();

        }
        private void ComboboxaUrunGotur()
        {

            BakimGuncelle bakimGuncelle = new BakimGuncelle();
            string sorgu2 = "SELECT * FROM Urunler WHERE Urun_ID = @UrunID";
            if (SqlConnection.State != ConnectionState.Open)
            {
                SqlConnection.Open();
            }
            bakimCMD.Parameters.Clear();
            bakimCMD.Connection = SqlConnection;
            bakimCMD.CommandText = sorgu2;
            bakimCMD.Parameters.AddWithValue("@UrunID", urun.Text);
            SqlDataReader sqlDataReader = bakimCMD.ExecuteReader();
            if (sqlDataReader.Read())
            {
                string urunAdi = sqlDataReader["Urun_Ad"].ToString();
                urunCBox.SelectedItem = urunAdi;

            }
            else
            {
                bakimGuncelle.urunCBox.Text = "404";
            }
            SqlConnection.Close();
        }
        private void ComboboxaMusteriGotur()
        {
            BakimGuncelle bakimGuncelle = new BakimGuncelle();
            string sorgu3 = "SELECT Ad FROM Musteriler WHERE Musteri_TC = @musteriTC";
            if (SqlConnection.State != ConnectionState.Open)
            {
                SqlConnection.Open();
            }

            bakimCMD.Parameters.Clear();
            bakimCMD.Connection = SqlConnection;
            bakimCMD.CommandText = sorgu3;
            bakimCMD.Parameters.AddWithValue("@musteriTC", musteritc.Text);
            SqlDataReader sqlDataReader = bakimCMD.ExecuteReader();
            if (sqlDataReader.Read())
            {
                musteriCBox.SelectedItem = sqlDataReader["Ad"].ToString();
            }
            else
            {
                bakimGuncelle.musteriCBox.Text = "404";
            }
            SqlConnection.Close();
        }
        private void ComboboxaPersonelGotur()
        {
            BakimGuncelle bakimGuncelle = new BakimGuncelle();
            string sorgu4 = "SELECT Ad FROM Calisanlar WHERE TC = @Tc";
            if (SqlConnection.State != ConnectionState.Open)
            {
                SqlConnection.Open();
            }
            bakimCMD.Parameters.Clear();
            bakimCMD.Connection = SqlConnection;
            bakimCMD.CommandText = sorgu4;
            bakimCMD.Parameters.AddWithValue("@Tc", personeltc.Text);
            SqlDataReader sqlDataReader = bakimCMD.ExecuteReader();
            if (sqlDataReader.Read())
            {
                string calisanAdi = sqlDataReader["Ad"].ToString();
                personelCBox.SelectedItem = calisanAdi;

            }
            else
            {
                bakimGuncelle.personelCBox.Text = "404";
            }
            SqlConnection.Close();
        }
        private void ComboboxaTurGotur()
        {
            BakimGuncelle bakimGuncelle = new BakimGuncelle();
            string sorgu5 = "SELECT Tur_Adi FROM Bakim_Turleri WHERE Bakim_Turu_ID = @Bakim_Turu_ID";
            if (SqlConnection.State != ConnectionState.Open)
            {
                SqlConnection.Open();
            }
            bakimCMD.Parameters.Clear();
            bakimCMD.Connection = SqlConnection;
            bakimCMD.CommandText = sorgu5;
            bakimCMD.Parameters.AddWithValue("@Bakim_Turu_ID", turr.Text);
            SqlDataReader sqlDataReader = bakimCMD.ExecuteReader();
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
                bakimGuncelle.turCBox.Text = "404";
            }
            SqlConnection.Close();
        }
        private int PersonelTCBul()
        {
            BakimGuncelle bakimGuncelle = new BakimGuncelle();
            string sorgu4 = "SELECT TC FROM Calisanlar WHERE Ad = @Ad";
            if (SqlConnection.State != ConnectionState.Open)
            {
                SqlConnection.Open();
            }
            bakimCMD.Parameters.Clear();
            bakimCMD.Connection = SqlConnection;
            bakimCMD.CommandText = sorgu4;
            bakimCMD.Parameters.AddWithValue("@Ad", personelCBox.SelectedItem.ToString());
            SqlDataReader sqlDataReader = bakimCMD.ExecuteReader();
            if (sqlDataReader.Read())
            {
                int calisanAdi = (int)sqlDataReader["TC"];
                SqlConnection.Close();
                return calisanAdi;
            }
            else
            {
                return 404;
            }

        }
        private string MusteriTCBul()
        {
            try
            {
                BakimGuncelle bakimGuncelle = new BakimGuncelle();
                string sorgu4 = "SELECT Musteri_TC FROM Musteriler WHERE Ad = @Ad";
                if (SqlConnection.State != ConnectionState.Open)
                {
                    SqlConnection.Open();
                }
                bakimCMD.Parameters.Clear();
                bakimCMD.Connection = SqlConnection;
                bakimCMD.CommandText = sorgu4;
                bakimCMD.Parameters.AddWithValue("@Ad", musteriCBox.SelectedItem.ToString());
                SqlDataReader sqlDataReader = bakimCMD.ExecuteReader();
                if (sqlDataReader.Read())
                {
                    string musteriAdi = sqlDataReader["Musteri_TC"].ToString();
                    return musteriAdi;

                }
                else
                {
                    return "404";
                }

            }
            catch (Exception ex)
            {
                return "404";
            }
            finally

            {

                SqlConnection.Close();
            }



        }
        private string UrunIDBul()
        {
            BakimGuncelle bakimGuncelle = new BakimGuncelle();
            string sorgu4 = "SELECT Urun_ID FROM Urunler WHERE Urun_Ad = @Ad";
            if (SqlConnection.State != ConnectionState.Open)
            {
                SqlConnection.Open();
            }
            bakimCMD.Parameters.Clear();
            bakimCMD.Connection = SqlConnection;
            bakimCMD.CommandText = sorgu4;
            bakimCMD.Parameters.AddWithValue("@Ad", urunCBox.SelectedItem.ToString());
            SqlDataReader sqlDataReader = bakimCMD.ExecuteReader();
            if (sqlDataReader.Read())
            {
                string urunAdi = sqlDataReader["Urun_ID"].ToString();
                SqlConnection.Close();
                return urunAdi;

            }
            else
            {
                return "404";

            }

        }
        private string TurIDBul()
        {
            BakimGuncelle bakimGuncelle = new BakimGuncelle();
            string sorgu4 = "SELECT Bakim_Turu_ID FROM Bakim_Turleri WHERE Tur_Adi = @Ad";
            if (SqlConnection.State != ConnectionState.Open)
            {
                SqlConnection.Open();
            }
            bakimCMD.Parameters.Clear();
            bakimCMD.Connection = SqlConnection;
            bakimCMD.CommandText = sorgu4;
            bakimCMD.Parameters.AddWithValue("@Ad", turCBox.SelectedItem.ToString());
            SqlDataReader sqlDataReader = bakimCMD.ExecuteReader();
            if (sqlDataReader.Read())
            {
                string turAdi = sqlDataReader["Bakim_Turu_ID"].ToString();
                SqlConnection.Close();
                return turAdi;
            }
            else
            {
                return "404";
            }
        }
        private void BakimGuncelle_Load(object sender, EventArgs e)
        {
            UrunDoldur();
            MusteriDoldur();
            PersonelDoldur();
            TurDoldur();
            ComboboxaUrunGotur();
            ComboboxaPersonelGotur();
            ComboboxaTurGotur();
            ComboboxaMusteriGotur();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bakimCMD.Parameters.Clear();
            string sorgu = "UPDATE Bakimlar SET Musteri_TC = @TCMusteri, Bakim_Urun_ID = @urunid, Personel_TC = @tcPersonel, Bakim_Bilgi = @bilgiBakim, Bakim_Tutar = @tutarBakim, Bakim_Tarihi = @tarihBakim,Bakim_Turu_ID=@turBakim, Statu = @Statu WHERE Bakim_ID = @idBakim";
            bakimCMD.Parameters.AddWithValue("@TCMusteri", MusteriTCBul()); // Müşteri TC
            bakimCMD.Parameters.AddWithValue("@urunid", UrunIDBul()); // Bakım ürün ID
            bakimCMD.Parameters.AddWithValue("@tcPersonel", PersonelTCBul()); // Personel TC
            bakimCMD.Parameters.AddWithValue("@bilgiBakim", bilgiTBox.Text); // Bakım bilgisi
            bakimCMD.Parameters.AddWithValue("@tutarBakim", tutarTBox.Text); // Bakım tutarı
            bakimCMD.Parameters.AddWithValue("@tarihBakim", tarihTBox.Text); // Bakım tarihi
            bakimCMD.Parameters.AddWithValue("@turBakim", TurIDBul()); // Bakım Türü
            if (statuCMB.Text == "Aktif")
            {
                bakimCMD.Parameters.AddWithValue("@Statu", 1);
            }
            else if (statuCMB.Text == "Pasif")
            {
                bakimCMD.Parameters.AddWithValue("@Statu", 0);
            }
            bakimCMD.Parameters.AddWithValue("@idBakim", IDTBox.Text); // Bakım ID
            KomutCalistir(sorgu);
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
