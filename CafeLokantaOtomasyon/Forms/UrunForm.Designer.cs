namespace AtesVeSuSiparisOtomasyonu.Forms
{
    partial class UrunForm
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
            cmbKategori = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            txtUrunAdi = new TextBox();
            txtUrunFiyat = new TextBox();
            pbUrunFoto = new PictureBox();
            lstUrunler = new ListBox();
            cmsSil = new ContextMenuStrip(components);
            silToolStripMenuItem = new ToolStripMenuItem();
            btnKaydet = new Button();
            btnGuncelle = new Button();
            dosyaAc = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)pbUrunFoto).BeginInit();
            cmsSil.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 140);
            label1.Name = "label1";
            label1.Size = new Size(114, 20);
            label1.TabIndex = 0;
            label1.Text = "Ürün Kategorisi:";
            // 
            // cmbKategori
            // 
            cmbKategori.FormattingEnabled = true;
            cmbKategori.Location = new Point(140, 137);
            cmbKategori.Name = "cmbKategori";
            cmbKategori.Size = new Size(186, 28);
            cmbKategori.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(64, 182);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 2;
            label2.Text = "Ürün Adı:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(52, 224);
            label3.Name = "label3";
            label3.Size = new Size(82, 20);
            label3.TabIndex = 3;
            label3.Text = "Ürün Fiyatı:";
            // 
            // txtUrunAdi
            // 
            txtUrunAdi.Location = new Point(140, 179);
            txtUrunAdi.Name = "txtUrunAdi";
            txtUrunAdi.Size = new Size(186, 27);
            txtUrunAdi.TabIndex = 4;
            // 
            // txtUrunFiyat
            // 
            txtUrunFiyat.Location = new Point(140, 220);
            txtUrunFiyat.Name = "txtUrunFiyat";
            txtUrunFiyat.Size = new Size(186, 27);
            txtUrunFiyat.TabIndex = 4;
            // 
            // pbUrunFoto
            // 
            pbUrunFoto.BorderStyle = BorderStyle.FixedSingle;
            pbUrunFoto.Location = new Point(112, 12);
            pbUrunFoto.Name = "pbUrunFoto";
            pbUrunFoto.Size = new Size(152, 102);
            pbUrunFoto.SizeMode = PictureBoxSizeMode.StretchImage;
            pbUrunFoto.TabIndex = 5;
            pbUrunFoto.TabStop = false;
            pbUrunFoto.Click += pbUrunFoto_Click;
            // 
            // lstUrunler
            // 
            lstUrunler.ContextMenuStrip = cmsSil;
            lstUrunler.FormattingEnabled = true;
            lstUrunler.ItemHeight = 20;
            lstUrunler.Location = new Point(343, 12);
            lstUrunler.Name = "lstUrunler";
            lstUrunler.Size = new Size(241, 404);
            lstUrunler.TabIndex = 6;
            lstUrunler.SelectedIndexChanged += lstUrunler_SelectedIndexChanged;
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
            // btnKaydet
            // 
            btnKaydet.Location = new Point(64, 278);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(107, 75);
            btnKaydet.TabIndex = 7;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(219, 278);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(107, 75);
            btnGuncelle.TabIndex = 7;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // dosyaAc
            // 
            dosyaAc.FileName = "openFileDialog1";
            // 
            // UrunForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(689, 450);
            Controls.Add(btnGuncelle);
            Controls.Add(btnKaydet);
            Controls.Add(lstUrunler);
            Controls.Add(pbUrunFoto);
            Controls.Add(txtUrunFiyat);
            Controls.Add(txtUrunAdi);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cmbKategori);
            Controls.Add(label1);
            Name = "UrunForm";
            Text = "UrunForm";
            Load += UrunForm_Load;
            ((System.ComponentModel.ISupportInitialize)pbUrunFoto).EndInit();
            cmsSil.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbKategori;
        private Label label2;
        private Label label3;
        private TextBox txtUrunAdi;
        private TextBox txtUrunFiyat;
        private PictureBox pbUrunFoto;
        private ListBox lstUrunler;
        private Button btnKaydet;
        private Button btnGuncelle;
        private OpenFileDialog dosyaAc;
        private ContextMenuStrip cmsSil;
        private ToolStripMenuItem silToolStripMenuItem;
    }
}