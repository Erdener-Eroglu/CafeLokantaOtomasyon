namespace AtesVeSuSiparisOtomasyonu.Models;

public class Kat
{
    public string Ad { get; set; }
    public int MasaSayisi { get; set; }

    public override string ToString()
    {
        return $"{Ad}-{MasaSayisi}";
    }
}
