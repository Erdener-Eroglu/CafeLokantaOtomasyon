using AtesVeSuSiparisOtomasyonu.Models;

namespace CafeLokantaOtomasyon.Models;

public class GunlukRapor
{
    private DateTime dateTime = DateTime.Now;
    public List<Urun> SatılanUrunler { get; set; } = new List<Urun>();
    private static readonly string Path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\GünlükRapor.txt";
    public int SatılmaSayisi { get; set; }
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
    public void GunlukRaporOlustur()
    {
        FileStream file = File.Open(Path, FileMode.Append);
        StreamWriter writer = new StreamWriter(file);
        writer.WriteLine($"Oluşturulma Tarihi: {dateTime.ToString()}");
        foreach (var item in SatılanUrunler)
        {
            writer.WriteLine($"{item.Ad}-{item.SepetekiAdet}");
        }
        writer.Close();
        writer.Dispose();
    }

}
