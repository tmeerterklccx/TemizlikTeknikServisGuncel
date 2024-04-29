namespace TemizlikTeknikServisGuncel
{
    partial class BakimEkle
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
            button1 = new Button();
            label10 = new Label();
            programToolStripMenuItem = new ToolStripMenuItem();
            çıkışYapToolStripMenuItem = new ToolStripMenuItem();
            otomasyonaGitToolStripMenuItem = new ToolStripMenuItem();
            label4 = new Label();
            label5 = new Label();
            label2 = new Label();
            menuStrip1 = new MenuStrip();
            tarihPicker = new DateTimePicker();
            tutarTBox = new TextBox();
            urunCBox = new ComboBox();
            label11 = new Label();
            label6 = new Label();
            label7 = new Label();
            label3 = new Label();
            tcTextBox = new TextBox();
            bilgiTBox = new RichTextBox();
            bakimTuruCBox = new TextBox();
            personelTcTBox = new TextBox();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button1.Location = new Point(259, 383);
            button1.Name = "button1";
            button1.Size = new Size(282, 53);
            button1.TabIndex = 118;
            button1.Text = "BAKIMI KAYDET";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BorderStyle = BorderStyle.FixedSingle;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.ControlLightLight;
            label10.Location = new Point(407, 274);
            label10.Name = "label10";
            label10.Size = new Size(124, 23);
            label10.TabIndex = 117;
            label10.Text = "BAKIM BİLGİSİ:";
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
            // label4
            // 
            label4.AutoSize = true;
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(413, 165);
            label4.Name = "label4";
            label4.Size = new Size(118, 23);
            label4.TabIndex = 108;
            label4.Text = "BAKIM TÜRÜ :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BorderStyle = BorderStyle.FixedSingle;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(413, 106);
            label5.Name = "label5";
            label5.Size = new Size(118, 23);
            label5.TabIndex = 107;
            label5.Text = "PERSONEL TC:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(315, 39);
            label2.Name = "label2";
            label2.Size = new Size(135, 30);
            label2.TabIndex = 101;
            label2.Text = "BAKIM EKLE";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { programToolStripMenuItem, otomasyonaGitToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 104;
            menuStrip1.Text = "menuStrip1";
            // 
            // tarihPicker
            // 
            tarihPicker.Location = new Point(155, 297);
            tarihPicker.Name = "tarihPicker";
            tarihPicker.Size = new Size(200, 23);
            tarihPicker.TabIndex = 154;
            // 
            // tutarTBox
            // 
            tutarTBox.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            tutarTBox.Location = new Point(155, 235);
            tutarTBox.Name = "tutarTBox";
            tutarTBox.Size = new Size(147, 24);
            tutarTBox.TabIndex = 153;
            // 
            // urunCBox
            // 
            urunCBox.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            urunCBox.FormattingEnabled = true;
            urunCBox.Location = new Point(155, 174);
            urunCBox.Name = "urunCBox";
            urunCBox.Size = new Size(145, 29);
            urunCBox.TabIndex = 152;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BorderStyle = BorderStyle.FixedSingle;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = SystemColors.ControlLightLight;
            label11.Location = new Point(17, 298);
            label11.Name = "label11";
            label11.Size = new Size(118, 23);
            label11.TabIndex = 151;
            label11.Text = "BAKIM TARİHİ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BorderStyle = BorderStyle.FixedSingle;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(9, 233);
            label6.Name = "label6";
            label6.Size = new Size(126, 23);
            label6.TabIndex = 150;
            label6.Text = "BAKIM TUTARI:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BorderStyle = BorderStyle.FixedSingle;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ControlLightLight;
            label7.Location = new Point(72, 174);
            label7.Name = "label7";
            label7.Size = new Size(63, 23);
            label7.TabIndex = 149;
            label7.Text = "ÜRÜN:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(28, 108);
            label3.Name = "label3";
            label3.Size = new Size(107, 23);
            label3.TabIndex = 148;
            label3.Text = "MÜŞTERİ TC:";
            // 
            // tcTextBox
            // 
            tcTextBox.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            tcTextBox.Location = new Point(155, 108);
            tcTextBox.Name = "tcTextBox";
            tcTextBox.Size = new Size(147, 24);
            tcTextBox.TabIndex = 147;
            // 
            // bilgiTBox
            // 
            bilgiTBox.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            bilgiTBox.Location = new Point(555, 224);
            bilgiTBox.Name = "bilgiTBox";
            bilgiTBox.Size = new Size(233, 97);
            bilgiTBox.TabIndex = 157;
            bilgiTBox.Text = "";
            // 
            // bakimTuruCBox
            // 
            bakimTuruCBox.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            bakimTuruCBox.Location = new Point(583, 167);
            bakimTuruCBox.Name = "bakimTuruCBox";
            bakimTuruCBox.Size = new Size(174, 24);
            bakimTuruCBox.TabIndex = 156;
            // 
            // personelTcTBox
            // 
            personelTcTBox.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            personelTcTBox.Location = new Point(583, 108);
            personelTcTBox.Name = "personelTcTBox";
            personelTcTBox.Size = new Size(174, 24);
            personelTcTBox.TabIndex = 155;
            // 
            // BakimEkle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 466);
            Controls.Add(bilgiTBox);
            Controls.Add(bakimTuruCBox);
            Controls.Add(personelTcTBox);
            Controls.Add(tarihPicker);
            Controls.Add(tutarTBox);
            Controls.Add(urunCBox);
            Controls.Add(label11);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label3);
            Controls.Add(tcTextBox);
            Controls.Add(button1);
            Controls.Add(label10);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(menuStrip1);
            Name = "BakimEkle";
            Text = "BakimEkle";
            Load += BakimEkle_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Label label10;
        private ToolStripMenuItem programToolStripMenuItem;
        private ToolStripMenuItem çıkışYapToolStripMenuItem;
        private ToolStripMenuItem otomasyonaGitToolStripMenuItem;
        private Label label4;
        private Label label5;
        private Label label2;
        private MenuStrip menuStrip1;
        public DateTimePicker tarihPicker;
        public TextBox tutarTBox;
        public ComboBox urunCBox;
        private Label label11;
        private Label label6;
        private Label label7;
        private Label label3;
        public TextBox tcTextBox;
        public RichTextBox bilgiTBox;
        public TextBox bakimTuruCBox;
        public TextBox personelTcTBox;
    }
}