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
    public partial class UrunTurleriGuncelle : Form
    {
        public UrunTurleri afrm;
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
        public UrunTurleriGuncelle()
        {
            InitializeComponent();
        }

        private void UrunTurleriGuncelle_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sorgu = "Update Urun_Turleri set Tur_Adi = @TurAd WHERE Tur_ID = @TurID";
            TurCMD.Parameters.AddWithValue("@TurID", textBox2.Text);
            TurCMD.Parameters.AddWithValue("@TurAd", textBox1.Text);
            KomutCalistir(sorgu);
            UrunTurleri urunTurleri = new UrunTurleri();
            urunTurleri.Show();
            this.Close();


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                button1.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
            }
        }
    }
}
