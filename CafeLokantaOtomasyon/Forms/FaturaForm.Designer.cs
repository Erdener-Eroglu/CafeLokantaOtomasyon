namespace CafeLokantaOtomasyon.Forms
{
    partial class FaturaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FaturaForm));
            rtFatura = new RichTextBox();
            menuStrip1 = new MenuStrip();
            yazdırToolStripMenuItem = new ToolStripMenuItem();
            dosyaYazdir = new System.Drawing.Printing.PrintDocument();
            printPreview = new PrintPreviewDialog();
            btnHesapKapat = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // rtFatura
            // 
            rtFatura.Dock = DockStyle.Top;
            rtFatura.Location = new Point(0, 28);
            rtFatura.Margin = new Padding(4);
            rtFatura.Name = "rtFatura";
            rtFatura.ReadOnly = true;
            rtFatura.Size = new Size(1041, 513);
            rtFatura.TabIndex = 0;
            rtFatura.Text = "";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { yazdırToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(9, 2, 0, 2);
            menuStrip1.Size = new Size(1041, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // yazdırToolStripMenuItem
            // 
            yazdırToolStripMenuItem.Name = "yazdırToolStripMenuItem";
            yazdırToolStripMenuItem.Size = new Size(63, 24);
            yazdırToolStripMenuItem.Text = "Yazdır";
            yazdırToolStripMenuItem.Click += yazdırToolStripMenuItem_Click;
            // 
            // dosyaYazdir
            // 
            dosyaYazdir.PrintPage += dosyaYazdir_PrintPage;
            // 
            // printPreview
            // 
            printPreview.AutoScrollMargin = new Size(0, 0);
            printPreview.AutoScrollMinSize = new Size(0, 0);
            printPreview.ClientSize = new Size(400, 300);
            printPreview.Enabled = true;
            printPreview.Icon = (Icon)resources.GetObject("printPreview.Icon");
            printPreview.Name = "printPreviewDialog1";
            printPreview.Visible = false;
            // 
            // btnHesapKapat
            // 
            btnHesapKapat.Location = new Point(803, 571);
            btnHesapKapat.Name = "btnHesapKapat";
            btnHesapKapat.Size = new Size(107, 45);
            btnHesapKapat.TabIndex = 2;
            btnHesapKapat.Text = "button1";
            btnHesapKapat.UseVisualStyleBackColor = true;
            // 
            // FaturaForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1041, 640);
            Controls.Add(btnHesapKapat);
            Controls.Add(rtFatura);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4);
            Name = "FaturaForm";
            Text = "FaturaForm";
            Load += FaturaForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox rtFatura;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem yazdırToolStripMenuItem;
        private System.Drawing.Printing.PrintDocument dosyaYazdir;
        private PrintPreviewDialog printPreview;
        private Button btnHesapKapat;
    }
}