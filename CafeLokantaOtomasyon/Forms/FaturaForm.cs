using AtesVeSuSiparisOtomasyonu.Forms;
using AtesVeSuSiparisOtomasyonu.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeLokantaOtomasyon.Forms
{
    public partial class FaturaForm : Form
    {
        public FaturaForm()
        {
            InitializeComponent();
        }
        public Masa SeciliMasa { get; set; }
        public bool HesapAlindiMi { get; set; } = false;
        private void FaturaForm_Load(object sender, EventArgs e)
        {
            if (SeciliMasa == null || SeciliMasa.Sepet.Urunler.Count == 0)
            {
                this.Close();
                return;
            }
            rtFatura.Clear();
            rtFatura.SelectionColor = Color.Red;
            rtFatura.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            rtFatura.AppendText(string.Format("{0,-20}  {1,-20}  {2,0}", "Ürün", "Ürün Adeti", "Fiyat" + "\n" + "\n"));
            foreach (var item in SeciliMasa.Sepet.Urunler)
            {
                rtFatura.SelectionFont = new Font("Segoe UI", 12F, FontStyle.Underline);
                rtFatura.AppendText(string.Format("{0,-20}  {1,-20}  {2:C}", item.Ad, item.SepetekiAdet, item.ToplamFiyat().ToString("C") + "\n" + "\n"));
            }
            rtFatura.SelectionColor = Color.Red;
            rtFatura.AppendText(string.Format("{0,-20}  {1,-20}  {2,0}", "Toplam", SeciliMasa.Sepet.Urunler.Count, SeciliMasa.Sepet.ToplamFiyatHesapla().ToString("C")));
        }

        private void yazdırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreview.Document = dosyaYazdir;
            printPreview.ShowDialog();
        }

        private void dosyaYazdir_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(rtFatura.Text, new Font("Microsoft Sans Serif", 18, FontStyle.Bold), Brushes.Black, new Point(10, 10));
        }


    }
}
