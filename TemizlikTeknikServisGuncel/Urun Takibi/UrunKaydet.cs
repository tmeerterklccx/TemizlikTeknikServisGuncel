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
    public partial class UrunKaydet : Form
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
                MessageBox.Show("Başarıyla Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        public UrunKaydet()
        {
            InitializeComponent();
        }

        private void otomasyonaGitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Otomasyon otomasyon = new Otomasyon();
            otomasyon.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sorgu = "Insert Into Urunler values (@Ad,@Bilgi,@MarkaID,@Tur_ID,@Yil)";
            UrunCMD.Parameters.AddWithValue("@Ad", urunAdiTBox.Text);
            UrunCMD.Parameters.AddWithValue("@Bilgi", bilgiTBox.Text);
            UrunCMD.Parameters.AddWithValue("@Marka_ID", markaCBox.SelectedIndex);
            UrunCMD.Parameters.AddWithValue("@Tur_ID", turCBox.SelectedIndex);
            UrunCMD.Parameters.AddWithValue("@Yil", yilTBox.Text);

            KomutCalistir(sorgu);
            Urunler urunler = new Urunler();
            urunler.Show();
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
