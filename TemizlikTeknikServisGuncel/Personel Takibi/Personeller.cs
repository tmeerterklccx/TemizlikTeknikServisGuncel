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
    public partial class Personeller : Form
    {
        SqlConnection SqlConnection = new SqlConnection(SQLBaglanti.BaglantiCumlesiGonder());
        SqlCommand perCMD = new SqlCommand();
        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
        public void KomutCalistir(string sorgu)
        {
            try
            {
                SqlConnection.Open();
                perCMD.CommandText = sorgu;
                perCMD.Connection = SqlConnection;
                perCMD.ExecuteNonQuery();
                MessageBox.Show("Başarıyla Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                if (perCMD.Parameters.Count > 0)
                {
                    perCMD.Parameters.Clear();
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
        public Personeller()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PersonelEkle personelEkle = new PersonelEkle();
            personelEkle.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PersonelGuncelle personelGuncelle = new PersonelGuncelle();
            personelGuncelle.afrm = this;
            personelGuncelle.AdTBox.Text= dataGridView1.CurrentRow.Cells[2].Value.ToString();
            personelGuncelle.soyadTBox.Text= dataGridView1.CurrentRow.Cells[3].Value.ToString();
            personelGuncelle.telefonTBox.Text= dataGridView1.CurrentRow.Cells[4].Value.ToString();
            personelGuncelle.epostaTBox.Text= dataGridView1.CurrentRow.Cells[5].Value.ToString();
            personelGuncelle.pozisyonTBox.Text= dataGridView1.CurrentRow.Cells[7].Value.ToString();
            personelGuncelle.adresTBox.Text= dataGridView1.CurrentRow.Cells[6].Value.ToString();
            personelGuncelle.textBox1.Text= dataGridView1.CurrentRow.Cells[1].Value.ToString();
            personelGuncelle.rolTBox.Text= dataGridView1.CurrentRow.Cells[10].Value.ToString();
            personelGuncelle.sifreTBox.Text= dataGridView1.CurrentRow.Cells[8].Value.ToString();
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
            string sorgu = "select * from Calisanlar WHERE Statu=1";
            Komutlar komutlar = new Komutlar();
            dataGridView1.DataSource = VeriDoldur(sorgu);
        }
        private void Personeller_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" || textBox2.Text != "")
            {
                button1.Enabled = true;
                perCMD.CommandText = "SELECT * FROM Calisanlar WHERE Izin_ID = @id OR Personel_TC = @tc";
                perCMD.Connection = SqlConnection;
                perCMD.Connection.Open();
                perCMD.Parameters.Clear();
                perCMD.Parameters.AddWithValue("@id", textBox1.Text);
                perCMD.Parameters.AddWithValue("@tc", textBox2.Text);
                SqlDataReader reader = perCMD.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                dataGridView1.DataSource = dataTable;
                perCMD.Connection.Close();
            }
            else
            {
                button1.Enabled = false;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string sorgu = "Update Calisanlar set Statu = @STATU WHERE Personel_TC = @tc";
            perCMD.Parameters.AddWithValue("@STATU", false);
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            perCMD.Parameters.AddWithValue("@tc", textBox1.Text);
            KomutCalistir(sorgu);
            VeriGetir();
        }
    }
}
