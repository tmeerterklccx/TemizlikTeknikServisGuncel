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
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sorgu = "UPDATE Musteriler SET Musteri_TC = @TC, Ad = @Ad, Soyad = @Soyad, Telefon = @Telefon, EMail = @EMail, Adres = @Adres, Statu = @Statu WHERE Musteri_TC = @TC";

            musteriCMD.Parameters.AddWithValue("@TC", tcTBox.Text);
            musteriCMD.Parameters.AddWithValue("@Ad", adTBox.Text);
            musteriCMD.Parameters.AddWithValue("@Soyad", soyadTBox.Text);
            musteriCMD.Parameters.AddWithValue("@Telefon", telTBox.Text);
            musteriCMD.Parameters.AddWithValue("@EMail", ePostATBox.Text);
            musteriCMD.Parameters.AddWithValue("@Adres", adresTextBox.Text);
            if (statuCBox.Text == "Aktif")
            {
                musteriCMD.Parameters.AddWithValue("@Statu", 1);
            }
            else if (statuCBox.Text == "Pasif")
            {
                musteriCMD.Parameters.AddWithValue("@Statu", 0);
            }
            else
            {
                musteriCMD.Parameters.AddWithValue("@Statu", 1);
            }
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
