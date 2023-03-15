namespace AtesVeSuSiparisOtomasyonu.Models;

public class Sepet
{
    public List<Urun> Urunler { get; set; } = new List<Urun>();

    public decimal ToplamFiyatHesapla()
    {
        decimal toplam = 0;
        foreach (var item in Urunler)
        {
            toplam += item.ToplamFiyat();
        }
        return toplam;
    }
}
