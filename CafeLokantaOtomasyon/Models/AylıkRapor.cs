namespace CafeLokantaOtomasyon.Models;

public class AylıkRapor
{
    public List<decimal> GunlukCirolar { get; set; } = new List<decimal>();
    public List<DateTime> Tarihler { get; set; } = new List<DateTime>();
}
