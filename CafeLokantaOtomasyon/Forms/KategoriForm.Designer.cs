namespace AtesVeSuSiparisOtomasyonu.Forms
{
    partial class KategoriForm
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            txtKategori = new TextBox();
            lstKategori = new ListBox();
            btnKaydet = new Button();
            btnGuncelle = new Button();
            cmsSil = new ContextMenuStrip(components);
            silToolStripMenuItem = new ToolStripMenuItem();
            cmsSil.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(63, 38);
            label1.Name = "label1";
            label1.Size = new Size(136, 28);
            label1.TabIndex = 0;
            label1.Text = "Kategori Adı:";
            // 
            // txtKategori
            // 
            txtKategori.Location = new Point(21, 69);
            txtKategori.Name = "txtKategori";
            txtKategori.Size = new Size(236, 27);
            txtKategori.TabIndex = 1;
            // 
            // lstKategori
            // 
            lstKategori.ContextMenuStrip = cmsSil;
            lstKategori.FormattingEnabled = true;
            lstKategori.ItemHeight = 20;
            lstKategori.Location = new Point(277, 23);
            lstKategori.Name = "lstKategori";
            lstKategori.Size = new Size(206, 284);
            lstKategori.TabIndex = 2;
            lstKategori.SelectedIndexChanged += lstKategori_SelectedIndexChanged;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(21, 153);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(115, 96);
            btnKaydet.TabIndex = 3;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(142, 153);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(115, 96);
            btnGuncelle.TabIndex = 3;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // cmsSil
            // 
            cmsSil.ImageScalingSize = new Size(20, 20);
            cmsSil.Items.AddRange(new ToolStripItem[] { silToolStripMenuItem });
            cmsSil.Name = "cmsSil";
            cmsSil.Size = new Size(95, 28);
            // 
            // silToolStripMenuItem
            // 
            silToolStripMenuItem.Name = "silToolStripMenuItem";
            silToolStripMenuItem.Size = new Size(94, 24);
            silToolStripMenuItem.Text = "Sil";
            silToolStripMenuItem.Click += silToolStripMenuItem_Click;
            // 
            // KategoriForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(495, 319);
            Controls.Add(btnGuncelle);
            Controls.Add(btnKaydet);
            Controls.Add(lstKategori);
            Controls.Add(txtKategori);
            Controls.Add(label1);
            Name = "KategoriForm";
            Text = "KategoriForm";
            Load += KategoriForm_Load;
            cmsSil.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtKategori;
        private ListBox lstKategori;
        private Button btnKaydet;
        private Button btnGuncelle;
        private ContextMenuStrip cmsSil;
        private ToolStripMenuItem silToolStripMenuItem;
    }
}