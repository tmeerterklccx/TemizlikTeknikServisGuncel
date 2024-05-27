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

        private void ekle_Click(object sender, EventArgs e)
        {
            IzinEkle ızinEkle = new IzinEkle();
            ızinEkle.Show();
            this.Close();
        }

        private void guncelle_Click(object sender, EventArgs e)
        {
            IzinGuncelle izinGuncelle = new IzinGuncelle();
            izinGuncelle.afrm = this;
            izinGuncelle.personelTCBox.Text = dgvIzinler.CurrentRow.Cells[1].Value.ToString();
            izinGuncelle.turTBox.Text = dgvIzinler.CurrentRow.Cells[4].Value.ToString();
            izinGuncelle.BasTBox.Text = dgvIzinler.CurrentRow.Cells[2].Value.ToString();
            izinGuncelle.bitisTBOx.Text = dgvIzinler.CurrentRow.Cells[3].Value.ToString();
            izinGuncelle.IDTBox.Text = dgvIzinler.CurrentRow.Cells[0].Value.ToString();
            izinGuncelle.ShowDialog();
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
            string sorgu = "select * from Izinler WHERE Statu=1";
            Komutlar komutlar = new Komutlar();
            dgvIzinler.DataSource = VeriDoldur(sorgu);
        }

        private void Izinler_Load(object sender, EventArgs e)
        {
            araBTN.Enabled = false;
            silBTN.Enabled = false;
            guncelleBTN.Enabled = false;
            VeriGetir();
        }

        private void ara_Click(object sender, EventArgs e)
        {
            if (TCTBox.Text != "" || IDTBox.Text != "")
            {
                araBTN.Enabled = true;
                izinCMD.CommandText = "SELECT * FROM Izinler WHERE Izin_ID = @id OR Personel_TC = @tc";
                izinCMD.Connection = SqlConnection;
                izinCMD.Connection.Open();
                izinCMD.Parameters.Clear();
                izinCMD.Parameters.AddWithValue("@id", IDTBox.Text);
                izinCMD.Parameters.AddWithValue("@tc", TCTBox.Text);
                SqlDataReader reader = izinCMD.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                dgvIzinler.DataSource = dataTable;
                izinCMD.Connection.Close();
            }
            else
            {
                araBTN.Enabled = false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TCTBox.Text) || !string.IsNullOrWhiteSpace(IDTBox.Text))
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
            if (TCTBox.Text.Length > 11)
            {
                TCTBox.Text = TCTBox.Text.Substring(0, 11);
                TCTBox.SelectionStart = TCTBox.Text.Length;
            }
        }

        private void sil_Click(object sender, EventArgs e)
        {
            string sorgu = "Update Izinler set Statu = @STATU WHERE Izin_ID = @id";
            izinCMD.Parameters.AddWithValue("@STATU", false);
            izinCMD.Parameters.AddWithValue("@id", IDTBox.Text);
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



        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            IDTBox.Text = dgvIzinler.CurrentRow.Cells[0].Value.ToString();
            TCTBox.Text = dgvIzinler.CurrentRow.Cells[1].Value.ToString();
            guncelleBTN.Enabled = true;

        }

        private void dgvIzinler_SelectionChanged(object sender, EventArgs e)
        {
            IDTBox.Text = dgvIzinler.CurrentRow.Cells[0].Value.ToString();
            TCTBox.Text = dgvIzinler.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
