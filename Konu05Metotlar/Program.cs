namespace Konu05Metotlar
{
    internal class Program
    {
        // GERİYE DEĞER DÖNDÜRMEYEN METOT
        static void ToplamaYap()
        {
            Console.WriteLine(10 + 8);
        }

        // 2 PARAMETRELİ METOT
        static void ToplamaYap(int sayi1, int sayi2)
        {
            Console.WriteLine(sayi1 + sayi2);
        }

        // GERİYE DEĞER DÖNDÜREN METOT
        static int ToplamaYap(int sayi1, int sayi2, int sayi3)    //parametreli metot tanımlama
        {
            return sayi1 + sayi2 + sayi3;
        }

        // BOOL DÖNDÜREN METOT
        static bool MailGonder(string mailAdresi)
        {
            if (!string.IsNullOrEmpty(mailAdresi))
            {
                return true;
            }
            return false;
        }

        static void Main(string[] args)
        {
            ToplamaYap();

            Console.WriteLine("Konu05 Metotlar!");
            Console.WriteLine();

            ToplamaYap(10, 8);
            Console.WriteLine();

            Console.WriteLine("Geriye deger döndüren metot:");
            int sonuc = ToplamaYap(6, 6, 6);
            Console.WriteLine("Sayilarin toplami: " + sonuc);
            Console.WriteLine();

            Console.WriteLine("Email giriniz:");
            var email = Console.ReadLine();

            bool mailGonderildimi = MailGonder(email);

            if (mailGonderildimi)
            {
                Console.WriteLine("mail başarıyla gönderildi");
            }
            else
            {
                Console.WriteLine("mail gönderilmedi");
            }
        }
    }
}
