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

        private void ��k��YapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Uygulamadan ��k�� Yap�ls�n m�?", "Uyar�", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void �conButton8_Click(object sender, EventArgs e)
        {
            string tc = TCTBox.Text;
            string sifre = SifreTBox.Text;

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
                        otomasyon.lblTC.Text = ad + " " + "(" + (tc) + ")";
                        otomasyon.�conButton4.Visible = true;
                        otomasyon.�conButton5.Visible = true;
                        otomasyon.yetkiBTN.Text = "ADM�N";
                        otomasyon.ShowDialog();
                        this.Close();
                    }
                    else if (personelRol == 0)
                    {
                        Otomasyon otomasyon = new Otomasyon();
                        otomasyon.afrm = this;
                        otomasyon.�conButton4.Visible = false;
                        otomasyon.�conButton5.Visible = false;
                       // otomasyon.label20.Visible = false;
                        otomasyon.maxizin.Visible = false;
                        otomasyon.toplammarka.Visible = false;
                        otomasyon.label3.Visible = false;
                        otomasyon.label4.Visible = false;
                        otomasyon.lblTC.Text = ad + " " + "(" + (tc) + ")";
                        otomasyon.yetkiBTN.Text = "(PERSONEL)";
                        otomasyon.ShowDialog();
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Yanl�� TC veya �ifre! L�tfen tekrar deneyin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritaban� i�lemi s�ras�nda hata olu�tu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                SqlConnection.Close(); // Ba�lant�y� kapat
            }
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}