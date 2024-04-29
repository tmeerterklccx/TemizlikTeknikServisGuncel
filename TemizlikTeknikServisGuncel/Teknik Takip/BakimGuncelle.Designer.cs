namespace TemizlikTeknikServisGuncel
{
    partial class BakimGuncelle
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
            tutarTBox = new TextBox();
            otomasyonaGitToolStripMenuItem = new ToolStripMenuItem();
            çıkışYapToolStripMenuItem = new ToolStripMenuItem();
            programToolStripMenuItem = new ToolStripMenuItem();
            urunCBox = new ComboBox();
            bilgiTBox = new RichTextBox();
            button1 = new Button();
            label10 = new Label();
            label11 = new Label();
            label6 = new Label();
            label7 = new Label();
            label4 = new Label();
            label5 = new Label();
            bakimTuruCBox = new TextBox();
            personelTcTBox = new TextBox();
            label3 = new Label();
            tcTextBox = new TextBox();
            label2 = new Label();
            menuStrip1 = new MenuStrip();
            label1 = new Label();
            idTextBox = new TextBox();
            statuCBox = new ComboBox();
            label8 = new Label();
            tarihPicker = new DateTimePicker();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // tutarTBox
            // 
            tutarTBox.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            tutarTBox.Location = new Point(159, 302);
            tutarTBox.Name = "tutarTBox";
            tutarTBox.Size = new Size(147, 24);
            tutarTBox.TabIndex = 141;
            // 
            // otomasyonaGitToolStripMenuItem
            // 
            otomasyonaGitToolStripMenuItem.Name = "otomasyonaGitToolStripMenuItem";
            otomasyonaGitToolStripMenuItem.Size = new Size(105, 20);
            otomasyonaGitToolStripMenuItem.Text = "Otomasyona Git";
            // 
            // çıkışYapToolStripMenuItem
            // 
            çıkışYapToolStripMenuItem.Name = "çıkışYapToolStripMenuItem";
            çıkışYapToolStripMenuItem.Size = new Size(121, 22);
            çıkışYapToolStripMenuItem.Text = "Çıkış Yap";
            // 
            // programToolStripMenuItem
            // 
            programToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { çıkışYapToolStripMenuItem });
            programToolStripMenuItem.Name = "programToolStripMenuItem";
            programToolStripMenuItem.Size = new Size(65, 20);
            programToolStripMenuItem.Text = "&Program";
            // 
            // urunCBox
            // 
            urunCBox.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            urunCBox.FormattingEnabled = true;
            urunCBox.Location = new Point(159, 241);
            urunCBox.Name = "urunCBox";
            urunCBox.Size = new Size(145, 29);
            urunCBox.TabIndex = 140;
            // 
            // bilgiTBox
            // 
            bilgiTBox.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            bilgiTBox.Location = new Point(555, 229);
            bilgiTBox.Name = "bilgiTBox";
            bilgiTBox.Size = new Size(233, 97);
            bilgiTBox.TabIndex = 139;
            bilgiTBox.Text = "";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button1.Location = new Point(318, 397);
            button1.Name = "button1";
            button1.Size = new Size(282, 41);
            button1.TabIndex = 138;
            button1.Text = "BAKIMI GÜNCELLE";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BorderStyle = BorderStyle.FixedSingle;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.ControlLightLight;
            label10.Location = new Point(412, 258);
            label10.Name = "label10";
            label10.Size = new Size(124, 23);
            label10.TabIndex = 137;
            label10.Text = "BAKIM BİLGİSİ:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BorderStyle = BorderStyle.FixedSingle;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = SystemColors.ControlLightLight;
            label11.Location = new Point(21, 365);
            label11.Name = "label11";
            label11.Size = new Size(118, 23);
            label11.TabIndex = 136;
            label11.Text = "BAKIM TARİHİ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BorderStyle = BorderStyle.FixedSingle;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(13, 300);
            label6.Name = "label6";
            label6.Size = new Size(126, 23);
            label6.TabIndex = 134;
            label6.Text = "BAKIM TUTARI:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BorderStyle = BorderStyle.FixedSingle;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ControlLightLight;
            label7.Location = new Point(76, 241);
            label7.Name = "label7";
            label7.Size = new Size(63, 23);
            label7.TabIndex = 133;
            label7.Text = "ÜRÜN:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(418, 173);
            label4.Name = "label4";
            label4.Size = new Size(118, 23);
            label4.TabIndex = 132;
            label4.Text = "BAKIM TÜRÜ :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BorderStyle = BorderStyle.FixedSingle;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(418, 114);
            label5.Name = "label5";
            label5.Size = new Size(118, 23);
            label5.TabIndex = 131;
            label5.Text = "PERSONEL TC:";
            // 
            // bakimTuruCBox
            // 
            bakimTuruCBox.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            bakimTuruCBox.Location = new Point(583, 172);
            bakimTuruCBox.Name = "bakimTuruCBox";
            bakimTuruCBox.Size = new Size(147, 24);
            bakimTuruCBox.TabIndex = 130;
            // 
            // personelTcTBox
            // 
            personelTcTBox.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            personelTcTBox.Location = new Point(583, 113);
            personelTcTBox.Name = "personelTcTBox";
            personelTcTBox.Size = new Size(147, 24);
            personelTcTBox.TabIndex = 129;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(32, 175);
            label3.Name = "label3";
            label3.Size = new Size(107, 23);
            label3.TabIndex = 127;
            label3.Text = "MÜŞTERİ TC:";
            // 
            // tcTextBox
            // 
            tcTextBox.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            tcTextBox.Location = new Point(159, 175);
            tcTextBox.Name = "tcTextBox";
            tcTextBox.Size = new Size(147, 24);
            tcTextBox.TabIndex = 126;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(301, 41);
            label2.Name = "label2";
            label2.Size = new Size(192, 30);
            label2.TabIndex = 125;
            label2.Text = "BAKIM GÜNCELLE";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { programToolStripMenuItem, otomasyonaGitToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 128;
            menuStrip1.Text = "menuStrip1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(34, 116);
            label1.Name = "label1";
            label1.Size = new Size(88, 23);
            label1.TabIndex = 143;
            label1.Text = "BAKIM ID:";
            // 
            // idTextBox
            // 
            idTextBox.Enabled = false;
            idTextBox.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            idTextBox.Location = new Point(161, 116);
            idTextBox.Name = "idTextBox";
            idTextBox.Size = new Size(147, 24);
            idTextBox.TabIndex = 142;
            // 
            // statuCBox
            // 
            statuCBox.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            statuCBox.FormattingEnabled = true;
            statuCBox.Items.AddRange(new object[] { "Aktif", "Pasif" });
            statuCBox.Location = new Point(555, 350);
            statuCBox.Name = "statuCBox";
            statuCBox.Size = new Size(233, 29);
            statuCBox.TabIndex = 145;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BorderStyle = BorderStyle.FixedSingle;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ControlLightLight;
            label8.Location = new Point(472, 350);
            label8.Name = "label8";
            label8.Size = new Size(64, 23);
            label8.TabIndex = 144;
            label8.Text = "STATÜ:";
            // 
            // tarihPicker
            // 
            tarihPicker.Location = new Point(159, 364);
            tarihPicker.Name = "tarihPicker";
            tarihPicker.Size = new Size(200, 23);
            tarihPicker.TabIndex = 146;
            // 
            // BakimGuncelle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 450);
            Controls.Add(tarihPicker);
            Controls.Add(statuCBox);
            Controls.Add(label8);
            Controls.Add(label1);
            Controls.Add(idTextBox);
            Controls.Add(tutarTBox);
            Controls.Add(urunCBox);
            Controls.Add(bilgiTBox);
            Controls.Add(button1);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(bakimTuruCBox);
            Controls.Add(personelTcTBox);
            Controls.Add(label3);
            Controls.Add(tcTextBox);
            Controls.Add(label2);
            Controls.Add(menuStrip1);
            Name = "BakimGuncelle";
            Text = "BakimGuncelle";
            Load += BakimGuncelle_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ToolStripMenuItem otomasyonaGitToolStripMenuItem;
        private ToolStripMenuItem çıkışYapToolStripMenuItem;
        private ToolStripMenuItem programToolStripMenuItem;
        private RichTextBox richTextBox1;
        private Button button1;
        private Label label10;
        private Label label11;
        private TextBox textBox10;
        private Label label6;
        private Label label7;
        private Label label4;
        private Label label5;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label3;
        private Label label2;
        private MenuStrip menuStrip1;
        private Label label1;
        private Label label8;
        public TextBox idTextBox;
        public DateTimePicker tarihPicker;
        public TextBox tutarTBox;
        public ComboBox urunCBox;
        public RichTextBox bilgiTBox;
        public TextBox bakimTuruCBox;
        public TextBox personelTcTBox;
        public TextBox tcTextBox;
        public ComboBox statuCBox;
    }
}