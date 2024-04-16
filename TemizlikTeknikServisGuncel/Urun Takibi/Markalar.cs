using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace TemizlikTeknikServisGuncel
{

    public partial class Markalar : Form
    {
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
                MessageBox.Show("Başarıyla Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        public Markalar()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MarkaEkle markaEkle = new MarkaEkle();
            markaEkle.afrm = this;
            markaEkle.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MarkaGuncelle markaGuncelle = new MarkaGuncelle();
            markaGuncelle.afrm = this;
            markaGuncelle.textBox2.Text = dgvMarkalar.CurrentRow.Cells[0].Value.ToString();
            markaGuncelle.ShowDialog();

            this.Close();
        }

        private void otomasyonaGitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Otomasyon otomasyon = new Otomasyon();
            otomasyon.Show();
            this.Close();
        }
        private void BaslikGoster()
        {
            dgvMarkalar.Columns[0].HeaderText = "Marka ID";
            dgvMarkalar.Columns[0].Width = 200;
            dgvMarkalar.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvMarkalar.Columns[1].HeaderText = "Marka ADI";
            dgvMarkalar.Columns[1].Width = 350;
            dgvMarkalar.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            VeriGetir();
        }
        private void VeriGetir()
        {
            string sorgu = "Select * from Markalar";
            Komutlar komutlar = new Komutlar();
            dgvMarkalar.DataSource = komutlar.VeriDoldur(sorgu);
        }

        private void Markalar_Load(object sender, EventArgs e)
        {
            VeriGetir();
            BaslikGoster();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Silmek İstediğinize Emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                string deger = dgvMarkalar.CurrentRow.Cells[0].Value.ToString();
                int id = Convert.ToInt32(deger);
                string sorgu = "Delete from Markalar where Marka_ID =@MarkaID";
                MarkaCMD.Parameters.AddWithValue("@MarkaID", id);
                KomutCalistir(sorgu);
                VeriGetir();
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
