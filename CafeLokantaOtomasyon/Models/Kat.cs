using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

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
