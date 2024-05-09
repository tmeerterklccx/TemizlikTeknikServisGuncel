namespace TemizlikTeknikServisGuncel
{
    partial class Form2
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
            materialContextMenuStrip1 = new MaterialSkin.Controls.MaterialContextMenuStrip();
            materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            SuspendLayout();
            // 
            // materialContextMenuStrip1
            // 
            materialContextMenuStrip1.BackColor = Color.FromArgb(255, 255, 255);
            materialContextMenuStrip1.Depth = 0;
            materialContextMenuStrip1.MouseState = MaterialSkin.MouseState.HOVER;
            materialContextMenuStrip1.Name = "materialContextMenuStrip1";
            materialContextMenuStrip1.Size = new Size(61, 4);
            // 
            // materialRaisedButton1
            // 
            materialRaisedButton1.Depth = 0;
            materialRaisedButton1.Location = new Point(207, 164);
            materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialRaisedButton1.Name = "materialRaisedButton1";
            materialRaisedButton1.Primary = true;
            materialRaisedButton1.Size = new Size(199, 66);
            materialRaisedButton1.TabIndex = 1;
            materialRaisedButton1.Text = "materialRaisedButton1";
            materialRaisedButton1.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(materialRaisedButton1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialContextMenuStrip materialContextMenuStrip1;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
    }
}