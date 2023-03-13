namespace AtesVeSuSiparisOtomasyonu.Models;

public class Urun
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Ad { get; set; }
    public decimal Fiyat { get; set; }
    public Kategori Kategori { get; set; }
    public int SepetekiAdet { get; set; }
    public byte[]? Foto { get; set; } = null;
    public decimal ToplamFiyat()
    {
        return Fiyat * SepetekiAdet;
    }

    public override string ToString()
    {
        return $"{Kategori.Ad}-{Ad}-{Fiyat}";
    }
}
