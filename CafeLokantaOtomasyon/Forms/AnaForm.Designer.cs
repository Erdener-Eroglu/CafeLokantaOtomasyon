namespace AtesVeSuSiparisOtomasyonu.Forms
{
    partial class AnaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaForm));
            tableLayoutPanel1 = new TableLayoutPanel();
            flpKatlar = new FlowLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            flpMasalar = new FlowLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            flpKategoriler = new FlowLayoutPanel();
            flpUrunler = new FlowLayoutPanel();
            tableLayoutPanel5 = new TableLayoutPanel();
            tableLayoutPanel6 = new TableLayoutPanel();
            flpLabels = new FlowLayoutPanel();
            flpNuds = new FlowLayoutPanel();
            flpToplamFiyat = new FlowLayoutPanel();
            tableLayoutPanel7 = new TableLayoutPanel();
            label1 = new Label();
            lblToplam = new Label();
            btnGunlukRapor = new Button();
            btnHesap = new Button();
            btnHesapKapat = new Button();
            btnAylikRapor = new Button();
            printAdisyon = new System.Drawing.Printing.PrintDocument();
            printPreview = new PrintPreviewDialog();
            printGunlukRapor = new System.Drawing.Printing.PrintDocument();
            printAylikRapor = new System.Drawing.Printing.PrintDocument();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.0476189F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80.95238F));
            tableLayoutPanel1.Controls.Add(flpKatlar, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1355, 557);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // flpKatlar
            // 
            flpKatlar.AutoScroll = true;
            flpKatlar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flpKatlar.Dock = DockStyle.Fill;
            flpKatlar.FlowDirection = FlowDirection.TopDown;
            flpKatlar.Location = new Point(4, 4);
            flpKatlar.Name = "flpKatlar";
            flpKatlar.Size = new Size(251, 549);
            flpKatlar.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 68.65809F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 31.3419113F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel5, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(262, 4);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(1089, 549);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Controls.Add(flpMasalar, 0, 0);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel4, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(4, 4);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 42.0370369F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 57.9629631F));
            tableLayoutPanel3.Size = new Size(739, 541);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // flpMasalar
            // 
            flpMasalar.AutoScroll = true;
            flpMasalar.Dock = DockStyle.Fill;
            flpMasalar.Location = new Point(4, 4);
            flpMasalar.Name = "flpMasalar";
            flpMasalar.Size = new Size(731, 220);
            flpMasalar.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Controls.Add(flpKategoriler, 0, 0);
            tableLayoutPanel4.Controls.Add(flpUrunler, 0, 1);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(4, 231);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 35.9504128F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 64.04958F));
            tableLayoutPanel4.Size = new Size(731, 306);
            tableLayoutPanel4.TabIndex = 1;
            // 
            // flpKategoriler
            // 
            flpKategoriler.AutoScroll = true;
            flpKategoriler.Dock = DockStyle.Fill;
            flpKategoriler.Location = new Point(4, 4);
            flpKategoriler.Name = "flpKategoriler";
            flpKategoriler.Size = new Size(723, 102);
            flpKategoriler.TabIndex = 0;
            // 
            // flpUrunler
            // 
            flpUrunler.AutoScroll = true;
            flpUrunler.Dock = DockStyle.Fill;
            flpUrunler.Location = new Point(4, 113);
            flpUrunler.Name = "flpUrunler";
            flpUrunler.Size = new Size(723, 189);
            flpUrunler.TabIndex = 1;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.Controls.Add(tableLayoutPanel6, 0, 0);
            tableLayoutPanel5.Controls.Add(tableLayoutPanel7, 0, 1);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(750, 4);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 67.09797F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 32.9020348F));
            tableLayoutPanel5.Size = new Size(335, 541);
            tableLayoutPanel5.TabIndex = 1;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 3;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 47.11246F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.7963524F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30.0911846F));
            tableLayoutPanel6.Controls.Add(flpLabels, 0, 0);
            tableLayoutPanel6.Controls.Add(flpNuds, 1, 0);
            tableLayoutPanel6.Controls.Add(flpToplamFiyat, 2, 0);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(3, 3);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel6.Size = new Size(329, 357);
            tableLayoutPanel6.TabIndex = 0;
            // 
            // flpLabels
            // 
            flpLabels.Dock = DockStyle.Fill;
            flpLabels.Location = new Point(3, 3);
            flpLabels.Name = "flpLabels";
            flpLabels.Size = new Size(149, 351);
            flpLabels.TabIndex = 0;
            // 
            // flpNuds
            // 
            flpNuds.Dock = DockStyle.Fill;
            flpNuds.Location = new Point(158, 3);
            flpNuds.Name = "flpNuds";
            flpNuds.Size = new Size(69, 351);
            flpNuds.TabIndex = 1;
            // 
            // flpToplamFiyat
            // 
            flpToplamFiyat.Dock = DockStyle.Fill;
            flpToplamFiyat.Location = new Point(233, 3);
            flpToplamFiyat.Name = "flpToplamFiyat";
            flpToplamFiyat.Size = new Size(93, 351);
            flpToplamFiyat.TabIndex = 2;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 2;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.Controls.Add(label1, 0, 0);
            tableLayoutPanel7.Controls.Add(lblToplam, 1, 0);
            tableLayoutPanel7.Controls.Add(btnGunlukRapor, 0, 1);
            tableLayoutPanel7.Controls.Add(btnHesap, 1, 1);
            tableLayoutPanel7.Controls.Add(btnHesapKapat, 1, 2);
            tableLayoutPanel7.Controls.Add(btnAylikRapor, 0, 2);
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(3, 366);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 3;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 22.0930233F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 37.2093F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 40.6976738F));
            tableLayoutPanel7.Size = new Size(329, 172);
            tableLayoutPanel7.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(20, 0);
            label1.Margin = new Padding(20, 0, 3, 0);
            label1.Name = "label1";
            label1.Size = new Size(141, 28);
            label1.TabIndex = 0;
            label1.Text = "Toplam:";
            // 
            // lblToplam
            // 
            lblToplam.AutoSize = true;
            lblToplam.Dock = DockStyle.Top;
            lblToplam.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblToplam.Location = new Point(167, 0);
            lblToplam.Name = "lblToplam";
            lblToplam.Size = new Size(159, 31);
            lblToplam.TabIndex = 1;
            lblToplam.Text = "0";
            // 
            // btnGunlukRapor
            // 
            btnGunlukRapor.Dock = DockStyle.Fill;
            btnGunlukRapor.Location = new Point(3, 41);
            btnGunlukRapor.Name = "btnGunlukRapor";
            btnGunlukRapor.Size = new Size(158, 58);
            btnGunlukRapor.TabIndex = 3;
            btnGunlukRapor.Text = "Günlük Rapor";
            btnGunlukRapor.UseVisualStyleBackColor = true;
            btnGunlukRapor.Click += btnGunlukRapor_Click;
            // 
            // btnHesap
            // 
            btnHesap.Dock = DockStyle.Fill;
            btnHesap.Location = new Point(167, 41);
            btnHesap.Name = "btnHesap";
            btnHesap.Size = new Size(159, 58);
            btnHesap.TabIndex = 2;
            btnHesap.Text = "Adisyon";
            btnHesap.UseVisualStyleBackColor = true;
            btnHesap.Click += btnHesap_Click;
            // 
            // btnHesapKapat
            // 
            btnHesapKapat.Dock = DockStyle.Fill;
            btnHesapKapat.Location = new Point(167, 105);
            btnHesapKapat.Name = "btnHesapKapat";
            btnHesapKapat.Size = new Size(159, 64);
            btnHesapKapat.TabIndex = 4;
            btnHesapKapat.Text = "Hesap Kapat";
            btnHesapKapat.UseVisualStyleBackColor = true;
            btnHesapKapat.Click += btnHesapKapat_Click;
            // 
            // btnAylikRapor
            // 
            btnAylikRapor.Dock = DockStyle.Fill;
            btnAylikRapor.Location = new Point(3, 105);
            btnAylikRapor.Name = "btnAylikRapor";
            btnAylikRapor.Size = new Size(158, 64);
            btnAylikRapor.TabIndex = 5;
            btnAylikRapor.Text = "Aylık Rapor";
            btnAylikRapor.UseVisualStyleBackColor = true;
            btnAylikRapor.Click += btnAylikRapor_Click;
            // 
            // printAdisyon
            // 
            printAdisyon.PrintPage += printAdisyon_PrintPage;
            // 
            // printPreview
            // 
            printPreview.AutoScrollMargin = new Size(0, 0);
            printPreview.AutoScrollMinSize = new Size(0, 0);
            printPreview.ClientSize = new Size(400, 300);
            printPreview.Enabled = true;
            printPreview.Icon = (Icon)resources.GetObject("printPreview.Icon");
            printPreview.Name = "printPreview";
            printPreview.Visible = false;
            // 
            // printGunlukRapor
            // 
            printGunlukRapor.PrintPage += printGunlukRapor_PrintPage;
            // 
            // printAylikRapor
            // 
            printAylikRapor.PrintPage += printAylikRapor_PrintPage;
            // 
            // AnaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1355, 557);
            Controls.Add(tableLayoutPanel1);
            Name = "AnaForm";
            Text = "AnaForm";
            Load += AnaForm_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel7.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel flpKatlar;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private FlowLayoutPanel flpMasalar;
        private TableLayoutPanel tableLayoutPanel4;
        private FlowLayoutPanel flpKategoriler;
        private FlowLayoutPanel flpUrunler;
        private TableLayoutPanel tableLayoutPanel5;
        private TableLayoutPanel tableLayoutPanel6;
        private FlowLayoutPanel flpLabels;
        private FlowLayoutPanel flpNuds;
        private FlowLayoutPanel flpToplamFiyat;
        private TableLayoutPanel tableLayoutPanel7;
        private Label label1;
        private Label lblToplam;
        private Button btnHesap;
        private Button btnGunlukRapor;
        private System.Drawing.Printing.PrintDocument printAdisyon;
        private PrintPreviewDialog printPreview;
        private Button btnHesapKapat;
        private System.Drawing.Printing.PrintDocument printGunlukRapor;
        private Button btnAylikRapor;
        private System.Drawing.Printing.PrintDocument printAylikRapor;
    }
}