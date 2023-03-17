using AtesVeSuSiparisOtomasyonu.Data;
using AtesVeSuSiparisOtomasyonu.Helpers;
using AtesVeSuSiparisOtomasyonu.Models;

namespace AtesVeSuSiparisOtomasyonu.Forms;

public partial class KategoriForm : Form
{
    public KategoriForm()
    {
        InitializeComponent();
    }
    public EnvanterContext DataContext { get; set; }
    private void btnKaydet_Click(object sender, EventArgs e)
    {
        try
        {
            if (AynisiVarMi(txtKategori.Text))
            {
                MessageBox.Show("Bu kategori bulunmaktadır. Lütfen adını değiştirin");
                txtKategori.Clear();
                return;
            }
            Kategori kategori = new Kategori();
            kategori.Ad = txtKategori.Text;
            DataContext.Kategoriler.Add(kategori);
            lstKategori.DataSource = null;
            lstKategori.DataSource = DataContext.Kategoriler;
            DataHelper.Save(DataContext);
            FormuTemzile();
        }
        catch (Exception ex)
        {

            MessageBox.Show($"Bir Hata Oluştu: {ex.Message}");
        }

    }

    private void KategoriForm_Load(object sender, EventArgs e)
    {
        lstKategori.DataSource = DataContext.Kategoriler;
        FormuTemzile();
    }

    private void lstKategori_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (lstKategori.SelectedItem == null)
        {
            btnGuncelle.Enabled = false;
            btnKaydet.Enabled = true;
            return;
        }
        btnKaydet.Enabled = false;
        btnGuncelle.Enabled = true;
        Kategori seciliKategori = (Kategori)lstKategori.SelectedItem;
        txtKategori.Text = seciliKategori.Ad;
    }

    private void btnGuncelle_Click(object sender, EventArgs e)
    {
        if (lstKategori.SelectedItem == null)
        {
            return;
        }
        try
        {

            Kategori seciliKategori = (Kategori)lstKategori.SelectedItem;
            if (seciliKategori.Ad != txtKategori.Text)
            {
                if (AynisiVarMi(txtKategori.Text))
                {
                    MessageBox.Show("Bu ürün bulunmaktadır. Lütfen adını değiştirin");
                    txtKategori.Clear();
                    return;
                }
            }
            seciliKategori.Ad = txtKategori.Text;
            lstKategori.DataSource = null;
            lstKategori.DataSource = DataContext.Kategoriler;
            DataHelper.Save(DataContext);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Bir Hata Oluştu: {ex.Message}");
        }
        FormuTemzile();
    }

    private void silToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (lstKategori.SelectedItem == null)
        {
            return;
        }

        Kategori seciliKategori = (Kategori)lstKategori.SelectedItem;
        DataContext.Kategoriler.Remove(seciliKategori);
        for (int i = 0; i < DataContext.Urunler.Count; i++)
        {
            if (seciliKategori.Ad == DataContext.Urunler[i].Kategori.Ad)
            {
                DataContext.Urunler.Remove(DataContext.Urunler[i]);
                i--;
            }
        }
        lstKategori.DataSource = null;
        lstKategori.DataSource = DataContext.Kategoriler;
        DataHelper.Save(DataContext);

    }
    private void FormuTemzile()
    {
        txtKategori.Clear();
        lstKategori.SelectedIndex = -1;
    }

    private void KategoriForm_Click(object sender, EventArgs e)
    {
        lstKategori.SelectedIndex = -1;
        //FormuTemzile();
    }

    private bool AynisiVarMi(string kategoriIsmi)
    {
        foreach (var item in DataContext.Kategoriler)
        {
            if (kategoriIsmi.ToLower() == item.Ad.ToLower())
            {
                return true;
            }
        }
        return false;
    }
}
