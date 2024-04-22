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
    public partial class UrunTurleri : Form
    {

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
                MessageBox.Show("Başarıyla Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        public DataTable VeriDoldur(string sorgu)
        {
            DataTable tablo = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sorgu, SqlConnection);
            sqlDataAdapter.Fill(tablo);
            return tablo;
        }
        public UrunTurleri()
        {
            InitializeComponent();
        }

        private void UrunTurleri_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
        private void BaslikGoster()
        {
            dgvTurler.Columns[0].HeaderText = "Tur ID";
            dgvTurler.Columns[0].Width = 200;
            dgvTurler.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvTurler.Columns[1].HeaderText = "Tur ADI";
            dgvTurler.Columns[1].Width = 350;
            dgvTurler.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
        }
        private void VeriGetir()
        {
            Komutlar komutlar = new Komutlar();
            string sorgu = "Select * From Urun_Turleri";
            dgvTurler.DataSource = komutlar.VeriDoldur(sorgu);
        }

        private void UrunTurleri_Load_1(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button5.Enabled = false;
            VeriGetir();
            BaslikGoster();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            VeriGetir();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Silmek İstediğinize Emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                string deger = dgvTurler.CurrentRow.Cells[0].Value.ToString();
                int id = Convert.ToInt32(deger);
                string sorgu = "Delete from Urun_Turleri where Tur_ID =@ID";
                TurCMD.Parameters.AddWithValue("@ID", id);
                KomutCalistir(sorgu);
                VeriGetir();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UrunTurleriEkle urunTurleriEkle = new UrunTurleriEkle();
            urunTurleriEkle.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UrunTurleriGuncelle turGuncelle = new UrunTurleriGuncelle();
            turGuncelle.afrm = this;
            turGuncelle.textBox2.Text = dgvTurler.CurrentRow.Cells[0].Value.ToString();
            turGuncelle.ShowDialog();
        }

        private void otomasyonaGitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Otomasyon otomasyon = new Otomasyon();
            otomasyon.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" || textBox2.Text != "")
            {
                button1.Enabled = true;
                TurCMD.CommandText = "SELECT Tur_ID, Tur_Adi FROM Urun_Turleri WHERE Tur_ID = @turID OR Tur_Adi = @turAdi";
                TurCMD.Connection = SqlConnection;
                TurCMD.Connection.Open();
                TurCMD.Parameters.Clear();
                TurCMD.Parameters.AddWithValue("@turID", textBox1.Text);
                TurCMD.Parameters.AddWithValue("@turAdi", textBox2.Text);
                SqlDataReader reader = TurCMD.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                dgvTurler.DataSource = dataTable;
                TurCMD.Connection.Close();
            }
            else
            {
                button1.Enabled = false;
            }

        }

        private void dgvTurler_SelectionChanged(object sender, EventArgs e)
        {
            button5.Enabled = true;
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
