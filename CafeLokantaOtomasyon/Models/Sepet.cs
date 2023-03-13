namespace AtesVeSuSiparisOtomasyonu.Models;

public class Sepet
{
    public decimal ToplamFiyat { get; set; }
    public List<Urun> Urunler { get; set; } = new List<Urun>();
}
