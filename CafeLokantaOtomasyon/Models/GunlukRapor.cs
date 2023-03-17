using AtesVeSuSiparisOtomasyonu.Models;

namespace CafeLokantaOtomasyon.Models;

public class GunlukRapor
{
    public DateTime Tarih { get; set; } = DateTime.Now;
    public List<Urun> SatılanUrunler { get; set; } = new List<Urun>();
    public void UrunEkle(Urun urun)
    {
        foreach (var item in SatılanUrunler)
        {
            if(urun.Ad == item.Ad)
            {
                item.SepetekiAdet += urun.SepetekiAdet;
                return;
            }
        }
        SatılanUrunler.Add(urun);
    }
    public decimal ToplamFiyatHesapla()
    {
        decimal toplam = 0;
        foreach (var item in SatılanUrunler)
        {
            toplam += item.ToplamFiyat();
        }
        return toplam;
    }
}
