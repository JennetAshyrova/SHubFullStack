namespace Konu11Enumlar
{
    internal class Program
    {
        //Enum(numaratör) lar nesneleri numaralandırmak için kullanılır
        /*
        * enum tipler üzerindeki kısıtlar
        *1-enum blokunda metot tanımlanamaz
        *2-arayüz(interface )  kullanamazlar
        *3-enum bloğunda property kullanılmaz
          */
        enum Aylar : byte
        {
            Ocak = 1, şubat, mart, nisan, mayıs, haziran, temmuz, ağustos, eylül, kasım, aralık
        }
        static void Main(string[] args)
        {
            Console.WriteLine(" Konu11Enumlar");
        }
    }
}
