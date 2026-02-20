using System.Xml.Linq;

namespace Konu12Kalitimİnheritance
{
    class Arac
    {
        public int Id { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public string AracTuru;
        public void KornaCal()
        {
            Console.WriteLine("Kornaya Basıldı!");
        }
    }
    class Otomobil :Arac // iki nokta üst üste araç dediğimizde araç sınfındaki içerikler otomobil sınıfında kullanılabilir.
    {
        public string Marka { get; set; }
        public string Model  { get; set; }
    }
    class Test: Otomobil
    {
        public int MyProperty { get; set; }
    }
    class Tren : Arac
    {
        public int KoltukSayisi { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Konu12Kalitimİnheritance");
            Arac arac = new Arac();
            arac.AracTuru = "otomobil";
            arac.KornaCal();

            Otomobil otomobil = new Otomobil();
            otomobil.Id = 1;
            otomobil.AracTuru = "otomobil";  // bu değişken Araç sınıfından gelir 
            otomobil.KornaCal(); //bu metot araç sınıfından geliyor
            otomobil.Marka = "Togg";
            otomobil.Model = "I10x";
            Console.WriteLine("otomobil.AracTuru:"+ otomobil.AracTuru);

            Kategori kategori = new()
            {
                Id = 1,
                Name = "Elektronik",
                UstMenudeGoster = true,
            };
            if (kategori.UstMenudeGoster == true)
            {
                Console.WriteLine("Kategori Adı:" +kategori.Name);

            }
            Console.WriteLine();
            Urun urun = new Urun()
            {
                Id = 1,
                Name = "klavye",
                Fiyat = 999,
                Kdv=20,
            };
            Console.WriteLine("Ürün Bilgileri");
            Console.WriteLine("Ürün Adı:"+urun.Name);
            Console.WriteLine("Ürün Fiyatı:"+urun.Fiyat);
            Console.WriteLine("Kdv:%"+urun.Kdv);
            decimal kdvOrani=0.20m;
            decimal kdvTutari = urun.Fiyat * kdvOrani;
            decimal toplamFiyat = urun.Fiyat + kdvTutari;


            Console.WriteLine("Kdv Tutarı: "+ kdvTutari + "Tl");
            Console.WriteLine("Toplam Tutar: "+ toplamFiyat + "Tl");

            Console.WriteLine();

            
        }
    }
    //polimorfizm-çok biçimlilik
}
