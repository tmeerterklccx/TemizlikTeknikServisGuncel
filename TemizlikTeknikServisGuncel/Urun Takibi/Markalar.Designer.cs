﻿namespace TemizlikTeknikServisGuncel
{
    partial class Markalar
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
            listeleBTN = new MaterialSkin.Controls.MaterialRaisedButton();
            ADTBox = new TextBox();
            IDTBox = new TextBox();
            menuStrip1 = new MenuStrip();
            programToolStripMenuItem = new ToolStripMenuItem();
            çıkışYapToolStripMenuItem = new ToolStripMenuItem();
            otomasyonaGitToolStripMenuItem = new ToolStripMenuItem();
            dgvMarkalar = new MetroFramework.Controls.MetroGrid();
            araBTN = new MaterialSkin.Controls.MaterialRaisedButton();
            silBTN = new MaterialSkin.Controls.MaterialRaisedButton();
            guncelleBTN = new MaterialSkin.Controls.MaterialRaisedButton();
            ekleBTN = new MaterialSkin.Controls.MaterialRaisedButton();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            label2 = new Label();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMarkalar).BeginInit();
            SuspendLayout();
            // 
            // listeleBTN
            // 
            listeleBTN.Depth = 0;
            listeleBTN.Location = new Point(12, 444);
            listeleBTN.MouseState = MaterialSkin.MouseState.HOVER;
            listeleBTN.Name = "listeleBTN";
            listeleBTN.Primary = true;
            listeleBTN.Size = new Size(502, 39);
            listeleBTN.TabIndex = 120;
            listeleBTN.Text = "LİSTEYİ GETİR";
            listeleBTN.UseVisualStyleBackColor = true;
            listeleBTN.Click += listele_Click;
            // 
            // ADTBox
            // 
            ADTBox.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            ADTBox.Location = new Point(110, 402);
            ADTBox.Name = "ADTBox";
            ADTBox.Size = new Size(154, 24);
            ADTBox.TabIndex = 112;
            ADTBox.TextChanged += textBox1_TextChanged;
            // 
            // IDTBox
            // 
            IDTBox.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            IDTBox.Location = new Point(110, 343);
            IDTBox.Name = "IDTBox";
            IDTBox.Size = new Size(154, 24);
            IDTBox.TabIndex = 111;
            IDTBox.TextChanged += textBox1_TextChanged;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { programToolStripMenuItem, otomasyonaGitToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(852, 24);
            menuStrip1.TabIndex = 113;
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
            // dgvMarkalar
            // 
            dgvMarkalar.AllowUserToAddRows = false;
            dgvMarkalar.AllowUserToDeleteRows = false;
            dgvMarkalar.AllowUserToResizeRows = false;
            dgvMarkalar.BackgroundColor = Color.FromArgb(255, 255, 255);
            dgvMarkalar.BorderStyle = BorderStyle.None;
            dgvMarkalar.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvMarkalar.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvMarkalar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvMarkalar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(136, 136, 136);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgvMarkalar.DefaultCellStyle = dataGridViewCellStyle5;
            dgvMarkalar.EnableHeadersVisualStyles = false;
            dgvMarkalar.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dgvMarkalar.GridColor = Color.FromArgb(255, 255, 255);
            dgvMarkalar.Location = new Point(84, 78);
            dgvMarkalar.Name = "dgvMarkalar";
            dgvMarkalar.ReadOnly = true;
            dgvMarkalar.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgvMarkalar.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgvMarkalar.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvMarkalar.RowTemplate.Height = 25;
            dgvMarkalar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMarkalar.Size = new Size(703, 246);
            dgvMarkalar.TabIndex = 114;
            dgvMarkalar.CellClick += dgvMarkalar_CellClick;
            dgvMarkalar.SelectionChanged += dgvMarkalar_SelectionChanged;
            // 
            // araBTN
            // 
            araBTN.Depth = 0;
            araBTN.Location = new Point(287, 349);
            araBTN.MouseState = MaterialSkin.MouseState.HOVER;
            araBTN.Name = "araBTN";
            araBTN.Primary = true;
            araBTN.Size = new Size(227, 71);
            araBTN.TabIndex = 121;
            araBTN.Text = "MARKA ARA";
            araBTN.UseVisualStyleBackColor = true;
            araBTN.Click += ara_Click;
            // 
            // silBTN
            // 
            silBTN.Depth = 0;
            silBTN.Location = new Point(531, 432);
            silBTN.MouseState = MaterialSkin.MouseState.HOVER;
            silBTN.Name = "silBTN";
            silBTN.Primary = true;
            silBTN.Size = new Size(292, 39);
            silBTN.TabIndex = 119;
            silBTN.Text = "MARKA SİL";
            silBTN.UseVisualStyleBackColor = true;
            silBTN.Click += sil_Click;
            // 
            // guncelleBTN
            // 
            guncelleBTN.Depth = 0;
            guncelleBTN.Location = new Point(531, 342);
            guncelleBTN.MouseState = MaterialSkin.MouseState.HOVER;
            guncelleBTN.Name = "guncelleBTN";
            guncelleBTN.Primary = true;
            guncelleBTN.Size = new Size(290, 39);
            guncelleBTN.TabIndex = 118;
            guncelleBTN.Text = "MARKA GÜNCELLE";
            guncelleBTN.UseVisualStyleBackColor = true;
            guncelleBTN.Click += guncelle_Click;
            // 
            // ekleBTN
            // 
            ekleBTN.Depth = 0;
            ekleBTN.Location = new Point(531, 387);
            ekleBTN.MouseState = MaterialSkin.MouseState.HOVER;
            ekleBTN.Name = "ekleBTN";
            ekleBTN.Primary = true;
            ekleBTN.Size = new Size(290, 39);
            ekleBTN.TabIndex = 117;
            ekleBTN.Text = "MARKA EKLE";
            ekleBTN.UseVisualStyleBackColor = true;
            ekleBTN.Click += ekle_Click;
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point);
            materialLabel2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialLabel2.Location = new Point(19, 408);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(33, 19);
            materialLabel2.TabIndex = 116;
            materialLabel2.Text = "AD:";
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point);
            materialLabel1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialLabel1.Location = new Point(20, 349);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(27, 19);
            materialLabel1.TabIndex = 115;
            materialLabel1.Text = "ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonHighlight;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkCyan;
            label2.Location = new Point(322, 33);
            label2.Name = "label2";
            label2.Size = new Size(201, 32);
            label2.TabIndex = 110;
            label2.Text = "MARKA YÖNETİMİ";
            // 
            // Markalar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(852, 496);
            Controls.Add(listeleBTN);
            Controls.Add(ADTBox);
            Controls.Add(IDTBox);
            Controls.Add(menuStrip1);
            Controls.Add(dgvMarkalar);
            Controls.Add(araBTN);
            Controls.Add(silBTN);
            Controls.Add(guncelleBTN);
            Controls.Add(ekleBTN);
            Controls.Add(materialLabel2);
            Controls.Add(materialLabel1);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Markalar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Markalar";
            Load += Markalar_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMarkalar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton listeleBTN;
        private TextBox ADTBox;
        private TextBox IDTBox;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem programToolStripMenuItem;
        private ToolStripMenuItem çıkışYapToolStripMenuItem;
        private ToolStripMenuItem otomasyonaGitToolStripMenuItem;
        private MetroFramework.Controls.MetroGrid dgvMarkalar;
        private MaterialSkin.Controls.MaterialRaisedButton araBTN;
        private MaterialSkin.Controls.MaterialRaisedButton silBTN;
        private MaterialSkin.Controls.MaterialRaisedButton guncelleBTN;
        private MaterialSkin.Controls.MaterialRaisedButton ekleBTN;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private Label label2;
    }
}