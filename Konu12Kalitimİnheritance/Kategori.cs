using System;
using System.Collections.Generic;
using System.Text;

namespace Konu12Kalitimİnheritance
{
    public class Kategori: OrtakOzellikler

    {
        public string? Resim { get; set; }
        public bool UstMenudeGoster { get; set; }
        public bool YanMenudeGoster { get; set; }
        public bool AltMenudeGoster { get; set; }
    }
}
