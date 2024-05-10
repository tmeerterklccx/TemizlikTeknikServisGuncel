using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemizlikTeknikServisGuncel
{

    public partial class MarkaEkle : Form
    {
        public Markalar afrm;
        SqlConnection SqlConnection = new SqlConnection(SQLBaglanti.BaglantiCumlesiGonder());
        SqlCommand MarkaCMD = new SqlCommand();
        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
        public void KomutCalistir(string sorgu)
        {
            try
            {
                SqlConnection.Open();
                MarkaCMD.CommandText = sorgu;
                MarkaCMD.Connection = SqlConnection;
                MarkaCMD.ExecuteNonQuery();
                MessageBox.Show("Başarıyla Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                if (MarkaCMD.Parameters.Count > 0)
                {
                    MarkaCMD.Parameters.Clear();
                }
                SqlConnection.Close();
            }
        }
        public MarkaEkle()
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

            string sorgu = "Insert Into Markalar (Marka_Ad) values (@MarkaAd)";
            MarkaCMD.Parameters.AddWithValue("@MarkaAd", markaAdTBox.Text);
            KomutCalistir(sorgu);
            Markalar markalar = new Markalar();
            markalar.Show();
            this.Close();

        }

        private void MarkaEkle_Load(object sender, EventArgs e)
        {
            ekleBTN.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (markaAdTBox.Text == "")
            {
                ekleBTN.Enabled = false;
            }
            else
            {
                ekleBTN.Enabled = true;
            }
        }

        private void programToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void çıkışYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkış yapmak istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }
    }
}
