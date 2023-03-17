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
            pbUrunFoto.BackgroundImageLayout = ImageLayout.Stretch;
            cmbKategori.DataSource = DataContext.Kategoriler;
            lstUrunler.DataSource = DataContext.Urunler;
            FormuTemizle();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (AynisiVarMi(txtUrunAdi.Text))
                {
                    MessageBox.Show("Bu ürün bulunmaktadır. Lütfen adını değiştirin");
                    txtUrunAdi.Clear();
                    return;
                }
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
                DataContext.Urunler.Add(urun);//DataContexte Eklemezsen Kaydedemezsin.
                lstUrunler.DataSource = null;
                lstUrunler.DataSource = DataContext.Urunler;
                DataHelper.Save(DataContext);
                FormuTemizle();
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
            dosyaAc.Multiselect = false; //Çoklu resim seçmeyi kapatıyoruz.
            dosyaAc.Filter = "Resim Dosyası |*.jpg;*.png;*.jpeg"; //Seçilebilecek dosya türlerini belirliyoruz.
            if (dosyaAc.ShowDialog() == DialogResult.OK)
            {
                pbUrunFoto.Image = Image.FromFile(dosyaAc.FileName);
            }
        }

        private void lstUrunler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstUrunler.SelectedItem == null)
            {
                btnGuncelle.Enabled = false;
                btnKaydet.Enabled = true;
                return;
            }
            btnGuncelle.Enabled = true;
            btnKaydet.Enabled = false;
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
                if (AynisiVarMi(txtUrunAdi.Text))
                {
                    MessageBox.Show("Bu ürün bulunmaktadır. Lütfen adını değiştirin");
                    txtUrunAdi.Clear();
                    return;
                }
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
                FormuTemizle();

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
        private void FormuTemizle()
        {
            txtUrunAdi.Clear();
            txtUrunFiyat.Clear();
            cmbKategori.SelectedIndex = -1;
            lstUrunler.SelectedIndex = -1;
            pbUrunFoto.Image = null;
        }

        private void UrunForm_Click(object sender, EventArgs e)
        {
            lstUrunler.SelectedIndex = -1;
            cmbKategori.SelectedIndex = -1;
            //FormuTemizle();
        }
        private bool AynisiVarMi(string urunIsmi)
        {
            foreach (var item in DataContext.Urunler)
            {
                if (urunIsmi.ToLower() == item.Ad.ToLower())
                {
                    return true;
                }
            }
            return false;
        }
    }
}
