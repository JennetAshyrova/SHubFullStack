namespace Konu04KararYapilari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Konu04 Karar Yapilari");
            /*

            Console.WriteLine("Bir Sayi Giriniz:");
            var sayi = Convert.ToDecimal(Console.ReadLine());
            if (sayi > 0)  //eğer girilen sayi 0 dan büyük ise
            {
                Console.WriteLine("Sayi Pozitif");
            }
            else if (sayi < 0) // yukardaki şart değilse eğer 
            {
                Console.WriteLine("Sayi Negatif");
            }
            else
            {
                Console.WriteLine("Sayi sıfır");
            }
           
            Console.WriteLine("kullancı adınız:");
            var kullaniciAdi = Console.ReadLine();
            Console.WriteLine();
            var sifre = Console.ReadLine();
            if (kullaniciAdi== "admin" & sifre == "a123")
                    {
                Console.WriteLine("Giriş Başarılı");
                Console.WriteLine("Hoşgeldin Admin");

            }
            else
            {
                Console.WriteLine("Giriş Başarısız");
            }
             */
            int saat = DateTime.Now.Hour;
            if (saat < 18)
            {
                Console.WriteLine("iyi günler saat: " + saat);
            }
            else
            {
                Console.WriteLine("iyi akşamlar, saat:" + saat);
                Console.WriteLine();

                Console.WriteLine("switch sace yapısı ile akış kontrolü");
                int ay = DateTime.Now.Month;
                Console.WriteLine("Bulunduğumuz ay:" + ay);
                switch (ay)
                {
                    case 12:
                    case 1:
                    case 2:
                        Console.WriteLine("kış");
                        break;
                    case 3:
                    case 4:
                    case 5:
                        Console.WriteLine("ilkbahar");
                        break;
                    case 6:
                    case 7:
                    case 8:
                        Console.WriteLine("yaz");
                        break;
                    case 9:
                    case 10:
                    case 11:
                   
                        Console.WriteLine("sonbahar");
                        break;
                     default:
                        Console.WriteLine("bir sorun oluştu");
                        break;
                }
            }

        }
    }
}
