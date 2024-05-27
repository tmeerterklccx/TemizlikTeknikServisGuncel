namespace TemizlikTeknikServisGuncel
{
    partial class MarkaEkle
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
            çıkışYapToolStripMenuItem = new ToolStripMenuItem();
            programToolStripMenuItem = new ToolStripMenuItem();
            otomasyonaGitToolStripMenuItem = new ToolStripMenuItem();
            materialDivider5 = new MaterialSkin.Controls.MaterialDivider();
            materialDivider6 = new MaterialSkin.Controls.MaterialDivider();
            materialDivider7 = new MaterialSkin.Controls.MaterialDivider();
            materialDivider8 = new MaterialSkin.Controls.MaterialDivider();
            ekleBTN = new MaterialSkin.Controls.MaterialRaisedButton();
            markaAdTBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            metroLabel1 = new MetroFramework.Controls.MetroLabel();
            label2 = new Label();
            menuStrip1 = new MenuStrip();
            menuStrip1.SuspendLayout();
            SuspendLayout();
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
            // otomasyonaGitToolStripMenuItem
            // 
            otomasyonaGitToolStripMenuItem.Name = "otomasyonaGitToolStripMenuItem";
            otomasyonaGitToolStripMenuItem.Size = new Size(105, 20);
            otomasyonaGitToolStripMenuItem.Text = "Otomasyona Git";
            otomasyonaGitToolStripMenuItem.Click += otomasyonaGitToolStripMenuItem_Click;
            // 
            // materialDivider5
            // 
            materialDivider5.BackColor = Color.FromArgb(31, 0, 0, 0);
            materialDivider5.Depth = 0;
            materialDivider5.Location = new Point(417, 219);
            materialDivider5.MouseState = MaterialSkin.MouseState.HOVER;
            materialDivider5.Name = "materialDivider5";
            materialDivider5.Size = new Size(22, 105);
            materialDivider5.TabIndex = 248;
            materialDivider5.Text = "materialDivider5";
            // 
            // materialDivider6
            // 
            materialDivider6.BackColor = Color.FromArgb(31, 0, 0, 0);
            materialDivider6.Depth = 0;
            materialDivider6.Location = new Point(90, 219);
            materialDivider6.MouseState = MaterialSkin.MouseState.HOVER;
            materialDivider6.Name = "materialDivider6";
            materialDivider6.Size = new Size(22, 105);
            materialDivider6.TabIndex = 247;
            materialDivider6.Text = "materialDivider6";
            // 
            // materialDivider7
            // 
            materialDivider7.BackColor = Color.FromArgb(31, 0, 0, 0);
            materialDivider7.Depth = 0;
            materialDivider7.Location = new Point(118, 304);
            materialDivider7.MouseState = MaterialSkin.MouseState.HOVER;
            materialDivider7.Name = "materialDivider7";
            materialDivider7.Size = new Size(293, 20);
            materialDivider7.TabIndex = 246;
            materialDivider7.Text = "materialDivider7";
            // 
            // materialDivider8
            // 
            materialDivider8.BackColor = Color.FromArgb(31, 0, 0, 0);
            materialDivider8.Depth = 0;
            materialDivider8.Location = new Point(118, 219);
            materialDivider8.MouseState = MaterialSkin.MouseState.HOVER;
            materialDivider8.Name = "materialDivider8";
            materialDivider8.Size = new Size(293, 20);
            materialDivider8.TabIndex = 245;
            materialDivider8.Text = "materialDivider8";
            // 
            // ekleBTN
            // 
            ekleBTN.Depth = 0;
            ekleBTN.Location = new Point(118, 245);
            ekleBTN.MouseState = MaterialSkin.MouseState.HOVER;
            ekleBTN.Name = "ekleBTN";
            ekleBTN.Primary = true;
            ekleBTN.Size = new Size(293, 53);
            ekleBTN.TabIndex = 244;
            ekleBTN.Text = "MARKA EKLE";
            ekleBTN.UseVisualStyleBackColor = true;
            ekleBTN.Click += button1_Click;
            // 
            // markaAdTBox
            // 
            markaAdTBox.Depth = 0;
            markaAdTBox.Hint = "";
            markaAdTBox.Location = new Point(225, 153);
            markaAdTBox.MouseState = MaterialSkin.MouseState.HOVER;
            markaAdTBox.Name = "markaAdTBox";
            markaAdTBox.PasswordChar = '\0';
            markaAdTBox.SelectedText = "";
            markaAdTBox.SelectionLength = 0;
            markaAdTBox.SelectionStart = 0;
            markaAdTBox.Size = new Size(149, 23);
            markaAdTBox.TabIndex = 243;
            markaAdTBox.UseSystemPasswordChar = false;
            // 
            // metroLabel1
            // 
            metroLabel1.AutoSize = true;
            metroLabel1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            metroLabel1.Location = new Point(96, 153);
            metroLabel1.Name = "metroLabel1";
            metroLabel1.Size = new Size(82, 19);
            metroLabel1.TabIndex = 242;
            metroLabel1.Text = "MARKA ADI:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkCyan;
            label2.Location = new Point(187, 62);
            label2.Name = "label2";
            label2.Size = new Size(146, 32);
            label2.TabIndex = 240;
            label2.Text = "MARKA EKLE";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { programToolStripMenuItem, otomasyonaGitToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(505, 24);
            menuStrip1.TabIndex = 241;
            menuStrip1.Text = "menuStrip1";
            // 
            // MarkaEkle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(505, 363);
            Controls.Add(materialDivider5);
            Controls.Add(materialDivider6);
            Controls.Add(materialDivider7);
            Controls.Add(materialDivider8);
            Controls.Add(ekleBTN);
            Controls.Add(markaAdTBox);
            Controls.Add(metroLabel1);
            Controls.Add(label2);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "MarkaEkle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MarkaEkle";
            Load += MarkaEkle_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStripMenuItem çıkışYapToolStripMenuItem;
        private ToolStripMenuItem programToolStripMenuItem;
        private ToolStripMenuItem otomasyonaGitToolStripMenuItem;
        private MaterialSkin.Controls.MaterialDivider materialDivider5;
        private MaterialSkin.Controls.MaterialDivider materialDivider6;
        private MaterialSkin.Controls.MaterialDivider materialDivider7;
        private MaterialSkin.Controls.MaterialDivider materialDivider8;
        private MaterialSkin.Controls.MaterialRaisedButton ekleBTN;
        private MaterialSkin.Controls.MaterialSingleLineTextField markaAdTBox;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private Label label2;
        private MenuStrip menuStrip1;
    }
}