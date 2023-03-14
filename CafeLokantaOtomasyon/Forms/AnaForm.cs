using AtesVeSuSiparisOtomasyonu.Data;
using AtesVeSuSiparisOtomasyonu.Helpers;
using AtesVeSuSiparisOtomasyonu.Models;
using CafeLokantaOtomasyon.Models;

namespace AtesVeSuSiparisOtomasyonu.Forms;

public partial class AnaForm : Form
{
    public AnaForm()
    {
        InitializeComponent();
    }
    private Masa _seciliMasa;
    private Button _clickedKategori;
    private Button _clickedKat;
    Urun eklenecekUrun;
    GunlukRapor rapor = new GunlukRapor();

    public EnvanterContext DataContext { get; set; }
    private void AnaForm_Load(object sender, EventArgs e)
    {
        foreach (var item in DataContext.Katlar)
        {
            Button btn = new Button();
            btn.Text = item.Ad;
            btn.Size = new Size(180, 50);
            btn.Click += KatButon_Click;
            flpKatlar.Controls.Add(btn);
            label1.Visible = false;
            lblToplam.Visible = false;
            btnHesap.Visible = false;
        }
    }

    private void KatButon_Click(object sender, EventArgs e)
    {
        flpMasalar.Controls.Clear();
        flpKategoriler.Controls.Clear();
        flpUrunler.Controls.Clear();
        flpNuds.Controls.Clear();
        flpLabels.Controls.Clear();
        flpToplamFiyat.Controls.Clear();
        label1.Visible = false;
        lblToplam.Visible = false;
        btnHesap.Visible = false;
        if (_clickedKat != null) _clickedKat.BackColor = Color.White;
        foreach (var item in DataContext.Masalar)
        {
            if ((sender as Button).Text == item.BulunduguKat.Ad)
            {
                Button btnMasa = new Button();
                btnMasa.Name = item.Id.ToString();
                btnMasa.Text = item.Ad;
                btnMasa.Size = new Size(60, 60);
                btnMasa.Click += MasaButon_Click;
                if (item.DoluMu)
                {
                    btnMasa.BackColor = Color.Red;
                }
                else
                {
                    btnMasa.BackColor = Color.Green;
                }
                flpMasalar.Controls.Add(btnMasa);
            }
        }
        _clickedKat = sender as Button;
        _clickedKat.BackColor = Color.Gray;
    }

    private void MasaButon_Click(object sender, EventArgs e)
    {
        label1.Visible = true;
        btnHesap.Visible = true;
        lblToplam.Visible = true;
        flpKategoriler.Controls.Clear();
        flpUrunler.Controls.Clear();
        flpNuds.Controls.Clear();
        flpLabels.Controls.Clear();
        flpToplamFiyat.Controls.Clear();
        foreach (var item in DataContext.Kategoriler)
        {
            Button btnKategori = new Button();
            btnKategori.Text = item.Ad;
            btnKategori.Size = new Size(125, 50);
            btnKategori.Click += KategoriButon_Click;
            flpKategoriler.Controls.Add(btnKategori);
        }
        _seciliMasa = DataContext.Masalar.Find(x => x.Id.ToString() == (sender as Button).Name);
        lblToplam.Text = TotalFiyat(_seciliMasa.Sepet).ToString();

        if (_seciliMasa.Sepet != null)
        {
            foreach (var item in _seciliMasa.Sepet.Urunler)
            {
                Label lblAd = new Label();
                lblAd.Text = item.Ad;
                lblAd.Name = item.Ad;
                lblAd.Margin = new Padding(3, 0, 3, 10);
                lblAd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
                NumericUpDown nudAdet = new NumericUpDown();
                nudAdet.Name = item.Id.ToString();
                nudAdet.Size = new Size(50, 20);
                nudAdet.Value = item.SepetekiAdet;
                nudAdet.ValueChanged += NudValue_Change;

                Label lblFiyatM = new Label();
                lblFiyatM.Name = "lbl" + item.Id.ToString();
                lblFiyatM.Margin = new Padding(3, 0, 3, 10);
                lblFiyatM.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
                lblFiyatM.Text = item.ToplamFiyat().ToString();
                flpToplamFiyat.Controls.Add(lblFiyatM);
                flpLabels.Controls.Add(lblAd);
                flpNuds.Controls.Add(nudAdet);
            }
        }
    }

