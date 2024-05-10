namespace TemizlikTeknikServisGuncel
{
    partial class MarkaGuncelle
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
            markaAdTBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            metroLabel2 = new MetroFramework.Controls.MetroLabel();
            materialDivider5 = new MaterialSkin.Controls.MaterialDivider();
            materialDivider6 = new MaterialSkin.Controls.MaterialDivider();
            materialDivider7 = new MaterialSkin.Controls.MaterialDivider();
            materialDivider8 = new MaterialSkin.Controls.MaterialDivider();
            guncelleBTN = new MaterialSkin.Controls.MaterialRaisedButton();
            markaIDTBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
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
            otomasyonaGitToolStripMenuItem.Click += otomasyonaGitToolStripMenuItem_Click_1;
            // 
            // markaAdTBox
            // 
            markaAdTBox.Depth = 0;
            markaAdTBox.Hint = "";
            markaAdTBox.Location = new Point(261, 198);
            markaAdTBox.MouseState = MaterialSkin.MouseState.HOVER;
            markaAdTBox.Name = "markaAdTBox";
            markaAdTBox.PasswordChar = '\0';
            markaAdTBox.SelectedText = "";
            markaAdTBox.SelectionLength = 0;
            markaAdTBox.SelectionStart = 0;
            markaAdTBox.Size = new Size(149, 23);
            markaAdTBox.TabIndex = 261;
            markaAdTBox.UseSystemPasswordChar = false;
            markaAdTBox.TextChanged += textBox1_TextChanged;
            // 
            // metroLabel2
            // 
            metroLabel2.AutoSize = true;
            metroLabel2.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            metroLabel2.Location = new Point(132, 198);
            metroLabel2.Name = "metroLabel2";
            metroLabel2.Size = new Size(82, 19);
            metroLabel2.TabIndex = 260;
            metroLabel2.Text = "MARKA ADI:";
            // 
            // materialDivider5
            // 
            materialDivider5.BackColor = Color.FromArgb(31, 0, 0, 0);
            materialDivider5.Depth = 0;
            materialDivider5.Location = new Point(444, 261);
            materialDivider5.MouseState = MaterialSkin.MouseState.HOVER;
            materialDivider5.Name = "materialDivider5";
            materialDivider5.Size = new Size(22, 105);
            materialDivider5.TabIndex = 259;
            materialDivider5.Text = "materialDivider5";
            // 
            // materialDivider6
            // 
            materialDivider6.BackColor = Color.FromArgb(31, 0, 0, 0);
            materialDivider6.Depth = 0;
            materialDivider6.Location = new Point(117, 261);
            materialDivider6.MouseState = MaterialSkin.MouseState.HOVER;
            materialDivider6.Name = "materialDivider6";
            materialDivider6.Size = new Size(22, 105);
            materialDivider6.TabIndex = 258;
            materialDivider6.Text = "materialDivider6";
            // 
            // materialDivider7
            // 
            materialDivider7.BackColor = Color.FromArgb(31, 0, 0, 0);
            materialDivider7.Depth = 0;
            materialDivider7.Location = new Point(145, 346);
            materialDivider7.MouseState = MaterialSkin.MouseState.HOVER;
            materialDivider7.Name = "materialDivider7";
            materialDivider7.Size = new Size(293, 20);
            materialDivider7.TabIndex = 257;
            materialDivider7.Text = "materialDivider7";
            // 
            // materialDivider8
            // 
            materialDivider8.BackColor = Color.FromArgb(31, 0, 0, 0);
            materialDivider8.Depth = 0;
            materialDivider8.Location = new Point(145, 261);
            materialDivider8.MouseState = MaterialSkin.MouseState.HOVER;
            materialDivider8.Name = "materialDivider8";
            materialDivider8.Size = new Size(293, 20);
            materialDivider8.TabIndex = 256;
            materialDivider8.Text = "materialDivider8";
            // 
            // guncelleBTN
            // 
            guncelleBTN.Depth = 0;
            guncelleBTN.Location = new Point(145, 287);
            guncelleBTN.MouseState = MaterialSkin.MouseState.HOVER;
            guncelleBTN.Name = "guncelleBTN";
            guncelleBTN.Primary = true;
            guncelleBTN.Size = new Size(293, 53);
            guncelleBTN.TabIndex = 255;
            guncelleBTN.Text = "MARKA GÜNCELLE";
            guncelleBTN.UseVisualStyleBackColor = true;
            guncelleBTN.Click += button1_Click;
            // 
            // markaIDTBox
            // 
            markaIDTBox.Depth = 0;
            markaIDTBox.Enabled = false;
            markaIDTBox.Hint = "";
            markaIDTBox.Location = new Point(261, 142);
            markaIDTBox.MouseState = MaterialSkin.MouseState.HOVER;
            markaIDTBox.Name = "markaIDTBox";
            markaIDTBox.PasswordChar = '\0';
            markaIDTBox.SelectedText = "";
            markaIDTBox.SelectionLength = 0;
            markaIDTBox.SelectionStart = 0;
            markaIDTBox.Size = new Size(149, 23);
            markaIDTBox.TabIndex = 254;
            markaIDTBox.UseSystemPasswordChar = false;
            // 
            // metroLabel1
            // 
            metroLabel1.AutoSize = true;
            metroLabel1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            metroLabel1.Location = new Point(132, 142);
            metroLabel1.Name = "metroLabel1";
            metroLabel1.Size = new Size(73, 19);
            metroLabel1.TabIndex = 253;
            metroLabel1.Text = "MARKA ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkCyan;
            label2.Location = new Point(195, 51);
            label2.Name = "label2";
            label2.Size = new Size(203, 32);
            label2.TabIndex = 251;
            label2.Text = "MARKA GÜNCELLE";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { programToolStripMenuItem, otomasyonaGitToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(574, 24);
            menuStrip1.TabIndex = 252;
            menuStrip1.Text = "menuStrip1";
            // 
            // MarkaGuncelle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(574, 404);
            Controls.Add(markaAdTBox);
            Controls.Add(metroLabel2);
            Controls.Add(materialDivider5);
            Controls.Add(materialDivider6);
            Controls.Add(materialDivider7);
            Controls.Add(materialDivider8);
            Controls.Add(guncelleBTN);
            Controls.Add(markaIDTBox);
            Controls.Add(metroLabel1);
            Controls.Add(label2);
            Controls.Add(menuStrip1);
            Name = "MarkaGuncelle";
            Text = "MarkaGuncelle";
            Load += MarkaGuncelle_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStripMenuItem çıkışYapToolStripMenuItem;
        private ToolStripMenuItem programToolStripMenuItem;
        private ToolStripMenuItem otomasyonaGitToolStripMenuItem;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MaterialSkin.Controls.MaterialDivider materialDivider5;
        private MaterialSkin.Controls.MaterialDivider materialDivider6;
        private MaterialSkin.Controls.MaterialDivider materialDivider7;
        private MaterialSkin.Controls.MaterialDivider materialDivider8;
        private MaterialSkin.Controls.MaterialRaisedButton guncelleBTN;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private Label label2;
        private MenuStrip menuStrip1;
        public MaterialSkin.Controls.MaterialSingleLineTextField markaAdTBox;
        public MaterialSkin.Controls.MaterialSingleLineTextField markaIDTBox;
    }
}