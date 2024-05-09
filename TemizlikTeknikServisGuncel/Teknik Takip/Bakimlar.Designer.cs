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
            label3 = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            button5 = new Button();
            button4 = new Button();
            button2 = new Button();
            button1 = new Button();
            button3 = new Button();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            menuStrip1 = new MenuStrip();
            programToolStripMenuItem = new ToolStripMenuItem();
            çıkışYapToolStripMenuItem = new ToolStripMenuItem();
            otomasyonaGitToolStripMenuItem = new ToolStripMenuItem();
            textBox2 = new TextBox();
            label4 = new Label();
            dataGridView2 = new DataGridView();
            label5 = new Label();
            label6 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(12, 424);
            label3.Name = "label3";
            label3.Size = new Size(107, 23);
            label3.TabIndex = 53;
            label3.Text = "MÜŞTERİ TC:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(12, 375);
            label1.Name = "label1";
            label1.Size = new Size(88, 23);
            label1.TabIndex = 52;
            label1.Text = "BAKIM ID:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Arial Narrow", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            textBox1.Location = new Point(148, 373);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(155, 26);
            textBox1.TabIndex = 51;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button5.Location = new Point(635, 359);
            button5.Name = "button5";
            button5.Size = new Size(135, 53);
            button5.TabIndex = 50;
            button5.Text = "BAKIM SİL";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button4.Location = new Point(559, 418);
            button4.Name = "button4";
            button4.Size = new Size(152, 53);
            button4.TabIndex = 49;
            button4.Text = "BAKIM GÜNCELLE";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button2.Location = new Point(407, 418);
            button2.Name = "button2";
            button2.Size = new Size(135, 53);
            button2.TabIndex = 48;
            button2.Text = "BAKIM KAYDET";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button1.Location = new Point(486, 359);
            button1.Name = "button1";
            button1.Size = new Size(135, 53);
            button1.TabIndex = 47;
            button1.Text = "BAKIM ARA";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button3.Location = new Point(333, 359);
            button3.Name = "button3";
            button3.Size = new Size(135, 53);
            button3.TabIndex = 46;
            button3.Text = "LİSTEYİ GETİR";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(333, 38);
            label2.Name = "label2";
            label2.Size = new Size(190, 30);
            label2.TabIndex = 45;
            label2.Text = "BAKIM YÖNETİMİ";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 71);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(758, 268);
            dataGridView1.TabIndex = 44;
            dataGridView1.CellStateChanged += dataGridView1_CellStateChanged;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { programToolStripMenuItem, otomasyonaGitToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1116, 24);
            menuStrip1.TabIndex = 54;
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
            // textBox2
            // 
            textBox2.Font = new Font("Arial Narrow", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            textBox2.Location = new Point(148, 423);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(155, 26);
            textBox2.TabIndex = 55;
            textBox2.TextChanged += textBox1_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(84, 18);
            label4.Name = "label4";
            label4.Size = new Size(162, 30);
            label4.TabIndex = 56;
            label4.Text = "TÜR YÖNETİMİ";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(22, 51);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(281, 205);
            dataGridView2.TabIndex = 57;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BorderStyle = BorderStyle.FixedSingle;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(20, 305);
            label5.Name = "label5";
            label5.Size = new Size(79, 23);
            label5.TabIndex = 60;
            label5.Text = "TÜR ADI:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BorderStyle = BorderStyle.FixedSingle;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(20, 264);
            label6.Name = "label6";
            label6.Size = new Size(68, 23);
            label6.TabIndex = 59;
            label6.Text = "TÜR ID:";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Arial Narrow", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            textBox3.Location = new Point(156, 262);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(147, 26);
            textBox3.TabIndex = 58;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Arial Narrow", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            textBox4.Location = new Point(156, 304);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(147, 26);
            textBox4.TabIndex = 61;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button6.Location = new Point(65, 346);
            button6.Name = "button6";
            button6.Size = new Size(100, 28);
            button6.TabIndex = 62;
            button6.Text = "LİSTELE";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button7.Location = new Point(171, 346);
            button7.Name = "button7";
            button7.Size = new Size(104, 28);
            button7.TabIndex = 63;
            button7.Text = "ARA";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button8.Location = new Point(3, 391);
            button8.Name = "button8";
            button8.Size = new Size(100, 28);
            button8.TabIndex = 64;
            button8.Text = "KAYDET";
            button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button9.Location = new Point(109, 391);
            button9.Name = "button9";
            button9.Size = new Size(100, 28);
            button9.TabIndex = 65;
            button9.Text = "GÜNCELLE";
            button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            button10.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button10.Location = new Point(215, 391);
            button10.Name = "button10";
            button10.Size = new Size(100, 28);
            button10.TabIndex = 66;
            button10.Text = "SİL";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaptionText;
            groupBox1.Controls.Add(dataGridView2);
            groupBox1.Controls.Add(button10);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(button9);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(button8);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(button7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(button6);
            groupBox1.Controls.Add(label5);
            groupBox1.Location = new Point(776, 38);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(328, 433);
            groupBox1.TabIndex = 67;
            groupBox1.TabStop = false;
            // 
            // Bakimlar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1116, 480);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(button3);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            Controls.Add(textBox2);
            Name = "Bakimlar";
            Text = "Bakimlar";
            Load += Bakimlar_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label1;
        private TextBox textBox1;
        private Button button5;
        private Button button4;
        private Button button2;
        private Button button1;
        private Button button3;
        private Label label2;
        private DataGridView dataGridView1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem programToolStripMenuItem;
        private ToolStripMenuItem çıkışYapToolStripMenuItem;
        private ToolStripMenuItem otomasyonaGitToolStripMenuItem;
        private TextBox textBox2;
        private Label label4;
        private DataGridView dataGridView2;
        private Label label5;
        private Label label6;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private GroupBox groupBox1;
    }
}