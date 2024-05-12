namespace TemizlikTeknikServisGuncel.Musteri_Takibi
{
    partial class Musteriler
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            araBTN = new MaterialSkin.Controls.MaterialRaisedButton();
            silBTN = new MaterialSkin.Controls.MaterialRaisedButton();
            guncelleBTN = new MaterialSkin.Controls.MaterialRaisedButton();
            ekleBTN = new MaterialSkin.Controls.MaterialRaisedButton();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            otomasyonaGitToolStripMenuItem = new ToolStripMenuItem();
            çıkışYapToolStripMenuItem = new ToolStripMenuItem();
            programToolStripMenuItem = new ToolStripMenuItem();
            listeleBTN = new MaterialSkin.Controls.MaterialRaisedButton();
            dgvMusteriler = new MetroFramework.Controls.MetroGrid();
            adTBox = new TextBox();
            tcTBox = new TextBox();
            button5 = new Button();
            button4 = new Button();
            button2 = new Button();
            button1 = new Button();
            button3 = new Button();
            label2 = new Label();
            menuStrip1 = new MenuStrip();
            ((System.ComponentModel.ISupportInitialize)dgvMusteriler).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // araBTN
            // 
            araBTN.Depth = 0;
            araBTN.Location = new Point(287, 335);
            araBTN.MouseState = MaterialSkin.MouseState.HOVER;
            araBTN.Name = "araBTN";
            araBTN.Primary = true;
            araBTN.Size = new Size(227, 71);
            araBTN.TabIndex = 68;
            araBTN.Text = "MÜŞTERİ ARA";
            araBTN.UseVisualStyleBackColor = true;
            araBTN.Click += ara_Click;
            // 
            // silBTN
            // 
            silBTN.Depth = 0;
            silBTN.Location = new Point(531, 418);
            silBTN.MouseState = MaterialSkin.MouseState.HOVER;
            silBTN.Name = "silBTN";
            silBTN.Primary = true;
            silBTN.Size = new Size(292, 39);
            silBTN.TabIndex = 66;
            silBTN.Text = "MÜŞTERİ SİL";
            silBTN.UseVisualStyleBackColor = true;
            silBTN.Click += sil_Click;
            // 
            // guncelleBTN
            // 
            guncelleBTN.Depth = 0;
            guncelleBTN.Location = new Point(531, 328);
            guncelleBTN.MouseState = MaterialSkin.MouseState.HOVER;
            guncelleBTN.Name = "guncelleBTN";
            guncelleBTN.Primary = true;
            guncelleBTN.Size = new Size(290, 39);
            guncelleBTN.TabIndex = 65;
            guncelleBTN.Text = "MÜŞTERİ GÜNCELLE";
            guncelleBTN.UseVisualStyleBackColor = true;
            guncelleBTN.Click += guncelle_Click;
            // 
            // ekleBTN
            // 
            ekleBTN.Depth = 0;
            ekleBTN.Location = new Point(531, 373);
            ekleBTN.MouseState = MaterialSkin.MouseState.HOVER;
            ekleBTN.Name = "ekleBTN";
            ekleBTN.Primary = true;
            ekleBTN.Size = new Size(290, 39);
            ekleBTN.TabIndex = 64;
            ekleBTN.Text = "MÜŞTERİ EKLE";
            ekleBTN.UseVisualStyleBackColor = true;
            ekleBTN.Click += ekle_Click;
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point);
            materialLabel2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialLabel2.Location = new Point(19, 394);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(33, 19);
            materialLabel2.TabIndex = 63;
            materialLabel2.Text = "AD:";
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point);
            materialLabel1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialLabel1.Location = new Point(20, 335);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(32, 19);
            materialLabel1.TabIndex = 62;
            materialLabel1.Text = "TC:";
            // 
            // otomasyonaGitToolStripMenuItem
            // 
            otomasyonaGitToolStripMenuItem.Name = "otomasyonaGitToolStripMenuItem";
            otomasyonaGitToolStripMenuItem.Size = new Size(105, 20);
            otomasyonaGitToolStripMenuItem.Text = "Otomasyona Git";
            otomasyonaGitToolStripMenuItem.Click += otomasyonaGitToolStripMenuItem_Click;
            // 
            // çıkışYapToolStripMenuItem
            // 
            çıkışYapToolStripMenuItem.Name = "çıkışYapToolStripMenuItem";
            çıkışYapToolStripMenuItem.Size = new Size(121, 22);
            çıkışYapToolStripMenuItem.Text = "Çıkış Yap";
            çıkışYapToolStripMenuItem.Click += çıkışYapToolStripMenuItem_Click;
            // 
            // programToolStripMenuItem
            // 
            programToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { çıkışYapToolStripMenuItem });
            programToolStripMenuItem.Name = "programToolStripMenuItem";
            programToolStripMenuItem.Size = new Size(65, 20);
            programToolStripMenuItem.Text = "&Program";
            // 
            // listeleBTN
            // 
            listeleBTN.Depth = 0;
            listeleBTN.Location = new Point(12, 430);
            listeleBTN.MouseState = MaterialSkin.MouseState.HOVER;
            listeleBTN.Name = "listeleBTN";
            listeleBTN.Primary = true;
            listeleBTN.Size = new Size(502, 39);
            listeleBTN.TabIndex = 67;
            listeleBTN.Text = "LİSTEYİ GETİR";
            listeleBTN.UseVisualStyleBackColor = true;
            listeleBTN.Click += listele_Click;
            // 
            // dgvMusteriler
            // 
            dgvMusteriler.AllowUserToAddRows = false;
            dgvMusteriler.AllowUserToDeleteRows = false;
            dgvMusteriler.AllowUserToResizeRows = false;
            dgvMusteriler.BackgroundColor = Color.FromArgb(255, 255, 255);
            dgvMusteriler.BorderStyle = BorderStyle.None;
            dgvMusteriler.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvMusteriler.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvMusteriler.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvMusteriler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(136, 136, 136);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvMusteriler.DefaultCellStyle = dataGridViewCellStyle2;
            dgvMusteriler.EnableHeadersVisualStyles = false;
            dgvMusteriler.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dgvMusteriler.GridColor = Color.FromArgb(255, 255, 255);
            dgvMusteriler.Location = new Point(21, 80);
            dgvMusteriler.Name = "dgvMusteriler";
            dgvMusteriler.ReadOnly = true;
            dgvMusteriler.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvMusteriler.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvMusteriler.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvMusteriler.RowTemplate.Height = 25;
            dgvMusteriler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMusteriler.Size = new Size(802, 242);
            dgvMusteriler.TabIndex = 61;
            dgvMusteriler.CellClick += dgvMusteriler_CellClick;
            dgvMusteriler.SelectionChanged += dgvMusteriler_SelectionChanged;
            // 
            // adTBox
            // 
            adTBox.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            adTBox.Location = new Point(110, 388);
            adTBox.Name = "adTBox";
            adTBox.Size = new Size(154, 24);
            adTBox.TabIndex = 59;
            adTBox.TextChanged += textBox1_TextChanged;
            // 
            // tcTBox
            // 
            tcTBox.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            tcTBox.Location = new Point(110, 329);
            tcTBox.Name = "tcTBox";
            tcTBox.Size = new Size(154, 24);
            tcTBox.TabIndex = 58;
            tcTBox.TextChanged += textBox1_TextChanged;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button5.Location = new Point(686, 167);
            button5.Name = "button5";
            button5.Size = new Size(135, 53);
            button5.TabIndex = 57;
            button5.Text = "MÜŞTERİ SİL";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button4.Location = new Point(476, 235);
            button4.Name = "button4";
            button4.Size = new Size(135, 53);
            button4.TabIndex = 56;
            button4.Text = "MÜŞTERİ GÜNCELLE";
            button4.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button2.Location = new Point(489, 211);
            button2.Name = "button2";
            button2.Size = new Size(135, 53);
            button2.TabIndex = 55;
            button2.Text = "MÜŞTERİ EKLE";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button1.Location = new Point(542, 235);
            button1.Name = "button1";
            button1.Size = new Size(135, 53);
            button1.TabIndex = 54;
            button1.Text = "MÜŞTERİ ARA";
            button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button3.Location = new Point(395, 167);
            button3.Name = "button3";
            button3.Size = new Size(135, 53);
            button3.TabIndex = 53;
            button3.Text = "LİSTEYİ GETİR";
            button3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonHighlight;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkCyan;
            label2.Location = new Point(318, 34);
            label2.Name = "label2";
            label2.Size = new Size(212, 30);
            label2.TabIndex = 52;
            label2.Text = "MÜŞTERİ YÖNETİMİ";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { programToolStripMenuItem, otomasyonaGitToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(835, 24);
            menuStrip1.TabIndex = 60;
            menuStrip1.Text = "menuStrip1";
            // 
            // Musteriler
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(835, 478);
            Controls.Add(araBTN);
            Controls.Add(silBTN);
            Controls.Add(guncelleBTN);
            Controls.Add(ekleBTN);
            Controls.Add(materialLabel2);
            Controls.Add(materialLabel1);
            Controls.Add(listeleBTN);
            Controls.Add(dgvMusteriler);
            Controls.Add(adTBox);
            Controls.Add(tcTBox);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(button3);
            Controls.Add(label2);
            Controls.Add(menuStrip1);
            Name = "Musteriler";
            Text = "Musteriler";
            Load += Musteriler_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMusteriler).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton araBTN;
        private MaterialSkin.Controls.MaterialRaisedButton silBTN;
        private MaterialSkin.Controls.MaterialRaisedButton guncelleBTN;
        private MaterialSkin.Controls.MaterialRaisedButton ekleBTN;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private ToolStripMenuItem otomasyonaGitToolStripMenuItem;
        private ToolStripMenuItem çıkışYapToolStripMenuItem;
        private ToolStripMenuItem programToolStripMenuItem;
        private MaterialSkin.Controls.MaterialRaisedButton listeleBTN;
        private MetroFramework.Controls.MetroGrid dgvMusteriler;
        private TextBox adTBox;
        private TextBox tcTBox;
        private Button button5;
        private Button button4;
        private Button button2;
        private Button button1;
        private Button button3;
        private Label label2;
        private MenuStrip menuStrip1;
    }
}