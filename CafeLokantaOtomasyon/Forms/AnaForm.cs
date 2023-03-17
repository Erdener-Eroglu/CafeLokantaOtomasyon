using AtesVeSuSiparisOtomasyonu.Data;
using AtesVeSuSiparisOtomasyonu.Helpers;
using AtesVeSuSiparisOtomasyonu.Models;
using CafeLokantaOtomasyon.Models;
using System.Drawing.Printing;
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
    GunlukRapor rapor;
    AylıkRapor aylikRapoor;

    public EnvanterContext DataContext { get; set; }
    private void AnaForm_Load(object sender, EventArgs e)
    {
        if (DataContext.GunlukRapor != null)
        {
            rapor = DataContext.GunlukRapor;
        }
        else
        {
            rapor = new GunlukRapor();
        }
        if (DataContext.AylikRapor != null)
        {
            aylikRapoor = DataContext.AylikRapor;
            btnAylikRapor.Enabled = true;
        }
        else
        {
            aylikRapoor = new AylıkRapor();
            btnAylikRapor.Enabled = false;
        }
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
            btnHesapKapat.Visible = false;
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
        btnHesapKapat.Visible = false;
        if (_clickedKat != null) _clickedKat.BackColor = Color.White;
        foreach (var item in DataContext.Masalar)
        {
            if ((sender as Button).Text == item.BulunduguKat.Ad)
            {
                Button btnMasa = new Button();
                btnMasa.Name = item.Id.ToString();
                btnMasa.Text = item.Ad;
                btnMasa.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
                btnMasa.TextAlign = ContentAlignment.MiddleCenter;
                btnMasa.ForeColor = Color.Black;
                btnMasa.Size = new Size(60, 60);
                btnMasa.Click += MasaButon_Click;
                if (item.DoluMu)
                {
                    btnMasa.BackColor = Color.DarkCyan;
                }
                else
                {
                    btnMasa.BackColor = Color.AliceBlue;
                }
                flpMasalar.Controls.Add(btnMasa);
            }
        }
        _clickedKat = sender as Button;
        _clickedKat.BackColor = Color.Gray;
    }

    private void MasaButon_Click(object sender, EventArgs e)
    {

        _seciliMasa = DataContext.Masalar.Find(x => x.Id.ToString() == (sender as Button).Name);
        if (_seciliMasa != null && _seciliMasa.DoluMu == true)
        {
            label1.Visible = true;
            btnHesap.Visible = true;
            btnHesapKapat.Visible = true;
            lblToplam.Visible = true;
        }
        else
        {
            label1.Visible = false;
            btnHesap.Visible = false;
            btnHesapKapat.Visible = false;
            lblToplam.Visible = false;
        }
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
        if (_seciliMasa.Sepet != null)
            lblToplam.Text = _seciliMasa.Sepet.ToplamFiyatHesapla().ToString("C");
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
                if (item.Foto != null)
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
            MasaRengiBoya(_seciliMasa, Color.DarkCyan);
            _seciliMasa.DoluMu = true;
            label1.Visible = true;
            btnHesap.Visible = true;
            btnHesapKapat.Visible = true;
            lblToplam.Visible = true;
            flpLabels.Controls.Add(labelAd);
            flpNuds.Controls.Add(nudAdet);
            flpToplamFiyat.Controls.Add(lblFiyat);
            lblToplam.Text = _seciliMasa.Sepet.ToplamFiyatHesapla().ToString("C");
        }
    }
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
                MasaRengiBoya(_seciliMasa, Color.AliceBlue);
                _seciliMasa.DoluMu = false;
            }
        }
        lblToplam.Text = _seciliMasa.Sepet.ToplamFiyatHesapla().ToString("C");
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
    private void btnHesap_Click(object sender, EventArgs e)
    {
        if (_seciliMasa == null) return;
        if (_seciliMasa != null && _seciliMasa.Sepet.Urunler.Count != 0)
        {
            printAdisyon.DefaultPageSettings.PaperSize = new PaperSize("Custom", 300, 400);
            printPreview.Document = printAdisyon;
            printPreview.ShowDialog();
        }


    }
    private void btnGunlukRapor_Click(object sender, EventArgs e)
    {
        btnAylikRapor.Enabled = true;
        rapor.Tarih = DateTime.Now;
        printGunlukRapor.DefaultPageSettings.PaperSize = new PaperSize("Custom", 300, 400);
        printPreview.Document = printGunlukRapor;
        printPreview.ShowDialog();
        aylikRapoor.Tarihler.Add(rapor.Tarih);
        rapor.SatılanUrunler.Clear();
        DataContext.GunlukRapor = null;
        DataHelper.Save(DataContext);
    }

    private void printAdisyon_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
    {
        int toplamUrun = 0;
        foreach (var item in _seciliMasa.Sepet.Urunler)
        {
            toplamUrun += item.SepetekiAdet;
        }
        char[] ayrac = new char[65];
        for (int i = 0; i < ayrac.Length; i++)
        {
            ayrac[i] = '-';

        }

        string ayırıcı = new string(ayrac);
        int margin = 75;
        int toplamMargin = margin;
        e.Graphics.DrawString("ÖRNEK RESTORAN", new Font("Arial", 9, FontStyle.Regular), Brushes.Black, new Point(80, 20));
        e.Graphics.DrawString("Tarih: " + DateTime.Now.ToString(), new Font("Arial", 9, FontStyle.Regular), Brushes.Black, new Point(10, 45));
        e.Graphics.DrawString("Kat / Masa: " + _seciliMasa.BulunduguKat.Ad + " / " + _seciliMasa.Ad, new Font("Arial", 9, FontStyle.Regular), Brushes.Black, new Point(10, 60));
        e.Graphics.DrawString(ayırıcı, new Font("Arial", 9, FontStyle.Regular), Brushes.Black, new Point(10, margin));
        margin += 15;
        foreach (var item in _seciliMasa.Sepet.Urunler)
        {
            e.Graphics.DrawString(item.Ad, new Font("Arial", 9, FontStyle.Regular), Brushes.Black, new Point(10, margin));
            e.Graphics.DrawString(item.SepetekiAdet.ToString("00"), new Font("Arial", 9, FontStyle.Regular), Brushes.Black, new Point(150, margin));
            e.Graphics.DrawString(item.ToplamFiyat().ToString("C"), new Font("Arial", 9, FontStyle.Regular), Brushes.Black, new Point(225, margin));
            margin += 15;
        }
        e.Graphics.DrawString(ayırıcı, new Font("Arial", 9, FontStyle.Regular), Brushes.Black, new Point(10, margin));
        margin += 15;
        e.Graphics.DrawString("Genel Toplam: ", new Font("Arial", 9, FontStyle.Regular), Brushes.Black, new Point(10, margin));
        e.Graphics.DrawString(toplamUrun.ToString("00"), new Font("Arial", 9, FontStyle.Regular), Brushes.Black, new Point(150, margin));
        e.Graphics.DrawString(_seciliMasa.Sepet.ToplamFiyatHesapla().ToString("C"), new Font("Arial", 9, FontStyle.Regular), Brushes.Black, new Point(225, margin));
    }

    private void btnHesapKapat_Click(object sender, EventArgs e)
    {
        foreach (var item in _seciliMasa.Sepet.Urunler)
        {
            rapor.UrunEkle(item);
        }
        aylikRapoor.GunlukCirolar.Add(rapor.ToplamFiyatHesapla());
        DataContext.AylikRapor = aylikRapoor;
        DataContext.GunlukRapor = rapor;
        if (_seciliMasa.Sepet.ToplamFiyatHesapla() != 0)
            _seciliMasa.Sepet.Urunler.Clear();
        MasaRengiBoya(_seciliMasa, Color.AliceBlue);
        _seciliMasa.DoluMu = false;
        flpLabels.Controls.Clear();
        flpNuds.Controls.Clear();
        flpToplamFiyat.Controls.Clear();
        lblToplam.Text = _seciliMasa.Sepet.ToplamFiyatHesapla().ToString("C");
        label1.Visible = false;
        btnHesap.Visible = false;
        lblToplam.Visible = false;
        DataHelper.Save(DataContext);
        btnHesapKapat.Visible = false;
    }

    private void printGunlukRapor_PrintPage(object sender, PrintPageEventArgs e)
    {
        int toplamUrun = 0;
        foreach (var item in rapor.SatılanUrunler)
        {
            toplamUrun += item.SepetekiAdet;
        }
        char[] ayrac = new char[65];
        for (int i = 0; i < ayrac.Length; i++)
        {
            ayrac[i] = '-';
        }
        int margin = 60;

        string ayırıcı = new string(ayrac);
        e.Graphics.DrawString("ÖRNEK RESTORAN", new Font("Arial", 9, FontStyle.Regular), Brushes.Black, new Point(80, 20));
        e.Graphics.DrawString("Tarih: " + rapor.Tarih.ToString(), new Font("Arial", 9, FontStyle.Regular), Brushes.Black, new Point(10, 45));
        e.Graphics.DrawString(ayırıcı, new Font("Arial", 9, FontStyle.Regular), Brushes.Black, new Point(10, margin));
        margin += 15;
        foreach (var item in rapor.SatılanUrunler)
        {
            e.Graphics.DrawString(item.Ad, new Font("Arial", 9, FontStyle.Regular), Brushes.Black, new Point(10, margin));
            e.Graphics.DrawString(item.SepetekiAdet.ToString("00"), new Font("Arial", 9, FontStyle.Regular), Brushes.Black, new Point(150, margin));
            e.Graphics.DrawString(item.ToplamFiyat().ToString("C"), new Font("Arial", 9, FontStyle.Regular), Brushes.Black, new Point(225, margin));
            margin += 15;
        }
        e.Graphics.DrawString(ayırıcı, new Font("Arial", 9, FontStyle.Regular), Brushes.Black, new Point(10, margin));
        margin += 15;
        e.Graphics.DrawString("Günlük Toplam: ", new Font("Arial", 9, FontStyle.Regular), Brushes.Black, new Point(10, margin));
        e.Graphics.DrawString(toplamUrun.ToString("00"), new Font("Arial", 9, FontStyle.Regular), Brushes.Black, new Point(150, margin));
        e.Graphics.DrawString(rapor.ToplamFiyatHesapla().ToString("C"), new Font("Arial", 9, FontStyle.Regular), Brushes.Black, new Point(225, margin));
    }

    private void printAylikRapor_PrintPage(object sender, PrintPageEventArgs e)
    {
        decimal toplamCiro = 0;
        foreach (var item in aylikRapoor.GunlukCirolar)
        {
            toplamCiro += item;
        }
        char[] ayrac = new char[65];
        for (int i = 0; i < ayrac.Length; i++)
        {
            ayrac[i] = '-';
        }
        int margin = 60;
        try
        {
            string ayırıcı = new string(ayrac);
            e.Graphics.DrawString("ÖRNEK RESTORAN", new Font("Arial", 9, FontStyle.Regular), Brushes.Black, new Point(80, 20));
            e.Graphics.DrawString("Tarih: " + rapor.Tarih.ToString(), new Font("Arial", 9, FontStyle.Regular), Brushes.Black, new Point(10, 45));
            e.Graphics.DrawString(ayırıcı, new Font("Arial", 9, FontStyle.Regular), Brushes.Black, new Point(10, margin));
            margin += 15;
            if (aylikRapoor.GunlukCirolar.Count > 0)
            {
                for (int i = 0; i < aylikRapoor.GunlukCirolar.Count; i++)
                {
                    e.Graphics.DrawString(aylikRapoor.Tarihler[i].ToString(), new Font("Arial", 9, FontStyle.Regular), Brushes.Black, new Point(10, margin));
                    e.Graphics.DrawString(aylikRapoor.GunlukCirolar[i].ToString("C"), new Font("Arial", 9, FontStyle.Regular), Brushes.Black, new Point(150, margin));
                    margin += 15;

                }
            }
            e.Graphics.DrawString(ayırıcı, new Font("Arial", 9, FontStyle.Regular), Brushes.Black, new Point(10, margin));
            margin += 15;
            e.Graphics.DrawString("Aylık Toplam Ciro: ", new Font("Arial", 9, FontStyle.Regular), Brushes.Black, new Point(10, margin));
            e.Graphics.DrawString(toplamCiro.ToString("C"), new Font("Arial", 9, FontStyle.Regular), Brushes.Black, new Point(150, margin));
        }
        catch
        {
            MessageBox.Show("Önce Günlük Raporu Oluşturun");
            return;
        }


    }

    private void btnAylikRapor_Click(object sender, EventArgs e)
    {
        btnAylikRapor.Enabled = false;
        printAylikRapor.DefaultPageSettings.PaperSize = new PaperSize("Custom", 300, 400);
        printPreview.Document = printAylikRapor;
        printPreview.ShowDialog();
        DataContext.AylikRapor = null;
        aylikRapoor.GunlukCirolar.Clear();
        aylikRapoor.Tarihler.Clear();
        DataHelper.Save(DataContext);
    }
}
