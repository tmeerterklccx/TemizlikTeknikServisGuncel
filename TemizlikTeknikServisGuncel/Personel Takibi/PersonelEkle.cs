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
    public partial class PersonelEkle : Form
    {
        SqlConnection SqlConnection = new SqlConnection(SQLBaglanti.BaglantiCumlesiGonder());
        SqlCommand personelCMD = new SqlCommand();
        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
        public void KomutCalistir(string sorgu)
        {
            try
            {
                SqlConnection.Open();
                personelCMD.CommandText = sorgu;
                personelCMD.Connection = SqlConnection;
                personelCMD.ExecuteNonQuery();
                MessageBox.Show("Başarıyla Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                if (personelCMD.Parameters.Count > 0)
                {
                    personelCMD.Parameters.Clear();
                }
                SqlConnection.Close();
            }
        }
        public PersonelEkle()
        {
            InitializeComponent();
        }

        private void otomasyonaGitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Otomasyon otomasyon = new Otomasyon();
            otomasyon.Show();
            this.Close();
        }

        private void ekle_Click(object sender, EventArgs e)
        {
            string sorgu = "INSERT INTO Calisanlar VALUES (@TC, @Ad, @Soyad, @Telefon, @EMail, @Adres, @Pozisyon , @Sifre , @Statu , @Rol)";
            personelCMD.Parameters.AddWithValue("@TC", tcTBox.Text);
            personelCMD.Parameters.AddWithValue("@Ad", adTBox.Text);
            personelCMD.Parameters.AddWithValue("@Soyad", soyadTBox.Text);
            personelCMD.Parameters.AddWithValue("@Telefon", telTBox.Text);
            personelCMD.Parameters.AddWithValue("@EMail", ePostATBox.Text);
            personelCMD.Parameters.AddWithValue("@Adres", adresTextBox.Text);
            personelCMD.Parameters.AddWithValue("@Pozisyon", pozTBox.Text);
            personelCMD.Parameters.AddWithValue("@Sifre", sifreTBox.Text);
            personelCMD.Parameters.AddWithValue("@Statu", true);
            personelCMD.Parameters.AddWithValue("@Rol", 0);
            bool tcStatus = Komutlar.ValidateTCNumber(tcTBox.Text);
            if (tcStatus)
            {
                KomutCalistir(sorgu);
                Personeller personel = new Personeller();
                personel.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Girdiğiniz TC Kimlik Numarası Geçersiz , Lütfen Kontrol Ediniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void PersonelEkle_Load(object sender, EventArgs e)
        {

        }

        private void çıkışYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkış yapmak istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void tcTBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tcTBox.Text.Length > 11)
                {
                    tcTBox.Text = tcTBox.Text.Substring(0, 11);
                    tcTBox.SelectionStart = tcTBox.Text.Length;
                }
            }
            catch
            {
                MessageBox.Show("Lütfen 11 Karakterden Fazla Veri Girmeyiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void telTBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (telTBox.Text.Length > 10)
                {
                    telTBox.Text = telTBox.Text.Substring(0, 10);
                    telTBox.SelectionStart = telTBox.Text.Length;
                }
            }
            catch
            {
                MessageBox.Show("Lütfen 11 Karakterden Fazla Veri Girmeyiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
