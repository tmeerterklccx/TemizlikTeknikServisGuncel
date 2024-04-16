using Microsoft.Data.SqlClient;
using System.Data;

namespace TemizlikTeknikServisGuncel
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void çýkýþYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Uygulamadan Çýkýþ Yapýlsýn mý?", "Uyarý", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "1" && textBox2.Text == "1")
            {
                Otomasyon otomasyon = new Otomasyon();
                otomasyon.Show();
                
            }
        }
    }
}