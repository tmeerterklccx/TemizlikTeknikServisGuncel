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
            araBTN.Enabled = false;
            silBTN.Enabled = false;
            guncelleBTN.Enabled = false;
            VeriGetir();
        }

        private void ekle_Click(object sender, EventArgs e)
        {
            MusteriEkle musteriEkle = new MusteriEkle();
            musteriEkle.Show();
            this.Close();
        }

        private void guncelle_Click(object sender, EventArgs e)
        {
            MusteriGuncelle musteriGuncelle = new MusteriGuncelle();
            musteriGuncelle.afrm = this;
            musteriGuncelle.tcTBox.Text = dgvMusteriler.CurrentRow.Cells[0].Value.ToString();
            musteriGuncelle.adTBox.Text = dgvMusteriler.CurrentRow.Cells[1].Value.ToString();
            musteriGuncelle.soyadTBox.Text = dgvMusteriler.CurrentRow.Cells[2].Value.ToString();
            musteriGuncelle.telTBox.Text = dgvMusteriler.CurrentRow.Cells[3].Value.ToString();
            musteriGuncelle.ePostATBox.Text = dgvMusteriler.CurrentRow.Cells[4].Value.ToString();
            musteriGuncelle.adresTextBox.Text = dgvMusteriler.CurrentRow.Cells[5].Value.ToString();

            if (dgvMusteriler.CurrentRow.Cells[6].Value.ToString() == "True")
            {
                musteriGuncelle.statuCBox.SelectedIndex = 0;
            }
            else if (dgvMusteriler.CurrentRow.Cells[6].Value.ToString() == "False")
            {
                musteriGuncelle.statuCBox.SelectedIndex = 1;
            }
            musteriGuncelle.ShowDialog();
            this.Close();
        }
        private void VeriGetir()
        {
            string sorgu = "SELECT * FROM Musteriler WHERE Statu = 1";
            Komutlar komutlar = new Komutlar();
            dgvMusteriler.DataSource = komutlar.VeriDoldur(sorgu);
        }

        private void listele_Click(object sender, EventArgs e)
        {
            VeriGetir();
        }



        private void sil_Click(object sender, EventArgs e)
        {
            string sorgu = "Update Musteriler set Statu = @STATU WHERE Musteri_TC = @tc";
            musteriCMD.Parameters.AddWithValue("@STATU", false);
            musteriCMD.Parameters.AddWithValue("@tc", tcTBox.Text);
            if (MessageBox.Show("Silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                KomutCalistir(sorgu);
                VeriGetir();
            }

        }

        private void ara_Click(object sender, EventArgs e)
        {
            if (tcTBox.Text != "" || adTBox.Text != "")
            {
                button1.Enabled = true;
                musteriCMD.CommandText = "SELECT * FROM Musteriler WHERE Musteri_TC = @tc OR Ad = @ad";
                musteriCMD.Connection = SqlConnection;
                musteriCMD.Connection.Open();
                musteriCMD.Parameters.Clear();
                musteriCMD.Parameters.AddWithValue("@tc", tcTBox.Text);
                musteriCMD.Parameters.AddWithValue("@ad", adTBox.Text);
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
            if (!string.IsNullOrWhiteSpace(tcTBox.Text) || !string.IsNullOrWhiteSpace(adTBox.Text))
            {
                araBTN.Enabled = true;
                guncelleBTN.Enabled = true;
                silBTN.Enabled = true;
            }
            else
            {
                araBTN.Enabled = false;
                guncelleBTN.Enabled = false;
                silBTN.Enabled = false;
            }
            if (tcTBox.Text.Length > 11)
            {
                tcTBox.Text = tcTBox.Text.Substring(0, 11);
                tcTBox.SelectionStart = tcTBox.Text.Length;
            }
        }

        private void otomasyonaGitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Otomasyon otomasyon = new Otomasyon();
            otomasyon.Show();
            this.Close();
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

        private void dgvMusteriler_Click(object sender, EventArgs e)
        {

        }



        private void dgvMusteriler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tcTBox.Text = dgvMusteriler.CurrentRow.Cells[0].Value.ToString();
            adTBox.Text = dgvMusteriler.CurrentRow.Cells[1].Value.ToString();
            button4.Enabled = true;
        }

        private void dgvMusteriler_SelectionChanged(object sender, EventArgs e)
        {
            tcTBox.Text = dgvMusteriler.CurrentRow.Cells[0].Value.ToString();
            adTBox.Text = dgvMusteriler.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