    private void KategoriButon_Click(object sender, EventArgs e)
    {
        flpUrunler.Controls.Clear();
        if (_clickedKategori != null) _clickedKategori.BackColor = Color.White;

        foreach (var item in DataContext.Urunler)
        {
            if ((sender as Button).Text == item.Kategori.Ad)
            {
                Button btnUrun = new Button();
                btnUrun.Text = item.Ad;
                btnUrun.Size = new Size(250, 200);
                btnUrun.BackgroundImage = (Image)(new ImageConverter().ConvertFrom(item.Foto));
                btnUrun.BackgroundImageLayout = ImageLayout.Stretch;
                btnUrun.Click += UrunButon_Click;
                flpUrunler.Controls.Add(btnUrun);
            }
        }
        _clickedKategori = sender as Button;
        _clickedKategori.BackColor = Color.Gray;

    }

    private void UrunButon_Click(object sender, EventArgs e)
    {


        if (_seciliMasa == null) return;
        if (_seciliMasa.Sepet == null)
        {
            _seciliMasa.Sepet = new Sepet();
        }
        Urun _seciliUrun = _seciliMasa.Sepet.Urunler.Find(x => x.Ad == (sender as Button).Text);

        if (_seciliMasa.Sepet.Urunler.Contains(_seciliUrun))
        {
            foreach (var item in flpNuds.Controls)
            {
                if (item is NumericUpDown nud)
                {
                    if (nud.Name == _seciliUrun.Id.ToString())
                    {
                        nud.Value = _seciliUrun.SepetekiAdet + 1;
                    }
                }
            }
            DataContext.Sepetler.Add(_seciliMasa.Sepet);
            DataHelper.Save(DataContext);
        }
        else
        {
            Urun urunOzellik = DataContext.Urunler.Find(x => x.Ad == (sender as Button).Text);
            eklenecekUrun = new Urun()
            {
                Ad = urunOzellik.Ad,
                Fiyat = urunOzellik.Fiyat,
                Foto = urunOzellik.Foto,
                Kategori = urunOzellik.Kategori,
                SepetekiAdet = urunOzellik.SepetekiAdet
            };
            Label labelAd = new Label();
            NumericUpDown nudAdet = new NumericUpDown();
            eklenecekUrun.SepetekiAdet = 1;
            labelAd.Name = eklenecekUrun.Ad;
            labelAd.Margin = new Padding(3, 0, 3, 10);
            labelAd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nudAdet.Name = eklenecekUrun.Id.ToString();
            labelAd.Text = eklenecekUrun.Ad;
            nudAdet.Value = eklenecekUrun.SepetekiAdet;
            nudAdet.Size = new Size(50, 20);
            nudAdet.ValueChanged += NudValue_Change;
            Label lblFiyat = new Label();
            lblFiyat.Margin = new Padding(3, 0, 3, 10);
            lblFiyat.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblFiyat.Text = (eklenecekUrun.Fiyat * eklenecekUrun.SepetekiAdet).ToString();
            lblFiyat.Name = "lbl" + eklenecekUrun.Id.ToString();
            _seciliMasa.Sepet.Urunler.Add(eklenecekUrun);
            MasaRengiBoya(_seciliMasa, Color.Red);
            _seciliMasa.DoluMu = true;
            flpLabels.Controls.Add(labelAd);
            flpNuds.Controls.Add(nudAdet);
            flpToplamFiyat.Controls.Add(lblFiyat);
            lblToplam.Text = TotalFiyat(_seciliMasa.Sepet).ToString();
        }

    }
    string toplamFiyat = "0";
    private void NudValue_Change(object sender, EventArgs e)
    {

        NumericUpDown nud = (sender as NumericUpDown);
        Urun _seciliUrun = _seciliMasa.Sepet.Urunler.Find(x => x.Id.ToString() == nud.Name);
        if (_seciliMasa.Sepet.Urunler.Contains(_seciliUrun))
        {
            _seciliUrun.SepetekiAdet = (int)nud.Value;
        }
        foreach (var item in flpToplamFiyat.Controls)
        {
            if (item is Label lbl)
            {
                if (lbl.Name == "lbl" + _seciliUrun.Id.ToString())
                {
                    lbl.Text = _seciliUrun.ToplamFiyat().ToString();
                }
            }
        }
        if (nud.Value == 0)
        {
            _seciliMasa.Sepet.Urunler.Remove(_seciliUrun);
            UrunTemizle(_seciliUrun);
            if (_seciliMasa.Sepet.Urunler.Count == 0)
            {
                MasaRengiBoya(_seciliMasa, Color.Green);
                _seciliMasa.DoluMu = false;
            }
        }
        lblToplam.Text = TotalFiyat(_seciliMasa.Sepet).ToString();
        DataContext.Sepetler.Add(_seciliMasa.Sepet);
        DataHelper.Save(DataContext);
    }

