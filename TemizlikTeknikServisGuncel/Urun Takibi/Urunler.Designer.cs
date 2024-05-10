namespace TemizlikTeknikServisGuncel
{
    partial class Urunler
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
            listeleBTN = new MaterialSkin.Controls.MaterialRaisedButton();
            TCTBox = new TextBox();
            IDTBox = new TextBox();
            menuStrip1 = new MenuStrip();
            programToolStripMenuItem = new ToolStripMenuItem();
            çıkışYapToolStripMenuItem = new ToolStripMenuItem();
            otomasyonaGitToolStripMenuItem = new ToolStripMenuItem();
            dgvUrunler = new MetroFramework.Controls.MetroGrid();
            araBTN = new MaterialSkin.Controls.MaterialRaisedButton();
            silBTN = new MaterialSkin.Controls.MaterialRaisedButton();
            guncellBTN = new MaterialSkin.Controls.MaterialRaisedButton();
            ekleBTN = new MaterialSkin.Controls.MaterialRaisedButton();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            label2 = new Label();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUrunler).BeginInit();
            SuspendLayout();
            // 
            // listeleBTN
            // 
            listeleBTN.Depth = 0;
            listeleBTN.Location = new Point(12, 459);
            listeleBTN.MouseState = MaterialSkin.MouseState.HOVER;
            listeleBTN.Name = "listeleBTN";
            listeleBTN.Primary = true;
            listeleBTN.Size = new Size(502, 39);
            listeleBTN.TabIndex = 108;
            listeleBTN.Text = "LİSTEYİ GETİR";
            listeleBTN.UseVisualStyleBackColor = true;
            listeleBTN.Click += listele_Click;
            // 
            // TCTBox
            // 
            TCTBox.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            TCTBox.Location = new Point(110, 417);
            TCTBox.Name = "TCTBox";
            TCTBox.Size = new Size(154, 24);
            TCTBox.TabIndex = 100;
            TCTBox.TextChanged += textBox1_TextChanged;
            // 
            // IDTBox
            // 
            IDTBox.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            IDTBox.Location = new Point(110, 368);
            IDTBox.Name = "IDTBox";
            IDTBox.Size = new Size(154, 24);
            IDTBox.TabIndex = 99;
            IDTBox.TextChanged += textBox1_TextChanged;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { programToolStripMenuItem, otomasyonaGitToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(835, 24);
            menuStrip1.TabIndex = 101;
            menuStrip1.Text = "menuStrip1";
            // 
            // programToolStripMenuItem
            // 
            programToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { çıkışYapToolStripMenuItem });
            programToolStripMenuItem.Name = "programToolStripMenuItem";
            programToolStripMenuItem.Size = new Size(65, 20);
            programToolStripMenuItem.Text = "&Program";
            // 
            // çıkışYapToolStripMenuItem
            // 
            çıkışYapToolStripMenuItem.Name = "çıkışYapToolStripMenuItem";
            çıkışYapToolStripMenuItem.Size = new Size(121, 22);
            çıkışYapToolStripMenuItem.Text = "Çıkış Yap";
            çıkışYapToolStripMenuItem.Click += çıkışYapToolStripMenuItem_Click;
            // 
            // otomasyonaGitToolStripMenuItem
            // 
            otomasyonaGitToolStripMenuItem.Name = "otomasyonaGitToolStripMenuItem";
            otomasyonaGitToolStripMenuItem.Size = new Size(105, 20);
            otomasyonaGitToolStripMenuItem.Text = "Otomasyona Git";
            otomasyonaGitToolStripMenuItem.Click += otomasyonaGitToolStripMenuItem_Click;
            // 
            // dgvUrunler
            // 
            dgvUrunler.AllowUserToAddRows = false;
            dgvUrunler.AllowUserToDeleteRows = false;
            dgvUrunler.AllowUserToResizeRows = false;
            dgvUrunler.BackgroundColor = Color.FromArgb(255, 255, 255);
            dgvUrunler.BorderStyle = BorderStyle.None;
            dgvUrunler.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvUrunler.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvUrunler.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvUrunler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(136, 136, 136);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvUrunler.DefaultCellStyle = dataGridViewCellStyle2;
            dgvUrunler.EnableHeadersVisualStyles = false;
            dgvUrunler.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dgvUrunler.GridColor = Color.FromArgb(255, 255, 255);
            dgvUrunler.Location = new Point(19, 95);
            dgvUrunler.Name = "dgvUrunler";
            dgvUrunler.ReadOnly = true;
            dgvUrunler.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvUrunler.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvUrunler.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvUrunler.RowTemplate.Height = 25;
            dgvUrunler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUrunler.Size = new Size(802, 248);
            dgvUrunler.TabIndex = 102;
            // 
            // araBTN
            // 
            araBTN.Depth = 0;
            araBTN.Location = new Point(287, 371);
            araBTN.MouseState = MaterialSkin.MouseState.HOVER;
            araBTN.Name = "araBTN";
            araBTN.Primary = true;
            araBTN.Size = new Size(227, 71);
            araBTN.TabIndex = 109;
            araBTN.Text = "ÜRÜN ARA";
            araBTN.UseVisualStyleBackColor = true;
            araBTN.Click += ara_Click;
            // 
            // silBTN
            // 
            silBTN.Depth = 0;
            silBTN.Location = new Point(531, 458);
            silBTN.MouseState = MaterialSkin.MouseState.HOVER;
            silBTN.Name = "silBTN";
            silBTN.Primary = true;
            silBTN.Size = new Size(292, 39);
            silBTN.TabIndex = 107;
            silBTN.Text = "ÜRÜN SİL";
            silBTN.UseVisualStyleBackColor = true;
            silBTN.Click += sil_Click;
            // 
            // guncellBTN
            // 
            guncellBTN.Depth = 0;
            guncellBTN.Location = new Point(531, 368);
            guncellBTN.MouseState = MaterialSkin.MouseState.HOVER;
            guncellBTN.Name = "guncellBTN";
            guncellBTN.Primary = true;
            guncellBTN.Size = new Size(290, 39);
            guncellBTN.TabIndex = 106;
            guncellBTN.Text = "ÜRÜN GÜNCELLE";
            guncellBTN.UseVisualStyleBackColor = true;
            guncellBTN.Click += guncelle_Click;
            // 
            // ekleBTN
            // 
            ekleBTN.Depth = 0;
            ekleBTN.Location = new Point(531, 413);
            ekleBTN.MouseState = MaterialSkin.MouseState.HOVER;
            ekleBTN.Name = "ekleBTN";
            ekleBTN.Primary = true;
            ekleBTN.Size = new Size(290, 39);
            ekleBTN.TabIndex = 105;
            ekleBTN.Text = "ÜRÜN EKLE";
            ekleBTN.UseVisualStyleBackColor = true;
            ekleBTN.Click += ekle_Click;
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point);
            materialLabel2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialLabel2.Location = new Point(19, 423);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(32, 19);
            materialLabel2.TabIndex = 104;
            materialLabel2.Text = "TC:";
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point);
            materialLabel1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialLabel1.Location = new Point(20, 374);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(27, 19);
            materialLabel1.TabIndex = 103;
            materialLabel1.Text = "ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonHighlight;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkCyan;
            label2.Location = new Point(330, 37);
            label2.Name = "label2";
            label2.Size = new Size(184, 32);
            label2.TabIndex = 98;
            label2.Text = "ÜRÜN YÖNETİMİ";
            // 
            // Urunler
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(835, 509);
            Controls.Add(listeleBTN);
            Controls.Add(TCTBox);
            Controls.Add(IDTBox);
            Controls.Add(menuStrip1);
            Controls.Add(dgvUrunler);
            Controls.Add(araBTN);
            Controls.Add(silBTN);
            Controls.Add(guncellBTN);
            Controls.Add(ekleBTN);
            Controls.Add(materialLabel2);
            Controls.Add(materialLabel1);
            Controls.Add(label2);
            Name = "Urunler";
            Text = "Urunler";
            Load += Urunler_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUrunler).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton listeleBTN;
        private TextBox TCTBox;
        private TextBox IDTBox;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem programToolStripMenuItem;
        private ToolStripMenuItem çıkışYapToolStripMenuItem;
        private ToolStripMenuItem otomasyonaGitToolStripMenuItem;
        private MetroFramework.Controls.MetroGrid dgvUrunler;
        private MaterialSkin.Controls.MaterialRaisedButton araBTN;
        private MaterialSkin.Controls.MaterialRaisedButton silBTN;
        private MaterialSkin.Controls.MaterialRaisedButton guncellBTN;
        private MaterialSkin.Controls.MaterialRaisedButton ekleBTN;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private Label label2;
    }
}