namespace TemizlikTeknikServisGuncel
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            programToolStripMenuItem = new ToolStripMenuItem();
            çıkışYapToolStripMenuItem = new ToolStripMenuItem();
            materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            label2 = new Label();
            TCTBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            metroLabel1 = new MetroFramework.Controls.MetroLabel();
            SifreTBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            metroLabel2 = new MetroFramework.Controls.MetroLabel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { programToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(441, 24);
            menuStrip1.TabIndex = 39;
            menuStrip1.Text = "menuStrip1";
            // 
            // programToolStripMenuItem
            // 
            programToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { çıkışYapToolStripMenuItem });
            programToolStripMenuItem.Name = "programToolStripMenuItem";
            programToolStripMenuItem.Size = new Size(65, 20);
            programToolStripMenuItem.Text = "Program";
            // 
            // çıkışYapToolStripMenuItem
            // 
            çıkışYapToolStripMenuItem.Name = "çıkışYapToolStripMenuItem";
            çıkışYapToolStripMenuItem.Size = new Size(121, 22);
            çıkışYapToolStripMenuItem.Text = "Çıkış Yap";
            çıkışYapToolStripMenuItem.Click += çıkışYapToolStripMenuItem_Click;
            // 
            // materialRaisedButton1
            // 
            materialRaisedButton1.Depth = 0;
            materialRaisedButton1.Location = new Point(15, 220);
            materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialRaisedButton1.Name = "materialRaisedButton1";
            materialRaisedButton1.Primary = true;
            materialRaisedButton1.Size = new Size(414, 65);
            materialRaisedButton1.TabIndex = 41;
            materialRaisedButton1.Text = "GİRİŞ YAP";
            materialRaisedButton1.UseVisualStyleBackColor = true;
            materialRaisedButton1.Click += ıconButton8_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(145, 37);
            label2.Name = "label2";
            label2.Size = new Size(153, 30);
            label2.TabIndex = 40;
            label2.Text = "HOŞGELDİNİZ";
            // 
            // TCTBox
            // 
            TCTBox.Depth = 0;
            TCTBox.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            TCTBox.Hint = "";
            TCTBox.Location = new Point(204, 104);
            TCTBox.MouseState = MaterialSkin.MouseState.HOVER;
            TCTBox.Name = "TCTBox";
            TCTBox.PasswordChar = '\0';
            TCTBox.SelectedText = "";
            TCTBox.SelectionLength = 0;
            TCTBox.SelectionStart = 0;
            TCTBox.Size = new Size(149, 23);
            TCTBox.TabIndex = 245;
            TCTBox.UseSystemPasswordChar = false;
            // 
            // metroLabel1
            // 
            metroLabel1.AutoSize = true;
            metroLabel1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            metroLabel1.Location = new Point(105, 104);
            metroLabel1.Name = "metroLabel1";
            metroLabel1.Size = new Size(27, 19);
            metroLabel1.TabIndex = 244;
            metroLabel1.Text = "TC:";
            // 
            // SifreTBox
            // 
            SifreTBox.Depth = 0;
            SifreTBox.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            SifreTBox.Hint = "";
            SifreTBox.Location = new Point(204, 156);
            SifreTBox.MouseState = MaterialSkin.MouseState.HOVER;
            SifreTBox.Name = "SifreTBox";
            SifreTBox.PasswordChar = '\0';
            SifreTBox.SelectedText = "";
            SifreTBox.SelectionLength = 0;
            SifreTBox.SelectionStart = 0;
            SifreTBox.Size = new Size(149, 23);
            SifreTBox.TabIndex = 247;
            SifreTBox.UseSystemPasswordChar = true;
            // 
            // metroLabel2
            // 
            metroLabel2.AutoSize = true;
            metroLabel2.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            metroLabel2.Location = new Point(88, 156);
            metroLabel2.Name = "metroLabel2";
            metroLabel2.Size = new Size(44, 19);
            metroLabel2.TabIndex = 246;
            metroLabel2.Text = "ŞİFRE:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(441, 291);
            Controls.Add(SifreTBox);
            Controls.Add(metroLabel2);
            Controls.Add(TCTBox);
            Controls.Add(metroLabel1);
            Controls.Add(menuStrip1);
            Controls.Add(materialRaisedButton1);
            Controls.Add(label2);
            Name = "Form1";
            Text = "Temizlik Teknik Servis Otomasyonu";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem programToolStripMenuItem;
        private ToolStripMenuItem çıkışYapToolStripMenuItem;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private Label label2;
        private MaterialSkin.Controls.MaterialSingleLineTextField TCTBox;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField SifreTBox;
        private MetroFramework.Controls.MetroLabel metroLabel2;
    }
}