    private void MasaRengiBoya(Masa masa, Color color)
    {
        foreach (var item in flpMasalar.Controls)
        {

            if (item is Button btn)
            {
                if (btn.Name == masa.Id.ToString())
                {
                    btn.BackColor = color;
                }
            }

        }
    }
    private void UrunTemizle(Urun urun)
    {
        foreach (var item in flpNuds.Controls)
        {
            if (item is NumericUpDown nud)
            {
                if (nud.Name == urun.Id.ToString())
                {
                    flpNuds.Controls.Remove(nud);
                }
            }
        }
        foreach (var item in flpLabels.Controls)
        {
            if (item is Label lbl)
            {
                if (lbl.Name == urun.Ad)
                {
                    flpLabels.Controls.Remove(lbl);
                }
            }
        }
        foreach (var item in flpToplamFiyat.Controls)
        {
            if (item is Label lbl)
            {
                if (lbl.Name == "lbl" + urun.Id.ToString())
                {
                    flpToplamFiyat.Controls.Remove(lbl);
                }
            }
        }
    }

    private decimal TotalFiyat(Sepet sepet)
    {
        decimal total = 0;
        if (sepet != null)
        {
            foreach (var item in sepet.Urunler)
            {
                total += item.ToplamFiyat();
            }
        }

        return total;
    }

    private void btnHesap_Click(object sender, EventArgs e)
    {
        if (_seciliMasa == null) return;
        foreach (var item in _seciliMasa.Sepet.Urunler)
        {
            rapor.UrunEkle(item);
        }
        if (TotalFiyat(_seciliMasa.Sepet) != 0)
            _seciliMasa.Sepet.Urunler.Clear();
        MasaRengiBoya(_seciliMasa, Color.Green);
        _seciliMasa.DoluMu = false;
        flpLabels.Controls.Clear();
        flpNuds.Controls.Clear();
        flpToplamFiyat.Controls.Clear();
        lblToplam.Text = TotalFiyat(_seciliMasa.Sepet).ToString();
        DataHelper.Save(DataContext);
    }

    private void btnGunlukRapor_Click(object sender, EventArgs e)
    {
        if (rapor.SatılanUrunler.Count == 0)
        {
            MessageBox.Show("Satılan bir ürün bulunmamaktadır.");
            return;
        }
        rapor.GunlukRaporOlustur();
        MessageBox.Show("Raporunuz Masaüstünde GünlükRapor.txt olarak oluşturuldu.");
        rapor.SatılanUrunler.Clear();
    }
}
