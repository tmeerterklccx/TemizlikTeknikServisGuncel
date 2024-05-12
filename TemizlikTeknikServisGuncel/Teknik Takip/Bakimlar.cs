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
using TemizlikTeknikServisGuncel.Musteri_Takibi;

namespace TemizlikTeknikServisGuncel
{
    public partial class Bakimlar : Form
    {

        SqlConnection SqlConnection = new SqlConnection(SQLBaglanti.BaglantiCumlesiGonder());
        SqlCommand bakimCMD = new SqlCommand();
        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
        public void KomutCalistir(string sorgu)
        {
            try
            {
                SqlConnection.Open();
                bakimCMD.CommandText = sorgu;
                bakimCMD.Connection = SqlConnection;
                bakimCMD.ExecuteNonQuery();
                MessageBox.Show("Başarıyla Silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                if (bakimCMD.Parameters.Count > 0)
                {
                    bakimCMD.Parameters.Clear();
                }
                SqlConnection.Close();
            }
        }

        private void VeriGetir()
        {
            string sorgu = "Select * from Bakimlar WHERE Statu=1";
            Komutlar komutlar = new Komutlar();
            dgvBakimlar.DataSource = komutlar.VeriDoldur(sorgu);
        }
        public Bakimlar()
        {
            InitializeComponent();
            BakimGuncelle bakimGuncelle = new BakimGuncelle();
            bakimGuncelle.afrm = this;
        }

        private void Bakimlar_Load(object sender, EventArgs e)
        {
            araBTN.Enabled = false;
            silBTN.Enabled = false;
            guncelleBTN.Enabled = false;
            VeriGetir();
        }

        private void listele_Click(object sender, EventArgs e)
        {
            VeriGetir();
        }

        private void sil_Click(object sender, EventArgs e)
        {
            string sorgu = "Update Bakimlar set Statu = @STATU WHERE Bakim_ID = @id";
            bakimCMD.Parameters.AddWithValue("@STATU", false);
            bakimCMD.Parameters.AddWithValue("@id", IDTBox.Text);
            if (MessageBox.Show("Silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                KomutCalistir(sorgu);
                VeriGetir();
            }
        }


        private void guncelle_Click(object sender, EventArgs e)
        {
            try
            {
                BakimGuncelle bakimGuncelle = new BakimGuncelle();
                bakimGuncelle.afrm = this;
                bakimGuncelle.IDTBox.Text = dgvBakimlar.CurrentRow.Cells[0].Value.ToString();
                bakimGuncelle.bilgiTBox.Text = dgvBakimlar.CurrentRow.Cells[4].Value.ToString();
                bakimGuncelle.tutarTBox.Text = dgvBakimlar.CurrentRow.Cells[5].Value.ToString();
                bakimGuncelle.tarihTBox.Text = dgvBakimlar.CurrentRow.Cells[6].Value.ToString();
                if (dgvBakimlar.CurrentRow.Cells[8].Value.ToString() == "True")
                {
                    bakimGuncelle.statuCMB.Text = "Aktif";

                }
                else if (dgvBakimlar.CurrentRow.Cells[8].Value.ToString() == "False")
                {
                    bakimGuncelle.statuCMB.Text = "Pasif";
                }
                bakimGuncelle.urun.Text = dgvBakimlar.CurrentRow.Cells[2].Value.ToString();
                bakimGuncelle.personeltc.Text = dgvBakimlar.CurrentRow.Cells[3].Value.ToString();
                bakimGuncelle.musteritc.Text = dgvBakimlar.CurrentRow.Cells[1].Value.ToString();
                bakimGuncelle.turr.Text = dgvBakimlar.CurrentRow.Cells[7].Value.ToString();
                bakimGuncelle.ShowDialog();
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void ekle_Click(object sender, EventArgs e)
        {
            BakimEkle bakimEkle = new BakimEkle();
            bakimEkle.Show();
            this.Close();
        }

        private void ara_Click(object sender, EventArgs e)
        {
            if (IDTBox.Text != "" || TCTBox.Text != "")
            {
                araBTN.Enabled = true;
                silBTN.Enabled = true;
                bakimCMD.CommandText = "SELECT * FROM Bakimlar WHERE Bakim_ID = @id OR Musteri_TC = @tc";
                bakimCMD.Connection = SqlConnection;
                bakimCMD.Connection.Open();
                bakimCMD.Parameters.Clear();
                bakimCMD.Parameters.AddWithValue("@id", IDTBox.Text);
                bakimCMD.Parameters.AddWithValue("@tc", TCTBox.Text);
                SqlDataReader reader = bakimCMD.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                dgvBakimlar.DataSource = dataTable;
                bakimCMD.Connection.Close();
            }
            else
            {
                araBTN.Enabled = false;
                silBTN.Enabled = false;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(IDTBox.Text) || !string.IsNullOrWhiteSpace(TCTBox.Text))
            {
                araBTN.Enabled = true;
                silBTN.Enabled = true;
                guncelleBTN.Enabled = true;
            }
            else
            {
                araBTN.Enabled = false;
                silBTN.Enabled = false;
                guncelleBTN.Enabled = false;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void otomasyonaGitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Otomasyon otomasyon = new Otomasyon();
            otomasyon.Show();
            this.Close();
        }

        private void çıkışYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkış yapmak istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }



        private void dgvBakimlar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IDTBox.Text = dgvBakimlar.CurrentRow.Cells[0].Value.ToString();
            TCTBox.Text = dgvBakimlar.CurrentRow.Cells[1].Value.ToString();
            guncelleBTN.Enabled = true;
        }

        private void dgvBakimlar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvBakimlar_SelectionChanged(object sender, EventArgs e)
        {
            IDTBox.Text = dgvBakimlar.CurrentRow.Cells[0].Value.ToString();
            TCTBox.Text = dgvBakimlar.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
