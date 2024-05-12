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
using TemizlikTeknikServisGuncel.Musteri_Takibi;

namespace TemizlikTeknikServisGuncel
{
    public partial class Otomasyon : Form
    {
        public Form1 afrm;
        public Otomasyon()
        {
            InitializeComponent();
        }
        public Otomasyon(string ad)
        {

        }

        private void uyelikToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ıconButton1_Click(object sender, EventArgs e)
        {
            Urunler urunler = new Urunler();
            urunler.Show();

        }

        private void ıconButton2_Click(object sender, EventArgs e)
        {
            //UrunTurleri urunTurleri = new UrunTurleri();
            //urunTurleri.Show();

        }

        private void ıconButton4_Click(object sender, EventArgs e)
        {
            Personeller personeller = new Personeller();
            personeller.Show();

        }

        private void ıconButton5_Click(object sender, EventArgs e)
        {
            Izinler ızinler = new Izinler();
            ızinler.Show();

        }

        private void ıconButton3_Click(object sender, EventArgs e)
        {
            Bakimlar bakimlar = new Bakimlar();
            bakimlar.Show();

        }

        private void ıconButton8_Click(object sender, EventArgs e)
        {
            Musteriler musteriler = new Musteriler();
            musteriler.Show();

        }

        private void ıconButton6_Click(object sender, EventArgs e)
        {

            Markalar markalar = new Markalar();
            markalar.Show();

        }

        private void ıconButton7_Click(object sender, EventArgs e)
        {

        }

        private void Otomasyon_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(SQLBaglanti.BaglantiCumlesiGonder()))
            {
                try
                {
                    connection.Open();

                    // Bakımlar tablosundaki en çok bakım yapılan ürünün ID'sini bulan SQL sorgusu
                    string query = @"
            SELECT u.Urun_Ad
            FROM Urunler u
            WHERE u.Urun_ID = (
                SELECT TOP 1 b.Bakim_Urun_ID
                FROM Bakimlar b
                GROUP BY b.Bakim_Urun_ID
                ORDER BY COUNT(*) DESC
            )";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        string urunAdi = (string)command.ExecuteScalar();
                        encokbakim.Text = urunAdi;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
            using (SqlConnection connection = new SqlConnection(SQLBaglanti.BaglantiCumlesiGonder()))
            {
                try
                {
                    connection.Open();
                    // Toplam bakım sayısını bulan sql sorgusu
                    string query = "SELECT COUNT(*) AS ToplamBakimSayisi FROM Bakimlar";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        string toplambakimd = command.ExecuteScalar().ToString();
                        toplambakim.Text = toplambakimd;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
            using (SqlConnection connection = new SqlConnection(SQLBaglanti.BaglantiCumlesiGonder()))
            {
                try
                {
                    connection.Open();
                    // Toplam Müşteri sayısını bulan sql sorgusu
                    string query = "SELECT COUNT(*) AS MusteriSayimiz FROM Musteriler";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        string toplamMusterid = command.ExecuteScalar().ToString();
                        toplammusteri.Text = toplamMusterid;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
            using (SqlConnection connection = new SqlConnection(SQLBaglanti.BaglantiCumlesiGonder()))
            {
                try
                {
                    connection.Open();
                    // Toplam Müşteri sayısını bulan sql sorgusu
                    string query = "SELECT COUNT(*) AS UrunSayimiz FROM Urunler";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        string toplamurund = command.ExecuteScalar().ToString();
                        toplamurun.Text = toplamurund;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
            using (SqlConnection connection = new SqlConnection(SQLBaglanti.BaglantiCumlesiGonder()))
            {
                try
                {
                    connection.Open();
                    // Toplam Marka sayısını bulan sql sorgusu
                    string query = "SELECT COUNT(*) AS MarkaSayimiz FROM Markalar";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        string markasayisid = command.ExecuteScalar().ToString();
                        toplammarka.Text = markasayisid;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
            using (SqlConnection connection = new SqlConnection(SQLBaglanti.BaglantiCumlesiGonder()))
            {
                try
                {
                    connection.Open();
                    // En Çok İzin Sebebi sayısını bulan sql sorgusu
                    string query = "SELECT MAX(Tur) AS MaxIzin FROM Izinler";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        string maksimumIzin = command.ExecuteScalar().ToString();
                        if (maksimumIzin == "y")
                        {
                            maxizin.Text = "Yıllık İzin";
                        }
                        else if (maksimumIzin == "r")
                        {
                            maxizin.Text = "Raporlu İzin";
                        }
                        else if (maksimumIzin == "d")
                        {
                            maxizin.Text = "Dönemsel İzin";
                        }
                        else if (maksimumIzin == "g")
                        {
                            maxizin.Text = "Günlük İzin";
                        }
                        else if (maksimumIzin == "o")
                        {
                            maxizin.Text = "Özel İzin";
                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }


        }

        private void oturumuKapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void ıconButton2_Click_1(object sender, EventArgs e)
        {
        }
    }
}
