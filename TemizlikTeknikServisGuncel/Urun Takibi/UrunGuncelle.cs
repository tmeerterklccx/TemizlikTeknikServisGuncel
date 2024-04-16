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
                SqlConnection.Open();
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

        private void button1_Click(object sender, EventArgs e)
        {
            string sorgu = "Update Urunler set Urun_Ad,Urun_Bilgi,Marka_ID,Urun_Tur_ID,Uretim_Yili,Urun_Satis_Fiyati,Garanti_Suresi_Day,Urun_Alis_Fiyati,Urun_KDV_Orani,Urun_Stok = @UrunAd,@UrunBilgi,@MarkaID,@UrunTurID,@UretimYili,@UrunSatisFiyati,@GarantiSuresi,@UrunAlisFiyati,@UrunKDVOrani,@UrunStok WHERE Urun_ID = @UrunID";
            UrunCMD.Parameters.AddWithValue("@UrunID", textBox1.Text);
            UrunCMD.Parameters.AddWithValue("@UrunAd", textBox1.Text);
            UrunCMD.Parameters.AddWithValue("@UrunBilgi", textBox1.Text);
            UrunCMD.Parameters.AddWithValue("@Marka_ID", textBox1.Text);
            UrunCMD.Parameters.AddWithValue("@Urun_Tur_ID", textBox1.Text);
            UrunCMD.Parameters.AddWithValue("@Uretim_Yili", textBox1.Text);
            UrunCMD.Parameters.AddWithValue("@Urun_Satis_Fiyati", textBox1.Text);
            UrunCMD.Parameters.AddWithValue("@Garanti_Suresi_Day", textBox1.Text);
            UrunCMD.Parameters.AddWithValue("@Urun_Alis_Fiyati", textBox1.Text);
            UrunCMD.Parameters.AddWithValue("@Urun_KDV_Orani", textBox1.Text);
            UrunCMD.Parameters.AddWithValue("@Urun_Stok", textBox1.Text);
            KomutCalistir(sorgu);
            Urunler urunler = new Urunler();
            urunler.Show();
            this.Close();
        }

        private void UrunGuncelle_Load(object sender, EventArgs e)
        {
            
            string sorgu = "Select Marka_Ad from Markalar";
        }
    }
}
