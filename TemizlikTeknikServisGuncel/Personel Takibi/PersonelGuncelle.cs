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
    public partial class PersonelGuncelle : Form
    {
        public Personeller afrm;
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
        public PersonelGuncelle()
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

        }

        private void PersonelGuncelle_Load(object sender, EventArgs e)
        {

        }

        private void çıkışYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkış yapmak istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
