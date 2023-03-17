using AtesVeSuSiparisOtomasyonu.Models;
using CafeLokantaOtomasyon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtesVeSuSiparisOtomasyonu.Data;

public class EnvanterContext
{
    public List<Kat> Katlar { get; set; } = new List<Kat>();
    public List<Masa> Masalar { get; set; } = new List<Masa>();
    public List<Kategori> Kategoriler { get; set; } = new List<Kategori>();
    public List<Sepet> Sepetler { get; set; } = new List<Sepet>();
    public List<Urun> Urunler { get; set; } = new List<Urun>();
    public GunlukRapor GunlukRapor { get; set; }
    public AylıkRapor AylikRapor { get; set; }
}
