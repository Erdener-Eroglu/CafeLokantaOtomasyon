using AtesVeSuSiparisOtomasyonu.Data;
using AtesVeSuSiparisOtomasyonu.Forms;
using AtesVeSuSiparisOtomasyonu.Helpers;

namespace AtesVeSuSiparisOtomasyonu;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }
    private EnvanterContext _dataContext;
    private KatEkleForm _katEkleForm;
    private AnaForm _anaForm;
    private KategoriForm _kategoriForm;
    private UrunForm _urunForm;
    private void Form1_Load(object sender, EventArgs e)
    {
        var data = DataHelper.Load();
        _dataContext = data ?? new EnvanterContext();
        anaEkranToolStripMenuItem_Click(this, new EventArgs());
    }

    private void anaEkranToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (_katEkleForm != null) _katEkleForm.Close();
        if (_urunForm != null) _urunForm.Close();
        if (_kategoriForm != null) _kategoriForm.Close();
        if (_anaForm == null || _anaForm.IsDisposed)
        {
            _anaForm = new AnaForm();
            _anaForm.MdiParent = this;
            _anaForm.Text = "Ana Sayfa";
            _anaForm.WindowState = FormWindowState.Maximized;
            _anaForm.DataContext = _dataContext;
            _anaForm.Show();
        }
    }

    private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (_anaForm != null) _anaForm.Close();
        if (_kategoriForm != null) _kategoriForm.Close();
        if (_urunForm != null) _urunForm.Close();
        if (_katEkleForm == null || _katEkleForm.IsDisposed)
        {
            _katEkleForm = new KatEkleForm();
            _katEkleForm.MdiParent = this;
            _katEkleForm.Text = "Kat Düzenle";
            _katEkleForm.WindowState = FormWindowState.Maximized;
            _katEkleForm.DataContext = _dataContext;
            _katEkleForm.Show();
        }
    }

    private void kategoriDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (_anaForm != null) _anaForm.Close();
        if (_katEkleForm != null) _katEkleForm.Close();
        if (_urunForm != null) _urunForm.Close();
        if (_kategoriForm == null || _kategoriForm.IsDisposed)
        {
            _kategoriForm = new KategoriForm();
            _kategoriForm.MdiParent = this;
            _kategoriForm.Text = "Kategori Düzenle";
            _kategoriForm.WindowState = FormWindowState.Maximized;
            _kategoriForm.DataContext = _dataContext;
            _kategoriForm.Show();
        }
    }

    private void ürünDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (_anaForm != null) _anaForm.Close();
        if (_katEkleForm != null) _katEkleForm.Close();
        if (_kategoriForm != null) _kategoriForm.Close();
        if (_urunForm == null || _urunForm.IsDisposed)
        {
            _urunForm = new UrunForm();
            _urunForm.MdiParent = this;
            _urunForm.Text = "Ürün Düzenle";
            _urunForm.WindowState = FormWindowState.Maximized;
            _urunForm.DataContext = _dataContext;
            _urunForm.Show();
        }
    }
}