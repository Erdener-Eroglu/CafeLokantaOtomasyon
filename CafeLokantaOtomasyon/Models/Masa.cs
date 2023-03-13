using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtesVeSuSiparisOtomasyonu.Models;

public class Masa
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Ad { get; set; }
    public Kat BulunduguKat { get; set; }
    public bool DoluMu { get; set; }

    public Sepet Sepet { get; set; }
}
