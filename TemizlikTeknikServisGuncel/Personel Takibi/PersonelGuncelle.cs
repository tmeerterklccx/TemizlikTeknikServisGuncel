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
    public partial class PersonelGuncelle : Form
    {
        public Personeller afrm;
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
                MessageBox.Show("Başarıyla Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        public PersonelGuncelle()
        {
            InitializeComponent();
        }

        private void otomasyonaGitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Otomasyon otomasyon = new Otomasyon();
            otomasyon.Show();
            this.Close();
        }

        private void guncelle_Click(object sender, EventArgs e)
        {
            string sorgu = "UPDATE Calisanlar SET Ad = @Ad, Soyad = @Soyad, Telefon = @Telefon, EMail = @EMail, Adres = @Adres, Pozisyon = @Pozisyon, PersonelSifresi = @Sifre, Statu = @Statu, KullaniciRolu = @Rol WHERE TC = @TC";
            personelCMD.Parameters.AddWithValue("@TC", tcTBox.Text);
            personelCMD.Parameters.AddWithValue("@Ad", adTBox.Text);
            personelCMD.Parameters.AddWithValue("@Soyad", soyadTBox.Text);
            personelCMD.Parameters.AddWithValue("@Telefon", telTBox.Text);
            personelCMD.Parameters.AddWithValue("@EMail", ePostATBox.Text);
            personelCMD.Parameters.AddWithValue("@Adres", adresTextBox.Text);
            personelCMD.Parameters.AddWithValue("@Pozisyon", pozTBox.Text);
            personelCMD.Parameters.AddWithValue("@Sifre", sifreTBox.Text);
            if (statuCBox.Text == "Aktif")
            {
                personelCMD.Parameters.AddWithValue("@Statu", 1);
            }
            else if (statuCBox.Text == "Pasif")
            {
                personelCMD.Parameters.AddWithValue("@Statu", 0);
            }
            if (rolTBox.Text == "0")
            {
                personelCMD.Parameters.AddWithValue("@Rol", 0);
            }
            else if (rolTBox.Text == "1")
            {
                personelCMD.Parameters.AddWithValue("@Rol", 1);
            }
            else
            {
                MessageBox.Show("Lütfen sadece 1 veya 0 giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


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

        private void PersonelGuncelle_Load(object sender, EventArgs e)
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

        private void tcTBox_TextAlignChanged(object sender, EventArgs e)
        {

        }
    }
}
