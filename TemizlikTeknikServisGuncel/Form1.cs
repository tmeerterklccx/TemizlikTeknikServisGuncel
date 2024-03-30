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
            if (textBox1.Text == "Admin" && textBox2.Text == "12345")
            {
                
                Otomasyon otomasyon = new Otomasyon();
                otomasyon.Show();
            }
        }
    }
}