namespace TemizlikTeknikServisGuncel
{
    partial class Bakimlar
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
            araBTN = new MaterialSkin.Controls.MaterialRaisedButton();
            silBTN = new MaterialSkin.Controls.MaterialRaisedButton();
            guncelleBTN = new MaterialSkin.Controls.MaterialRaisedButton();
            ekleBTN = new MaterialSkin.Controls.MaterialRaisedButton();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            dgvBakimlar = new MetroFramework.Controls.MetroGrid();
            label2 = new Label();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBakimlar).BeginInit();
            SuspendLayout();
            // 
            // listeleBTN
            // 
            listeleBTN.Depth = 0;
            listeleBTN.Location = new Point(-6, 440);
            listeleBTN.MouseState = MaterialSkin.MouseState.HOVER;
            listeleBTN.Name = "listeleBTN";
            listeleBTN.Primary = true;
            listeleBTN.Size = new Size(502, 39);
            listeleBTN.TabIndex = 96;
            listeleBTN.Text = "LİSTEYİ GETİR";
            listeleBTN.UseVisualStyleBackColor = true;
            listeleBTN.Click += listele_Click;
            // 
            // TCTBox
            // 
            TCTBox.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            TCTBox.Location = new Point(92, 398);
            TCTBox.Name = "TCTBox";
            TCTBox.Size = new Size(154, 24);
            TCTBox.TabIndex = 88;
            TCTBox.TextChanged += textBox1_TextChanged;
            // 
            // IDTBox
            // 
            IDTBox.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            IDTBox.Location = new Point(92, 347);
            IDTBox.Name = "IDTBox";
            IDTBox.Size = new Size(154, 24);
            IDTBox.TabIndex = 87;
            IDTBox.TextChanged += textBox1_TextChanged;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { programToolStripMenuItem, otomasyonaGitToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(821, 24);
            menuStrip1.TabIndex = 89;
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
            // 
            // otomasyonaGitToolStripMenuItem
            // 
            otomasyonaGitToolStripMenuItem.Name = "otomasyonaGitToolStripMenuItem";
            otomasyonaGitToolStripMenuItem.Size = new Size(105, 20);
            otomasyonaGitToolStripMenuItem.Text = "Otomasyona Git";
            // 
            // araBTN
            // 
            araBTN.Depth = 0;
            araBTN.Location = new Point(269, 345);
            araBTN.MouseState = MaterialSkin.MouseState.HOVER;
            araBTN.Name = "araBTN";
            araBTN.Primary = true;
            araBTN.Size = new Size(227, 71);
            araBTN.TabIndex = 97;
            araBTN.Text = "BAKIM ARA";
            araBTN.UseVisualStyleBackColor = true;
            araBTN.Click += ara_Click;
            // 
            // silBTN
            // 
            silBTN.Depth = 0;
            silBTN.Location = new Point(513, 428);
            silBTN.MouseState = MaterialSkin.MouseState.HOVER;
            silBTN.Name = "silBTN";
            silBTN.Primary = true;
            silBTN.Size = new Size(292, 39);
            silBTN.TabIndex = 95;
            silBTN.Text = "BAKIM SİL";
            silBTN.UseVisualStyleBackColor = true;
            silBTN.Click += sil_Click;
            // 
            // guncelleBTN
            // 
            guncelleBTN.Depth = 0;
            guncelleBTN.Location = new Point(513, 338);
            guncelleBTN.MouseState = MaterialSkin.MouseState.HOVER;
            guncelleBTN.Name = "guncelleBTN";
            guncelleBTN.Primary = true;
            guncelleBTN.Size = new Size(290, 39);
            guncelleBTN.TabIndex = 94;
            guncelleBTN.Text = "BAKIM GÜNCELLE";
            guncelleBTN.UseVisualStyleBackColor = true;
            guncelleBTN.Click += guncelle_Click;
            // 
            // ekleBTN
            // 
            ekleBTN.Depth = 0;
            ekleBTN.Location = new Point(513, 383);
            ekleBTN.MouseState = MaterialSkin.MouseState.HOVER;
            ekleBTN.Name = "ekleBTN";
            ekleBTN.Primary = true;
            ekleBTN.Size = new Size(290, 39);
            ekleBTN.TabIndex = 93;
            ekleBTN.Text = "BAKIM EKLE";
            ekleBTN.UseVisualStyleBackColor = true;
            ekleBTN.Click += ekle_Click;
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point);
            materialLabel2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialLabel2.Location = new Point(1, 404);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(32, 19);
            materialLabel2.TabIndex = 92;
            materialLabel2.Text = "TC:";
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point);
            materialLabel1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialLabel1.Location = new Point(1, 352);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(27, 19);
            materialLabel1.TabIndex = 91;
            materialLabel1.Text = "ID:";
            // 
            // dgvBakimlar
            // 
            dgvBakimlar.AllowUserToAddRows = false;
            dgvBakimlar.AllowUserToDeleteRows = false;
            dgvBakimlar.AllowUserToResizeRows = false;
            dgvBakimlar.BackgroundColor = Color.FromArgb(255, 255, 255);
            dgvBakimlar.BorderStyle = BorderStyle.None;
            dgvBakimlar.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvBakimlar.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvBakimlar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvBakimlar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(136, 136, 136);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvBakimlar.DefaultCellStyle = dataGridViewCellStyle2;
            dgvBakimlar.EnableHeadersVisualStyles = false;
            dgvBakimlar.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dgvBakimlar.GridColor = Color.FromArgb(255, 255, 255);
            dgvBakimlar.Location = new Point(12, 67);
            dgvBakimlar.Name = "dgvBakimlar";
            dgvBakimlar.ReadOnly = true;
            dgvBakimlar.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvBakimlar.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvBakimlar.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvBakimlar.RowTemplate.Height = 25;
            dgvBakimlar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBakimlar.Size = new Size(802, 247);
            dgvBakimlar.TabIndex = 90;
            dgvBakimlar.CellClick += dgvBakimlar_CellClick;
            dgvBakimlar.CellContentClick += dgvBakimlar_CellContentClick;
            dgvBakimlar.SelectionChanged += dgvBakimlar_SelectionChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonHighlight;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkCyan;
            label2.Location = new Point(320, 34);
            label2.Name = "label2";
            label2.Size = new Size(190, 30);
            label2.TabIndex = 86;
            label2.Text = "BAKIM YÖNETİMİ";
            // 
            // Bakimlar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(821, 487);
            Controls.Add(listeleBTN);
            Controls.Add(TCTBox);
            Controls.Add(IDTBox);
            Controls.Add(menuStrip1);
            Controls.Add(araBTN);
            Controls.Add(silBTN);
            Controls.Add(guncelleBTN);
            Controls.Add(ekleBTN);
            Controls.Add(materialLabel2);
            Controls.Add(materialLabel1);
            Controls.Add(dgvBakimlar);
            Controls.Add(label2);
            Name = "Bakimlar";
            Text = "Bakimlar";
            Load += Bakimlar_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBakimlar).EndInit();
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
        private MaterialSkin.Controls.MaterialRaisedButton araBTN;
        private MaterialSkin.Controls.MaterialRaisedButton silBTN;
        private MaterialSkin.Controls.MaterialRaisedButton guncelleBTN;
        private MaterialSkin.Controls.MaterialRaisedButton ekleBTN;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MetroFramework.Controls.MetroGrid dgvBakimlar;
        private Label label2;
    }
}