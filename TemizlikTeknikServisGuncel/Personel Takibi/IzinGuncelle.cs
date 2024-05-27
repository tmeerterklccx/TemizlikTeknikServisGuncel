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
    public partial class IzinGuncelle : Form
    {
        public Izinler afrm;
        SqlConnection SqlConnection = new SqlConnection(SQLBaglanti.BaglantiCumlesiGonder());
        SqlCommand TurCMD = new SqlCommand();
        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
        public void KomutCalistir(string sorgu)
        {
            try
            {
                SqlConnection.Open();
                TurCMD.CommandText = sorgu;
                TurCMD.Connection = SqlConnection;
                TurCMD.ExecuteNonQuery();
                MessageBox.Show("Başarıyla Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                if (TurCMD.Parameters.Count > 0)
                {
                    TurCMD.Parameters.Clear();
                }
                SqlConnection.Close();
            }
        }
        public IzinGuncelle()
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
            string sorgu = "UPDATE Izinler SET Izin_Baslangic = @baslangic, Izin_Bitis = @bitis, Tur = @tur WHERE Izin_ID = @izinid";
            TurCMD.Parameters.AddWithValue("@izinid", IDTBox.Text);
            TurCMD.Parameters.AddWithValue("@baslangic", BasTBox.Text);
            TurCMD.Parameters.AddWithValue("@bitis", bitisTBOx.Text);
            TurCMD.Parameters.AddWithValue("@tur", turTBox.Text);
            KomutCalistir(sorgu);
            Izinler izinler = new Izinler();
            izinler.Show();
            this.Close();
        }
        private void PersonelDoldur()
        {
            string sorgu = "SELECT Ad FROM Calisanlar";
            if (SqlConnection.State != ConnectionState.Open)
            {
                SqlConnection.Open();
            }

            TurCMD.Connection = SqlConnection;
            TurCMD.Parameters.Clear();
            TurCMD.CommandText = sorgu;
            SqlDataReader sqlDataReader = TurCMD.ExecuteReader();
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
        private void ComboboxaPersonelGotur()
        {
            BakimGuncelle bakimGuncelle = new BakimGuncelle();
            string sorgu4 = "SELECT Ad FROM Calisanlar WHERE TC = @Tc";
            if (SqlConnection.State != ConnectionState.Open)
            {
                SqlConnection.Open();
            }
            TurCMD.Parameters.Clear();
            TurCMD.Connection = SqlConnection;
            TurCMD.CommandText = sorgu4;
            TurCMD.Parameters.AddWithValue("@Tc", personelTCBox.Text);
            SqlDataReader sqlDataReader = TurCMD.ExecuteReader();
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
        private void IzinGuncelle_Load(object sender, EventArgs e)
        {
            PersonelDoldur();
            ComboboxaPersonelGotur();
        }

        private void çıkışYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkış yapmak istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void tcBox_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
