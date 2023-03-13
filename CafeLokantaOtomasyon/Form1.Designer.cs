namespace AtesVeSuSiparisOtomasyonu
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
            anaEkranToolStripMenuItem = new ToolStripMenuItem();
            düzenleToolStripMenuItem = new ToolStripMenuItem();
            ekleToolStripMenuItem = new ToolStripMenuItem();
            kategoriDüzenleToolStripMenuItem = new ToolStripMenuItem();
            ürünDüzenleToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { anaEkranToolStripMenuItem, düzenleToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1409, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // anaEkranToolStripMenuItem
            // 
            anaEkranToolStripMenuItem.Name = "anaEkranToolStripMenuItem";
            anaEkranToolStripMenuItem.Size = new Size(89, 24);
            anaEkranToolStripMenuItem.Text = "Ana Ekran";
            anaEkranToolStripMenuItem.Click += anaEkranToolStripMenuItem_Click;
            // 
            // düzenleToolStripMenuItem
            // 
            düzenleToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ekleToolStripMenuItem, kategoriDüzenleToolStripMenuItem, ürünDüzenleToolStripMenuItem });
            düzenleToolStripMenuItem.Name = "düzenleToolStripMenuItem";
            düzenleToolStripMenuItem.Size = new Size(77, 24);
            düzenleToolStripMenuItem.Text = "Düzenle";
            // 
            // ekleToolStripMenuItem
            // 
            ekleToolStripMenuItem.Name = "ekleToolStripMenuItem";
            ekleToolStripMenuItem.Size = new Size(224, 26);
            ekleToolStripMenuItem.Text = "Kat Düzenle";
            ekleToolStripMenuItem.Click += ekleToolStripMenuItem_Click;
            // 
            // kategoriDüzenleToolStripMenuItem
            // 
            kategoriDüzenleToolStripMenuItem.Name = "kategoriDüzenleToolStripMenuItem";
            kategoriDüzenleToolStripMenuItem.Size = new Size(224, 26);
            kategoriDüzenleToolStripMenuItem.Text = "Kategori Düzenle";
            kategoriDüzenleToolStripMenuItem.Click += kategoriDüzenleToolStripMenuItem_Click;
            // 
            // ürünDüzenleToolStripMenuItem
            // 
            ürünDüzenleToolStripMenuItem.Name = "ürünDüzenleToolStripMenuItem";
            ürünDüzenleToolStripMenuItem.Size = new Size(224, 26);
            ürünDüzenleToolStripMenuItem.Text = "Ürün Düzenle";
            ürünDüzenleToolStripMenuItem.Click += ürünDüzenleToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1409, 664);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem düzenleToolStripMenuItem;
        private ToolStripMenuItem ekleToolStripMenuItem;
        private ToolStripMenuItem anaEkranToolStripMenuItem;
        private ToolStripMenuItem kategoriDüzenleToolStripMenuItem;
        private ToolStripMenuItem ürünDüzenleToolStripMenuItem;
    }
}