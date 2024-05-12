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
    public partial class Urunler : Form
    {
        SqlConnection SqlConnection = new SqlConnection(SQLBaglanti.BaglantiCumlesiGonder());
        SqlCommand UrunCMD = new SqlCommand();
        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
        public void KomutCalistir(string sorgu)
        {
            try
            {
                SqlConnection.Open();
                UrunCMD.CommandText = sorgu;
                UrunCMD.Connection = SqlConnection;
                UrunCMD.ExecuteNonQuery();
                MessageBox.Show("Başarıyla Silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                if (UrunCMD.Parameters.Count > 0)
                {
                    UrunCMD.Parameters.Clear();
                }
                SqlConnection.Close();
            }
        }
        public Urunler()
        {
            InitializeComponent();
        }

        private void Urunler_Load(object sender, EventArgs e)
        {
            araBTN.Enabled = false;
            silBTN.Enabled = false;
            guncellBTN.Enabled = false;
            VeriGetir();
        }

        private void ekle_Click(object sender, EventArgs e)
        {
            this.Close();
            UrunKaydet urunKaydet = new UrunKaydet();
            urunKaydet.Show();

        }

        private void guncelle_Click(object sender, EventArgs e)
        {

            UrunGuncelle urunGuncelle = new UrunGuncelle();
            urunGuncelle.afrm = this;
            urunGuncelle.IDTBox.Text = dgvUrunler.CurrentRow.Cells[0].Value.ToString();
            urunGuncelle.urunAdiTBox.Text = dgvUrunler.CurrentRow.Cells[1].Value.ToString();
            urunGuncelle.bilgiTBox.Text = dgvUrunler.CurrentRow.Cells[2].Value.ToString();
            urunGuncelle.markaidd.Text = dgvUrunler.CurrentRow.Cells[3].Value.ToString();
            urunGuncelle.turid.Text = dgvUrunler.CurrentRow.Cells[4].Value.ToString();
            urunGuncelle.yilTBox.Text = dgvUrunler.CurrentRow.Cells[5].Value.ToString();
            urunGuncelle.ShowDialog();
            this.Close();

        }
        private void VeriGetir()
        {
            string sorgu = "Select * from Urunler";
            Komutlar komutlar = new Komutlar();
            dgvUrunler.DataSource = komutlar.VeriDoldur(sorgu);
        }
        private void listele_Click(object sender, EventArgs e)
        {
            VeriGetir();
        }

        private void sil_Click(object sender, EventArgs e)
        {

            string sorgu = "Delete from Urunler where Urun_ID =@ID";
            UrunCMD.Parameters.AddWithValue("@ID", IDTBox.Text);
            if (MessageBox.Show("Silmek İstediğinize Emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                KomutCalistir(sorgu);
                VeriGetir();
            }

        }

        private void otomasyonaGitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Otomasyon otomasyon = new Otomasyon();
            otomasyon.Show();
            this.Close();
        }

        private void ara_Click(object sender, EventArgs e)
        {
            if (IDTBox.Text != "" || TCTBox.Text != "")
            {
                araBTN.Enabled = true;
                UrunCMD.CommandText = "SELECT * FROM Urunler WHERE Urun_ID = @urunID OR Urun_Ad = @urunAd";
                UrunCMD.Connection = SqlConnection;
                UrunCMD.Connection.Open();
                UrunCMD.Parameters.Clear();
                UrunCMD.Parameters.AddWithValue("@urunID", IDTBox.Text);
                UrunCMD.Parameters.AddWithValue("@urunAd", TCTBox.Text);
                SqlDataReader reader = UrunCMD.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                dgvUrunler.DataSource = dataTable;
                UrunCMD.Connection.Close();
            }
            else
            {
                araBTN.Enabled = false;
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(IDTBox.Text) || !string.IsNullOrWhiteSpace(TCTBox.Text))
            {
                araBTN.Enabled = true;
                silBTN.Enabled = true;
                guncellBTN.Enabled = true;
            }
            else
            {
                araBTN.Enabled = false;
                silBTN.Enabled = false;
                guncellBTN.Enabled = false;
            }
        }

        private void çıkışYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkış yapmak istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }



        private void dgvUrunler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IDTBox.Text = dgvUrunler.CurrentRow.Cells[0].Value.ToString();
            TCTBox.Text = dgvUrunler.CurrentRow.Cells[1].Value.ToString();
            silBTN.Enabled = true;
        }

        private void dgvUrunler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvUrunler_SelectionChanged(object sender, EventArgs e)
        {

            araBTN.Enabled = false;
            silBTN.Enabled = false;
            guncellBTN.Enabled = false;
            IDTBox.Text = dgvUrunler.CurrentRow.Cells[0].Value.ToString();
            TCTBox.Text = dgvUrunler.CurrentRow.Cells[1].Value.ToString();

        }
    }
}
