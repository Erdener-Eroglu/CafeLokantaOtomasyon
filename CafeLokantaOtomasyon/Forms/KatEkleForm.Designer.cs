namespace AtesVeSuSiparisOtomasyonu.Forms
{
    partial class KatEkleForm
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
            txtKatIsmi = new TextBox();
            lstKatlar = new ListBox();
            cmsSil = new ContextMenuStrip(components);
            silToolStripMenuItem = new ToolStripMenuItem();
            btnKaydet = new Button();
            btnGuncelle = new Button();
            label2 = new Label();
            txtMasaSayisi = new TextBox();
            cmsSil.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 25);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 0;
            label1.Text = "Kat İsmi:";
            // 
            // txtKatIsmi
            // 
            txtKatIsmi.Location = new Point(101, 22);
            txtKatIsmi.Name = "txtKatIsmi";
            txtKatIsmi.Size = new Size(191, 27);
            txtKatIsmi.TabIndex = 0;
            // 
            // lstKatlar
            // 
            lstKatlar.ContextMenuStrip = cmsSil;
            lstKatlar.FormattingEnabled = true;
            lstKatlar.ItemHeight = 20;
            lstKatlar.Location = new Point(314, 22);
            lstKatlar.Name = "lstKatlar";
            lstKatlar.Size = new Size(162, 184);
            lstKatlar.TabIndex = 4;
            lstKatlar.SelectedIndexChanged += lstKatlar_SelectedIndexChanged;
            // 
            // cmsSil
            // 
            cmsSil.ImageScalingSize = new Size(20, 20);
            cmsSil.Items.AddRange(new ToolStripItem[] { silToolStripMenuItem });
            cmsSil.Name = "contextMenuStrip1";
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
            btnKaydet.Location = new Point(9, 127);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(131, 81);
            btnKaydet.TabIndex = 2;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(161, 127);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(131, 81);
            btnGuncelle.TabIndex = 3;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 77);
            label2.Name = "label2";
            label2.Size = new Size(88, 20);
            label2.TabIndex = 0;
            label2.Text = "Masa Sayisi:";
            // 
            // txtMasaSayisi
            // 
            txtMasaSayisi.Location = new Point(101, 70);
            txtMasaSayisi.Name = "txtMasaSayisi";
            txtMasaSayisi.Size = new Size(191, 27);
            txtMasaSayisi.TabIndex = 1;
            // 
            // KatEkleForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(525, 287);
            Controls.Add(btnGuncelle);
            Controls.Add(btnKaydet);
            Controls.Add(lstKatlar);
            Controls.Add(txtMasaSayisi);
            Controls.Add(txtKatIsmi);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "KatEkleForm";
            Text = "KatEkleForm";
            Load += KatEkleForm_Load;
            Click += KatEkleForm_Click;
            cmsSil.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtKatIsmi;
        private ListBox lstKatlar;
        private Button btnKaydet;
        private Button btnGuncelle;
        private Label label2;
        private TextBox txtMasaSayisi;
        private ContextMenuStrip cmsSil;
        private ToolStripMenuItem silToolStripMenuItem;
    }
}