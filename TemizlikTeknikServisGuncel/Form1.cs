using Microsoft.Data.SqlClient;
using System.Data;

namespace TemizlikTeknikServisGuncel
{
    public partial class Form1 : Form
    {
        SqlConnection SqlConnection = new SqlConnection(SQLBaglanti.BaglantiCumlesiGonder());
        public Form1()
        {
            InitializeComponent();
        }

        private void çýkýþYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Uygulamadan Çýkýþ Yapýlsýn mý?", "Uyarý", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void ýconButton8_Click(object sender, EventArgs e)
        {
            string tc = textBox1.Text;
            string sifre = textBox2.Text;

            try
            {
                SqlConnection.Open();
                string query = "SELECT Ad, KullaniciRolu FROM Calisanlar WHERE TC = @tc AND PersonelSifresi = @sifre AND Statu = 1";
                SqlCommand command = new SqlCommand(query, SqlConnection);
                command.Parameters.AddWithValue("@tc", tc);
                command.Parameters.AddWithValue("@sifre", sifre);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    string ad = reader["Ad"].ToString();
                    int personelRol = Convert.ToInt32(reader["KullaniciRolu"]);

                    if (personelRol == 1)
                    {
                        Otomasyon otomasyon = new Otomasyon();
                        otomasyon.afrm = this;
                        otomasyon.lblTC.Text = ad + " " +"("+ (tc)+")";
                        otomasyon.ShowDialog();
                        this.Close();
                    }
                    else if (personelRol == 0)
                    {
                        Otomasyon otomasyon = new Otomasyon();
                        otomasyon.afrm = this;
                        otomasyon.lblTC.Text = ad + " " + "(" + (tc) + ")";
                        otomasyon.ShowDialog();
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Yanlýþ TC veya Þifre! Lütfen tekrar deneyin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabaný iþlemi sýrasýnda hata oluþtu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                SqlConnection.Close(); // Baðlantýyý kapat
            }
        }
    }
}