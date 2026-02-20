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
            
        }
    }
}
