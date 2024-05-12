using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

        private void ekle_Click(object sender, EventArgs e)
        {
            PersonelEkle personelEkle = new PersonelEkle();
            personelEkle.Show();
            this.Close();
        }

        private void guncelle_Click(object sender, EventArgs e)
        {
            PersonelGuncelle personelGuncelle = new PersonelGuncelle();
            personelGuncelle.afrm = this;
            personelGuncelle.adTBox.Text = dgvPersoneller.CurrentRow.Cells[2].Value.ToString();
            personelGuncelle.soyadTBox.Text = dgvPersoneller.CurrentRow.Cells[3].Value.ToString();
            personelGuncelle.telTBox.Text = dgvPersoneller.CurrentRow.Cells[4].Value.ToString();
            personelGuncelle.ePostATBox.Text = dgvPersoneller.CurrentRow.Cells[5].Value.ToString();
            personelGuncelle.pozTBox.Text = dgvPersoneller.CurrentRow.Cells[7].Value.ToString();
            personelGuncelle.adresTextBox.Text = dgvPersoneller.CurrentRow.Cells[6].Value.ToString();
            personelGuncelle.tcTBox.Text = dgvPersoneller.CurrentRow.Cells[1].Value.ToString();
            personelGuncelle.rolTBox.Text = dgvPersoneller.CurrentRow.Cells[10].Value.ToString();
            personelGuncelle.sifreTBox.Text = dgvPersoneller.CurrentRow.Cells[8].Value.ToString();

            if (dgvPersoneller.CurrentRow.Cells[9].Value.ToString() == "True")
            {
                personelGuncelle.statuCBox.Text = "Aktif";

            }
            else if (dgvPersoneller.CurrentRow.Cells[9].Value.ToString() == "False")
            {
                personelGuncelle.statuCBox.Text = "Pasif";
            }
            personelGuncelle.ShowDialog();
            this.Close();

        }

        private void otomasyonaGitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Otomasyon otomasyon = new Otomasyon();
            otomasyon.Show();
            this.Close();
        }

        private void listele_Click(object sender, EventArgs e)
        {
            VeriGetir();
        }

        private void VeriGetir()
        {
            string sorgu = "select * from Calisanlar WHERE Statu=1";
            Komutlar komutlar = new Komutlar();
            dgvPersoneller.DataSource = VeriDoldur(sorgu);
        }
        private void Personeller_Load(object sender, EventArgs e)
        {
            VeriGetir();
            araBtn.Enabled = false;
            silBtn.Enabled = false;
            guncelleBtn.Enabled = false;
        }

        private void ara_Click(object sender, EventArgs e)
        {
            if (tcTBox.Text != "" || adTBox.Text != "")
            {
                araBtn.Enabled = true;
                silBtn.Enabled = true;
                perCMD.CommandText = "SELECT * FROM Calisanlar WHERE Ad = @ad OR Personel_TC = @tc";
                perCMD.Connection = SqlConnection;
                perCMD.Connection.Open();
                perCMD.Parameters.Clear();
                perCMD.Parameters.AddWithValue("@ad", adTBox.Text);
                perCMD.Parameters.AddWithValue("@tc", tcTBox.Text);
                SqlDataReader reader = perCMD.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                dgvPersoneller.DataSource = dataTable;
                perCMD.Connection.Close();
            }
            else
            {
                araBtn.Enabled = false;
            }
        }

        private void sil_Click(object sender, EventArgs e)
        {
            string sorgu = "Update Calisanlar set Statu = @STATU WHERE TC = @tc OR ID=@id";
            perCMD.Parameters.AddWithValue("@STATU", false);
            perCMD.Parameters.AddWithValue("@tc", tcTBox.Text);
            perCMD.Parameters.AddWithValue("@id", dgvPersoneller.CurrentRow.Cells[0].Value.ToString());
            if (MessageBox.Show("Silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                KomutCalistir(sorgu);
                VeriGetir();
            }
        }

        private void çıkışYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkış yapmak istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tcTBox.Text) || !string.IsNullOrWhiteSpace(adTBox.Text))
            {
                araBtn.Enabled = true;
                silBtn.Enabled = true;
                guncelleBtn.Enabled = true;
            }
            else
            {
                araBtn.Enabled = false;
                silBtn.Enabled = false;
                guncelleBtn.Enabled = false;
            }
        }



        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tcTBox.Text = dgvPersoneller.CurrentRow.Cells[0].Value.ToString();
            adTBox.Text = dgvPersoneller.CurrentRow.Cells[1].Value.ToString();
        }

        private void dgvPersoneller_SelectionChanged(object sender, EventArgs e)
        {
            tcTBox.Text = dgvPersoneller.CurrentRow.Cells[0].Value.ToString();
            adTBox.Text = dgvPersoneller.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
