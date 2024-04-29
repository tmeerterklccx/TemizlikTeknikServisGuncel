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

    public partial class MusteriGuncelle : Form
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
                MessageBox.Show("Başarıyla Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        public MusteriGuncelle()
        {
            InitializeComponent();
        }

        private void MusteriGuncelle_Load(object sender, EventArgs e)
        {
            cmbStatu.Items.Clear();
            cmbStatu.Items.Add("Aktif");
            cmbStatu.Items.Add("Pasif");
        }

        private void button1_Click(object sender, EventArgs e)
        {
                string sorgu = "UPDATE Musteriler SET Musteri_TC = @TC, Ad = @Ad, Soyad = @Soyad, Telefon = @Telefon, EMail = @EMail, Adres = @Adres, Statu = @Statu WHERE Musteri_TC = @TC";

                musteriCMD.Parameters.AddWithValue("@TC", tcTextBox.Text);
                musteriCMD.Parameters.AddWithValue("@Ad", adTextBox.Text);
                musteriCMD.Parameters.AddWithValue("@Soyad", soyadTextBox.Text);
                musteriCMD.Parameters.AddWithValue("@Telefon", telTextBox.Text);
                musteriCMD.Parameters.AddWithValue("@EMail", eMailTextBox.Text);
                musteriCMD.Parameters.AddWithValue("@Adres", adresTextBox.Text);
                if (cmbStatu.Text == "Aktif")
                {
                    musteriCMD.Parameters.AddWithValue("@Statu", 1);
                }
                else if (cmbStatu.Text == "Pasif")
                {
                    musteriCMD.Parameters.AddWithValue("@Statu", 0);
                }
                KomutCalistir(sorgu);
                
        }
    }
}
