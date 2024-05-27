namespace TemizlikTeknikServisGuncel
{
    partial class Personeller
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            listeleBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            adTBox = new TextBox();
            tcTBox = new TextBox();
            menuStrip1 = new MenuStrip();
            programToolStripMenuItem = new ToolStripMenuItem();
            çıkışYapToolStripMenuItem = new ToolStripMenuItem();
            otomasyonaGitToolStripMenuItem = new ToolStripMenuItem();
            araBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            silBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            guncelleBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            ekleBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            dgvPersoneller = new MetroFramework.Controls.MetroGrid();
            label2 = new Label();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPersoneller).BeginInit();
            SuspendLayout();
            // 
            // listeleBtn
            // 
            listeleBtn.Depth = 0;
            listeleBtn.Location = new Point(12, 442);
            listeleBtn.MouseState = MaterialSkin.MouseState.HOVER;
            listeleBtn.Name = "listeleBtn";
            listeleBtn.Primary = true;
            listeleBtn.Size = new Size(502, 39);
            listeleBtn.TabIndex = 84;
            listeleBtn.Text = "LİSTEYİ GETİR";
            listeleBtn.UseVisualStyleBackColor = true;
            listeleBtn.Click += listele_Click;
            // 
            // adTBox
            // 
            adTBox.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            adTBox.Location = new Point(110, 400);
            adTBox.Name = "adTBox";
            adTBox.Size = new Size(154, 24);
            adTBox.TabIndex = 76;
            adTBox.TextChanged += textBox1_TextChanged;
            // 
            // tcTBox
            // 
            tcTBox.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            tcTBox.Location = new Point(109, 354);
            tcTBox.Name = "tcTBox";
            tcTBox.Size = new Size(154, 24);
            tcTBox.TabIndex = 75;
            tcTBox.TextChanged += textBox1_TextChanged;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { programToolStripMenuItem, otomasyonaGitToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(841, 24);
            menuStrip1.TabIndex = 77;
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
            // araBtn
            // 
            araBtn.Depth = 0;
            araBtn.Location = new Point(287, 347);
            araBtn.MouseState = MaterialSkin.MouseState.HOVER;
            araBtn.Name = "araBtn";
            araBtn.Primary = true;
            araBtn.Size = new Size(227, 71);
            araBtn.TabIndex = 85;
            araBtn.Text = "PERSONEL ARA";
            araBtn.UseVisualStyleBackColor = true;
            araBtn.Click += ara_Click;
            // 
            // silBtn
            // 
            silBtn.Depth = 0;
            silBtn.Location = new Point(531, 430);
            silBtn.MouseState = MaterialSkin.MouseState.HOVER;
            silBtn.Name = "silBtn";
            silBtn.Primary = true;
            silBtn.Size = new Size(292, 39);
            silBtn.TabIndex = 83;
            silBtn.Text = "PERSONEL SİL";
            silBtn.UseVisualStyleBackColor = true;
            silBtn.Click += sil_Click;
            // 
            // guncelleBtn
            // 
            guncelleBtn.Depth = 0;
            guncelleBtn.Location = new Point(531, 340);
            guncelleBtn.MouseState = MaterialSkin.MouseState.HOVER;
            guncelleBtn.Name = "guncelleBtn";
            guncelleBtn.Primary = true;
            guncelleBtn.Size = new Size(290, 39);
            guncelleBtn.TabIndex = 82;
            guncelleBtn.Text = "PERSONEL GÜNCELLE";
            guncelleBtn.UseVisualStyleBackColor = true;
            guncelleBtn.Click += guncelle_Click;
            // 
            // ekleBtn
            // 
            ekleBtn.Depth = 0;
            ekleBtn.Location = new Point(531, 385);
            ekleBtn.MouseState = MaterialSkin.MouseState.HOVER;
            ekleBtn.Name = "ekleBtn";
            ekleBtn.Primary = true;
            ekleBtn.Size = new Size(290, 39);
            ekleBtn.TabIndex = 81;
            ekleBtn.Text = "PERSONEL EKLE";
            ekleBtn.UseVisualStyleBackColor = true;
            ekleBtn.Click += ekle_Click;
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point);
            materialLabel2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialLabel2.Location = new Point(19, 406);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(33, 19);
            materialLabel2.TabIndex = 80;
            materialLabel2.Text = "AD:";
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point);
            materialLabel1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialLabel1.Location = new Point(19, 360);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(32, 19);
            materialLabel1.TabIndex = 79;
            materialLabel1.Text = "TC:";
            // 
            // dgvPersoneller
            // 
            dgvPersoneller.AllowUserToAddRows = false;
            dgvPersoneller.AllowUserToDeleteRows = false;
            dgvPersoneller.AllowUserToResizeRows = false;
            dgvPersoneller.BackgroundColor = Color.FromArgb(255, 255, 255);
            dgvPersoneller.BorderStyle = BorderStyle.None;
            dgvPersoneller.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvPersoneller.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvPersoneller.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvPersoneller.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(136, 136, 136);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgvPersoneller.DefaultCellStyle = dataGridViewCellStyle5;
            dgvPersoneller.EnableHeadersVisualStyles = false;
            dgvPersoneller.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dgvPersoneller.GridColor = Color.FromArgb(255, 255, 255);
            dgvPersoneller.Location = new Point(21, 100);
            dgvPersoneller.Name = "dgvPersoneller";
            dgvPersoneller.ReadOnly = true;
            dgvPersoneller.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgvPersoneller.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgvPersoneller.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvPersoneller.RowTemplate.Height = 25;
            dgvPersoneller.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPersoneller.Size = new Size(802, 234);
            dgvPersoneller.TabIndex = 78;
            dgvPersoneller.CellClick += dataGridView1_CellClick;
            dgvPersoneller.SelectionChanged += dgvPersoneller_SelectionChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonHighlight;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkCyan;
            label2.Location = new Point(307, 33);
            label2.Name = "label2";
            label2.Size = new Size(226, 30);
            label2.TabIndex = 69;
            label2.Text = "PERSONEL YÖNETİMİ";
            // 
            // Personeller
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(841, 491);
            Controls.Add(listeleBtn);
            Controls.Add(adTBox);
            Controls.Add(tcTBox);
            Controls.Add(menuStrip1);
            Controls.Add(araBtn);
            Controls.Add(silBtn);
            Controls.Add(guncelleBtn);
            Controls.Add(ekleBtn);
            Controls.Add(materialLabel2);
            Controls.Add(materialLabel1);
            Controls.Add(dgvPersoneller);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Personeller";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Personeller";
            Load += Personeller_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPersoneller).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton listeleBtn;
        private TextBox adTBox;
        private TextBox tcTBox;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem programToolStripMenuItem;
        private ToolStripMenuItem çıkışYapToolStripMenuItem;
        private ToolStripMenuItem otomasyonaGitToolStripMenuItem;
        private MaterialSkin.Controls.MaterialRaisedButton araBtn;
        private MaterialSkin.Controls.MaterialRaisedButton silBtn;
        private MaterialSkin.Controls.MaterialRaisedButton guncelleBtn;
        private MaterialSkin.Controls.MaterialRaisedButton ekleBtn;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MetroFramework.Controls.MetroGrid dgvPersoneller;
        private Label label2;
    }
}