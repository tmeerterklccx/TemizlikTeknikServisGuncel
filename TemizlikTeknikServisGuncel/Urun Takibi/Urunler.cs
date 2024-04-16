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
                MessageBox.Show("Başarıyla Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            VeriGetir();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            UrunKaydet urunKaydet = new UrunKaydet();
            urunKaydet.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {

            UrunGuncelle urunGuncelle = new UrunGuncelle();
            //urunGuncelle.afrm = this;
            urunGuncelle.textBox5.Text = dgvUrunler.CurrentRow.Cells[0].Value.ToString();
            urunGuncelle.ShowDialog();

        }
        private void VeriGetir()
        {
            string sorgu = "Select * from Urunler";
            Komutlar komutlar = new Komutlar();
            dgvUrunler.DataSource = komutlar.VeriDoldur(sorgu);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            VeriGetir();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Silmek İstediğinize Emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                string deger = dgvUrunler.CurrentRow.Cells[0].Value.ToString();
                int id = Convert.ToInt32(deger);
                string sorgu = "Delete from Urunler where Urun_ID =@ID";
                UrunCMD.Parameters.AddWithValue("@ID", id);
                KomutCalistir(sorgu);
                VeriGetir();
            }
        }
    }
}
