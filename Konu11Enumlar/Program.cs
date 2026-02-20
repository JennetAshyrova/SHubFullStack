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
        enum SiparisDurumu
        {
            Hazırlanıyor,Hazırlandı,Kargobekleniyor,Kargolandı,İadeEdildi
        }
        enum Meyveler
        {
            Elma=3, Armut=7,Çilek=1   
        }
        static void Main(string[] args)
        {
            Console.WriteLine(" Konu11Enumlar");
            byte a = (byte)Meyveler.Armut;
            byte b = (byte)Meyveler.Elma;
            byte c = (byte)Meyveler.Çilek;
            Console.WriteLine($"{Meyveler.Armut}={a},{Meyveler.Elma}={b}, {Meyveler.Çilek}={c}");
            Ornek(SiparisDurum: 1);
            Ornek(3);
        }
        static void Ornek(int SiparisDurum)
        {
            if (SiparisDurum == (int)SiparisDurumu.Hazırlanıyor)
            {
                Console.WriteLine("siparişiniz hazırlanıyor");
            }
            if (SiparisDurum == (int)SiparisDurumu.Hazırlandı)
            {
                Console.WriteLine("siparişiniz hazırlandı");
            }
            if (SiparisDurum == (int)SiparisDurumu.Kargobekleniyor)
            {
                Console.WriteLine("Siparişiniz hazırlandı Kargobekleniyor");
            }
            if (SiparisDurum == (int)SiparisDurumu.Kargolandı)
            {
                Console.WriteLine("Siparişiniz Kargoya verildi");
            }
            if (SiparisDurum == (int)SiparisDurumu.İadeEdildi)
            {
                Console.WriteLine("Siparişiniz İade Edildi");
            }
               
        }
    }
}
