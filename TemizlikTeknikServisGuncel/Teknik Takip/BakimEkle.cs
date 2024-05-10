using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace TemizlikTeknikServisGuncel
{
    public partial class BakimEkle : Form
    {
        public Bakimlar afrm;
        SqlConnection SqlConnection = new SqlConnection(SQLBaglanti.BaglantiCumlesiGonder());
        SqlCommand bakimCMD = new SqlCommand();
        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
        public void KomutCalistir(string sorgu)
        {
            try
            {
                SqlConnection.Open();
                bakimCMD.CommandText = sorgu;
                bakimCMD.Connection = SqlConnection;
                bakimCMD.ExecuteNonQuery();
                MessageBox.Show("Başarıyla Kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                if (bakimCMD.Parameters.Count > 0)
                {
                    bakimCMD.Parameters.Clear();
                }
                SqlConnection.Close();
            }
        }
        public BakimEkle()
        {
            InitializeComponent();
        }

        private void BakimEkle_Load(object sender, EventArgs e)
        {
            string sorgu = "SELECT Urun_Ad FROM Urunler ";
            SqlConnection.Open();
            bakimCMD.Connection = SqlConnection;
            bakimCMD.Parameters.Clear();
            bakimCMD.CommandText = sorgu;
            SqlDataReader sqlDataReader = bakimCMD.ExecuteReader();
            if (sqlDataReader.Read())
            {
                List<string> urunAdListesi = new List<string>();
                string urunAdi = sqlDataReader["Urun_Ad"].ToString();
                if (urunAdi != null)
                {
                    urunAdListesi.Add(urunAdi);
                }

                foreach (var item in urunAdListesi)
                {
                    urunCBox.Items.Add(item);
                }
            }
            else
            {
                MessageBox.Show("HATA");
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sorgu = "Insert Into Izinler values (@PersonelTC,@Baslangic,@Bitis,@Tur,@Statu)";
            //bakimCMD.Parameters.AddWithValue("@Ad", textBox1.Text);
            KomutCalistir(sorgu);
            Bakimlar bakimlar = new Bakimlar();
            bakimlar.Show();
            this.Close();
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
