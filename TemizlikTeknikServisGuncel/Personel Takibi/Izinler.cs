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
    public partial class Izinler : Form
    {
        SqlConnection SqlConnection = new SqlConnection(SQLBaglanti.BaglantiCumlesiGonder());
        SqlCommand izinCMD = new SqlCommand();
        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
        public void KomutCalistir(string sorgu)
        {
            try
            {
                SqlConnection.Open();
                izinCMD.CommandText = sorgu;
                izinCMD.Connection = SqlConnection;
                izinCMD.ExecuteNonQuery();
                MessageBox.Show("Başarıyla Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                if (izinCMD.Parameters.Count > 0)
                {
                    izinCMD.Parameters.Clear();
                }
                SqlConnection.Close();
            }
        }
        public DataTable VeriDoldur(string sorgu)
        {
            DataTable tablo = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sorgu, SqlConnection);
            sqlDataAdapter.Fill(tablo);
            return tablo;
        }
        public Izinler()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            IzinEkle ızinEkle = new IzinEkle();
            ızinEkle.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            IzinGuncelle izinGuncelle = new IzinGuncelle();
            izinGuncelle.afrm = this;
            izinGuncelle.tcPersonel.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            izinGuncelle.izinTur.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            izinGuncelle.baslangic.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            izinGuncelle.bitis.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            izinGuncelle.id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            izinGuncelle.ShowDialog();
            this.Close();
        }

        private void otomasyonaGitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Otomasyon otomasyon = new Otomasyon();
            otomasyon.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            VeriGetir();
        }

        private void VeriGetir()
        {
            string sorgu = "select * from Izinler WHERE Statu=1";
            Komutlar komutlar = new Komutlar();
            dataGridView1.DataSource = VeriDoldur(sorgu);
        }

        private void Izinler_Load(object sender, EventArgs e)
        {
            VeriGetir();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" || textBox2.Text != "")
            {
                button1.Enabled = true;
                izinCMD.CommandText = "SELECT * FROM Izinler WHERE Izin_ID = @id OR Personel_TC = @tc";
                izinCMD.Connection = SqlConnection;
                izinCMD.Connection.Open();
                izinCMD.Parameters.Clear();
                izinCMD.Parameters.AddWithValue("@id", textBox1.Text);
                izinCMD.Parameters.AddWithValue("@tc", textBox2.Text);
                SqlDataReader reader = izinCMD.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                dataGridView1.DataSource = dataTable;
                izinCMD.Connection.Close();
            }
            else
            {
                button1.Enabled = false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text) || !string.IsNullOrWhiteSpace(textBox2.Text))
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string sorgu = "Update Izinler set Statu = @STATU WHERE Izin_ID = @id";
            izinCMD.Parameters.AddWithValue("@STATU", false);
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            izinCMD.Parameters.AddWithValue("@id", textBox1.Text);
            KomutCalistir(sorgu);
            VeriGetir();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
