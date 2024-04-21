﻿using Microsoft.Data.SqlClient;
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
    public partial class MarkaGuncelle : Form
    {
        public Markalar afrm;
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
                MessageBox.Show("Başarıyla Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        public MarkaGuncelle()
        {
            InitializeComponent();
        }

        private void otomasyonaGitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Otomasyon otomasyon = new Otomasyon();
            otomasyon.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sorgu = "Update Markalar set Marka_Ad = @MarkaAd WHERE Marka_ID = @MarkaID";
            MarkaCMD.Parameters.AddWithValue("@MarkaAd", textBox1.Text);
            MarkaCMD.Parameters.AddWithValue("@MarkaID", textBox2.Text);
            KomutCalistir(sorgu);
            Markalar markalar = new Markalar();
            markalar.Show();
            this.Close();
        }

        private void MarkaGuncelle_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                button1.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
            }
        }
    }
}