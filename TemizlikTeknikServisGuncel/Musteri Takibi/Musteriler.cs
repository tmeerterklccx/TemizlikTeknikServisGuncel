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

namespace TemizlikTeknikServisGuncel.Musteri_Takibi
{
    public partial class Musteriler : Form
    {
        SqlConnection SqlConnection = new SqlConnection(SQLBaglanti.BaglantiCumlesiGonder());
        SqlCommand musteriCMD = new SqlCommand();
        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
        public void KomutCalistir(string sorgu)
        {
            try
            {
                SqlConnection.Open();
                musteriCMD.CommandText = sorgu;
                musteriCMD.Connection = SqlConnection;
                musteriCMD.ExecuteNonQuery();
                MessageBox.Show("Başarıyla Silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                if (musteriCMD.Parameters.Count > 0)
                {
                    musteriCMD.Parameters.Clear();
                }
                SqlConnection.Close();
            }
        }
        public Musteriler()
        {
            InitializeComponent();
        }

        private void Musteriler_Load(object sender, EventArgs e)
        {
            VeriGetir();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MusteriEkle musteriEkle = new MusteriEkle();
            musteriEkle.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MusteriGuncelle musteriGuncelle = new MusteriGuncelle();
            musteriGuncelle.afrm = this;
            musteriGuncelle.textBox2.Text = dgvMusteriler.CurrentRow.Cells[0].Value.ToString();
            musteriGuncelle.ShowDialog();
            this.Close();
        }
        private void VeriGetir()
        {
            string sorgu = "Select * from Musteriler WHERE Statu=True";
            Komutlar komutlar = new Komutlar();
            dgvMusteriler.DataSource = komutlar.VeriDoldur(sorgu);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            VeriGetir();
        }

        private void dgvMusteriler_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e)
        {
            textBox1.Text = dgvMusteriler.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dgvMusteriler.CurrentRow.Cells[1].Value.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string sorgu = "Update Musteriler set Statu = @STATU WHERE Musteri_TC = @tc";
            musteriCMD.Parameters.AddWithValue("@STATU", false);
            musteriCMD.Parameters.AddWithValue("@tc", textBox1.Text);
            KomutCalistir(sorgu);
            VeriGetir();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" || textBox2.Text != "")
            {
                button1.Enabled = true;
                musteriCMD.CommandText = "SELECT * FROM Musteriler WHERE Musteri_TC = @tc OR Ad = @ad";
                musteriCMD.Connection = SqlConnection;
                musteriCMD.Connection.Open();
                musteriCMD.Parameters.Clear();
                musteriCMD.Parameters.AddWithValue("@tc", textBox1.Text);
                musteriCMD.Parameters.AddWithValue("@ad", textBox2.Text);
                SqlDataReader reader = musteriCMD.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                dgvMusteriler.DataSource = dataTable;
                musteriCMD.Connection.Close();
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
    }
}
