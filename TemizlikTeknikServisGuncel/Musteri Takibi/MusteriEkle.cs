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

namespace TemizlikTeknikServisGuncel.Musteri_Takibi
{
    public partial class MusteriEkle : Form
    {
        public Musteriler afrm;
        SqlConnection SqlConnection = new SqlConnection(SQLBaglanti.BaglantiCumlesiGonder());
        SqlCommand musteriCMD = new SqlCommand();
        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
        public void KomutCalistir(string sorgu)
        {
            try
            {
                SqlConnection.Open();
                musteriCMD.CommandText = sorgu;
                musteriCMD.Connection = SqlConnection;
                musteriCMD.ExecuteNonQuery();
                MessageBox.Show("Başarıyla Eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                if (musteriCMD.Parameters.Count > 0)
                {
                    musteriCMD.Parameters.Clear();
                }
                SqlConnection.Close();
            }
        }
        public MusteriEkle()
        {
            InitializeComponent();
        }

        private void MusteriEkle_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sorgu = "INSERT INTO Musteriler (Musteri_TC, Ad, Soyad, Telefon, EMail, Adres, Statu) VALUES (@TC, @Ad, @Soyad, @Telefon, @EMail, @Adres, @Statu)";
            musteriCMD.Parameters.AddWithValue("@TC", tcTextBox.Text);
            musteriCMD.Parameters.AddWithValue("@Ad", adTextBox.Text);
            musteriCMD.Parameters.AddWithValue("@Soyad", soyadTextBox.Text);
            musteriCMD.Parameters.AddWithValue("@Telefon", telTextBox.Text);
            musteriCMD.Parameters.AddWithValue("@EMail", eMailTextBox.Text);
            musteriCMD.Parameters.AddWithValue("@Adres", adresTextBox.Text);
            musteriCMD.Parameters.AddWithValue("@Statu", false);
            KomutCalistir(sorgu);
            UrunTurleri urunTurleri = new UrunTurleri();
            urunTurleri.Show();
            this.Close();
        }
    }
}
