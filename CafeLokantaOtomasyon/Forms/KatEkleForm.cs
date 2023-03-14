using AtesVeSuSiparisOtomasyonu.Data;
using AtesVeSuSiparisOtomasyonu.Helpers;
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

namespace AtesVeSuSiparisOtomasyonu.Forms;

public partial class KatEkleForm : Form
{
    public KatEkleForm()
    {
        InitializeComponent();
    }
    public EnvanterContext DataContext { get; set; }
    private void btnKaydet_Click(object sender, EventArgs e)
    {
        try
        {
            Kat kat = new Kat()
            {
                Ad = txtKatIsmi.Text,
                MasaSayisi = Convert.ToInt32(txtMasaSayisi.Text)
            };
            DataContext.Katlar.Add(kat);
            lstKatlar.DataSource = null;
            lstKatlar.DataSource = DataContext.Katlar;
            for (int i = 1; i <= kat.MasaSayisi; i++)
            {
                Masa masa = new Masa()
                {
                    BulunduguKat = kat,
                    Ad = "M" + i.ToString()
                };
                DataContext.Masalar.Add(masa);
            }
            DataHelper.Save(DataContext);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Bir Hata Oluştu: {ex.Message}");
        }
    }

    private void KatEkleForm_Load(object sender, EventArgs e)
    {
        lstKatlar.DataSource = DataContext.Katlar;
    }

    private void btnGuncelle_Click(object sender, EventArgs e)
    {
        if (lstKatlar.SelectedItem == null)
        {
            return;
        }
        Kat seciliKat = (Kat)lstKatlar.SelectedItem;
        try
        {
            seciliKat.Ad = txtKatIsmi.Text;
            seciliKat.MasaSayisi = Convert.ToInt32(txtMasaSayisi.Text);
            for (int i = 0; i < DataContext.Masalar.Count; i++)
            {
                if (seciliKat.Ad == DataContext.Masalar[i].BulunduguKat.Ad)
                {
                    DataContext.Masalar.Remove(DataContext.Masalar[i]);
                    i--;
                }

            }
            for (int i = 1; i <= seciliKat.MasaSayisi; i++)
            {
                Masa masa = new Masa()
                {
                    BulunduguKat = seciliKat,
                    Ad = "M" + i.ToString()
                };
                DataContext.Masalar.Add(masa);
            }
            DataHelper.Save(DataContext);
            lstKatlar.DataSource = null;
            lstKatlar.DataSource = DataContext.Katlar;
        }
        catch (Exception ex)
        {

            MessageBox.Show($"Bir Hata Oluştu: {ex.Message}");
        }
    }

    private void lstKatlar_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (lstKatlar.SelectedItem == null)
        {
            return;
        }
        Kat seciliKat = (Kat)lstKatlar.SelectedItem;
        txtKatIsmi.Text = seciliKat.Ad;
        txtMasaSayisi.Text = seciliKat.MasaSayisi.ToString();
    }

    private void silToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (lstKatlar.SelectedItem == null)
        {
            return;
        }
        Kat seciliKat = (Kat)lstKatlar.SelectedItem;
        DataContext.Katlar.Remove(seciliKat);
        for (int i = 0; i < DataContext.Masalar.Count; i++)
        {
            if (seciliKat.Ad == DataContext.Masalar[i].BulunduguKat.Ad)
            {
                DataContext.Masalar.Remove(DataContext.Masalar[i]);
                i--;
            }
        }
        DataHelper.Save(DataContext);
        lstKatlar.DataSource = null;
        lstKatlar.DataSource = DataContext.Katlar;

    }
}
