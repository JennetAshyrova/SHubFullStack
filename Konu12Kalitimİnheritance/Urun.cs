using System;
using System.Collections.Generic;
using System.Text;

namespace Konu12Kalitimİnheritance
{
    public class Urun : OrtakOzellikler
    {
        public decimal Fiyat { get; set; }
        public int Stok { get; set; }
        public int Kdv { get; set; }
        public int Iskonto { get; set; }
        public string? TeknikOzellikler { get; set; }    //ürün eklerken teknik özellikler boş geçilebilsin diye
    }
}
