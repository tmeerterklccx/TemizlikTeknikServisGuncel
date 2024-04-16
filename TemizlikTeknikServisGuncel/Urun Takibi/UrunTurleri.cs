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
            dgvMarkalar.Columns[0].HeaderText = "Tur ID";
            dgvMarkalar.Columns[0].Width = 200;
            dgvMarkalar.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvMarkalar.Columns[1].HeaderText = "Tur ADI";
            dgvMarkalar.Columns[1].Width = 350;
            dgvMarkalar.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
        }
        private void VeriGetir()
        {
            Komutlar komutlar = new Komutlar();
            string sorgu = "Select * From Urun_Turleri";
            dgvMarkalar.DataSource = komutlar.VeriDoldur(sorgu);
        }

        private void UrunTurleri_Load_1(object sender, EventArgs e)
        {
            VeriGetir();
            //BaslikGoster();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Komutlar komutlar = new Komutlar();
            string sorgu = "Select * From Urun_Turleri";
            dgvMarkalar.DataSource = komutlar.VeriDoldur(sorgu);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Silmek İstediğinize Emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                string deger = dgvMarkalar.CurrentRow.Cells[0].Value.ToString();
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
            turGuncelle.textBox2.Text = dgvMarkalar.CurrentRow.Cells[0].Value.ToString();
            turGuncelle.ShowDialog();
        }
    }
}
