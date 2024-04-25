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
    public partial class Bakimlar : Form
    {
        public Bakimlar afrm;
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
            string sorgu = "Select * from Bakimlar WHERE Statu=True";
            Komutlar komutlar = new Komutlar();
            dataGridView1.DataSource = komutlar.VeriDoldur(sorgu);
        }
        public Bakimlar()
        {
            InitializeComponent();
        }

        private void Bakimlar_Load(object sender, EventArgs e)
        {
            VeriGetir();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            VeriGetir();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string sorgu = "Update Bakimlar set Statu = @STATU WHERE Bakim_ID = @id";
            bakimCMD.Parameters.AddWithValue("@STATU", false);
            bakimCMD.Parameters.AddWithValue("@id", textBox1.Text);
            KomutCalistir(sorgu);
            VeriGetir();
        }

        private void dataGridView1_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BakimGuncelle bakimGuncelle = new BakimGuncelle();
            bakimGuncelle.afrm = this;
            bakimGuncelle.textBox5.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            bakimGuncelle.ShowDialog();
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            BakimEkle bakimEkle = new BakimEkle();
            bakimEkle.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" || textBox2.Text != "")
            {
                button1.Enabled = true;
                bakimCMD.CommandText = "SELECT * FROM Bakimlar WHERE Bakim_ID = @id OR Musteri_TC = @tc";
                bakimCMD.Connection = SqlConnection;
                bakimCMD.Connection.Open();
                bakimCMD.Parameters.Clear();
                bakimCMD.Parameters.AddWithValue("@id", textBox1.Text);
                bakimCMD.Parameters.AddWithValue("@tc", textBox2.Text);
                SqlDataReader reader = bakimCMD.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                dataGridView1.DataSource = dataTable;
                bakimCMD.Connection.Close();
            }
            else
            {
                button1.Enabled = false;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            //TÜR ARA
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
