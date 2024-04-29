namespace TemizlikTeknikServisGuncel.Musteri_Takibi
{
    partial class MusteriGuncelle
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
            otomasyonaGitToolStripMenuItem = new ToolStripMenuItem();
            çıkışYapToolStripMenuItem = new ToolStripMenuItem();
            programToolStripMenuItem = new ToolStripMenuItem();
            adresTextBox = new RichTextBox();
            button1 = new Button();
            label10 = new Label();
            label2 = new Label();
            menuStrip1 = new MenuStrip();
            cmbStatu = new ComboBox();
            label1 = new Label();
            label3 = new Label();
            eMailTextBox = new TextBox();
            adTextBox = new TextBox();
            soyadTextBox = new TextBox();
            label11 = new Label();
            telTextBox = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label4 = new Label();
            tcTextBox = new TextBox();
            menuStrip1.SuspendLayout();
            SuspendLayout();
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
            // adresTextBox
            // 
            adresTextBox.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            adresTextBox.Location = new Point(517, 201);
            adresTextBox.Name = "adresTextBox";
            adresTextBox.Size = new Size(233, 140);
            adresTextBox.TabIndex = 152;
            adresTextBox.Text = "";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button1.Location = new Point(484, 367);
            button1.Name = "button1";
            button1.Size = new Size(282, 53);
            button1.TabIndex = 151;
            button1.Text = "MÜŞTERİ GÜNCELLE";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BorderStyle = BorderStyle.FixedSingle;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.ControlLightLight;
            label10.Location = new Point(377, 227);
            label10.Name = "label10";
            label10.Size = new Size(67, 23);
            label10.TabIndex = 150;
            label10.Text = "ADRES:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(291, 54);
            label2.Name = "label2";
            label2.Size = new Size(214, 30);
            label2.TabIndex = 142;
            label2.Text = "MÜŞTERİ GÜNCELLE";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { programToolStripMenuItem, otomasyonaGitToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 145;
            menuStrip1.Text = "menuStrip1";
            // 
            // cmbStatu
            // 
            cmbStatu.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cmbStatu.FormattingEnabled = true;
            cmbStatu.Items.AddRange(new object[] { "Aktif", "Pasif" });
            cmbStatu.Location = new Point(517, 155);
            cmbStatu.Name = "cmbStatu";
            cmbStatu.Size = new Size(233, 29);
            cmbStatu.TabIndex = 156;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(380, 161);
            label1.Name = "label1";
            label1.Size = new Size(64, 23);
            label1.TabIndex = 155;
            label1.Text = "STATÜ:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(50, 357);
            label3.Name = "label3";
            label3.Size = new Size(63, 23);
            label3.TabIndex = 166;
            label3.Text = "E Mail:";
            // 
            // eMailTextBox
            // 
            eMailTextBox.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            eMailTextBox.Location = new Point(165, 356);
            eMailTextBox.Name = "eMailTextBox";
            eMailTextBox.Size = new Size(147, 24);
            eMailTextBox.TabIndex = 165;
            // 
            // adTextBox
            // 
            adTextBox.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            adTextBox.Location = new Point(163, 186);
            adTextBox.Name = "adTextBox";
            adTextBox.Size = new Size(147, 24);
            adTextBox.TabIndex = 164;
            // 
            // soyadTextBox
            // 
            soyadTextBox.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            soyadTextBox.Location = new Point(163, 245);
            soyadTextBox.Name = "soyadTextBox";
            soyadTextBox.Size = new Size(147, 24);
            soyadTextBox.TabIndex = 163;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BorderStyle = BorderStyle.FixedSingle;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = SystemColors.ControlLightLight;
            label11.Location = new Point(31, 308);
            label11.Name = "label11";
            label11.Size = new Size(88, 23);
            label11.TabIndex = 162;
            label11.Text = "TELEFON :";
            // 
            // telTextBox
            // 
            telTextBox.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            telTextBox.Location = new Point(165, 307);
            telTextBox.Name = "telTextBox";
            telTextBox.Size = new Size(147, 24);
            telTextBox.TabIndex = 161;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BorderStyle = BorderStyle.FixedSingle;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(50, 243);
            label6.Name = "label6";
            label6.Size = new Size(69, 23);
            label6.TabIndex = 160;
            label6.Text = "SOYAD:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BorderStyle = BorderStyle.FixedSingle;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ControlLightLight;
            label7.Location = new Point(80, 184);
            label7.Name = "label7";
            label7.Size = new Size(39, 23);
            label7.TabIndex = 159;
            label7.Text = "AD:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(36, 118);
            label4.Name = "label4";
            label4.Size = new Size(107, 23);
            label4.TabIndex = 158;
            label4.Text = "MÜŞTERİ TC:";
            // 
            // tcTextBox
            // 
            tcTextBox.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            tcTextBox.Location = new Point(163, 118);
            tcTextBox.Name = "tcTextBox";
            tcTextBox.Size = new Size(147, 24);
            tcTextBox.TabIndex = 157;
            // 
            // MusteriGuncelle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(eMailTextBox);
            Controls.Add(adTextBox);
            Controls.Add(soyadTextBox);
            Controls.Add(label11);
            Controls.Add(telTextBox);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(tcTextBox);
            Controls.Add(cmbStatu);
            Controls.Add(label1);
            Controls.Add(adresTextBox);
            Controls.Add(button1);
            Controls.Add(label10);
            Controls.Add(label2);
            Controls.Add(menuStrip1);
            Name = "MusteriGuncelle";
            Text = "MusteriGuncelle";
            Load += MusteriGuncelle_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ToolStripMenuItem otomasyonaGitToolStripMenuItem;
        private ToolStripMenuItem çıkışYapToolStripMenuItem;
        private ToolStripMenuItem programToolStripMenuItem;
        private Button button1;
        private Label label10;
        private Label label2;
        private MenuStrip menuStrip1;
        private Label label1;
        private Label label3;
        private Label label11;
        private Label label6;
        private Label label7;
        private Label label4;
        public ComboBox cmbStatu;
        public TextBox tcTextBox;
        public RichTextBox adresTextBox;
        public TextBox eMailTextBox;
        public TextBox adTextBox;
        public TextBox soyadTextBox;
        public TextBox telTextBox;
    }
}