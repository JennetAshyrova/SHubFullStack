using System;
using System.Collections.Generic;
using System.Text;

namespace Konu14InterfacesArayuzler
{
    internal class Urun : ISinifGereksinimleri
    {
        public int Id { get; set; }   // nesnenin benzersiz kimlik değeri 
        public DateTime CreateDate { get; set; }  // nesnenin oluşma zamanını tutacak özellik
        public DateTime UpdateDate { get; set; }  // nesnenin son güncelleme zamanını tutacak özellik 
        public bool IsActive { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public string? İmage { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
    }
}
