using AtesVeSuSiparisOtomasyonu.Data;
using AtesVeSuSiparisOtomasyonu.Helpers;
using AtesVeSuSiparisOtomasyonu.Models;

namespace AtesVeSuSiparisOtomasyonu.Forms
{
    public partial class UrunForm : Form
    {
        public UrunForm()
        {
            InitializeComponent();
        }
        public EnvanterContext DataContext { get; set; }
        private void UrunForm_Load(object sender, EventArgs e)
        {
            cmbKategori.DataSource = DataContext.Kategoriler;
            lstUrunler.DataSource = DataContext.Urunler;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                Urun urun = new Urun()
                {
                    Kategori = (Kategori)cmbKategori.SelectedItem,
                    Ad = txtUrunAdi.Text,
                    Fiyat = decimal.Parse(txtUrunFiyat.Text),

                };
                if (pbUrunFoto.Image != null)
                {
                    urun.Foto = (byte[])(new ImageConverter().ConvertTo(pbUrunFoto.Image, typeof(byte[])));
                }
                DataContext.Urunler.Add(urun);
                lstUrunler.DataSource = null;
                lstUrunler.DataSource = DataContext.Urunler;
                DataHelper.Save(DataContext);
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Bir Hata Oluştu: {ex.Message}");
            }
        }

        private void pbUrunFoto_Click(object sender, EventArgs e)
        {
            //OpenFileDialog dosyaAc = new OpenFileDialog();
            dosyaAc.Title = "Resim Seçiniz";
            dosyaAc.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            dosyaAc.Multiselect = false;
            dosyaAc.Filter = "Resim Dosyası |*.jpg;*.png;*.jpeg";
            if (dosyaAc.ShowDialog() == DialogResult.OK)
            {
                pbUrunFoto.Image = Image.FromFile(dosyaAc.FileName);
            }
        }

        private void lstUrunler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstUrunler.SelectedItem == null) return;
            Urun urun = (Urun)lstUrunler.SelectedItem;
            txtUrunAdi.Text = urun.Ad;
            txtUrunFiyat.Text = urun.Fiyat.ToString();
            cmbKategori.SelectedItem = DataContext.Kategoriler.Find(x => x.Ad == urun.Kategori.Ad);
            if (urun.Foto != null)
            {
                pbUrunFoto.Image = (Image)(new ImageConverter().ConvertFrom(urun.Foto));
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (lstUrunler.SelectedItem == null) return;
            Urun urun = (Urun)lstUrunler.SelectedItem;
            try
            {
                if (pbUrunFoto.Image != null)
                {
                    urun.Foto = (byte[])(new ImageConverter().ConvertTo(pbUrunFoto.Image, typeof(byte[])));
                }
                urun.Ad = txtUrunAdi.Text;
                urun.Fiyat = decimal.Parse(txtUrunFiyat.Text);
                urun.Kategori = (Kategori)cmbKategori.SelectedItem;
                lstUrunler.DataSource = null;
                lstUrunler.DataSource = DataContext.Urunler;
                DataHelper.Save(DataContext);
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Bir Hata Oluştu: {ex.Message}");
            }
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lstUrunler.SelectedItem == null)
            {
                return;
            }
            Urun seciliUrun = (Urun)lstUrunler.SelectedItem;
            DataContext.Urunler.Remove(seciliUrun);
            DataHelper.Save(DataContext);
            lstUrunler.DataSource = null;
            lstUrunler.DataSource = DataContext.Urunler;
        }
    }
}
