namespace Konu03Operatorler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Konu03Operatorler");
            Console.WriteLine("1-Arifmetik Operatörler");
            double sayi1 = 3;
            double sayi2 = 4;
            double sayi3 = 5;
            Console.WriteLine();
            Console.WriteLine($"Sayılar sayi:{sayi1} sayi2: {sayi2} sayi3:{sayi3}");  //string tırnğının önüne
                                                                                      //$ işareti koyarsak
                                                                                      //string interpolasyonu yapıyoruz

            Console.WriteLine("1234" + sayi3); //  string ile int arasına + işelmi yapıldığında toplama yerine
                                               //  birleştirme işlemi yapılır

            Console.WriteLine();
            Console.WriteLine("Hesaplama İşlemleri:");
            Console.WriteLine("sayi1+= sayi2 :" + (sayi1 + sayi2));
            Console.WriteLine("sayi1-=sayi2 :" + (sayi1 - sayi2));
            Console.WriteLine("sayi1*= sayi2 :" + (sayi1 * sayi2));
            Console.WriteLine("sayi1/= sayi2 :" + (sayi1 / sayi2));
            Console.WriteLine("sayi1%= sayi2 :" + (sayi1 % sayi2));
            Console.WriteLine();

            Console.WriteLine("Artırım ve Azaltımm Operatörleri");
            sayi2++; //değişkenin değerini artır
            Console.WriteLine("sayi2:" + sayi2);
            sayi2--; //değeri azalt;
            Console.WriteLine("sayi2:" + sayi2);
            Console.WriteLine();
            Console.WriteLine("Atama Operatörleri");
            Console.WriteLine($"Sayılar sayi:{sayi1} sayi2: {sayi2} sayi3:{sayi3}");
            Console.WriteLine("sayi1+ sayi2 :" + (sayi1 += sayi2));
            Console.WriteLine("sayi1- sayi2 :" + (sayi1 -= sayi2));
            Console.WriteLine("sayi1* sayi2 :" + (sayi1 *= sayi2));
            Console.WriteLine("sayi1/ sayi2 :" + (sayi1 /= sayi2));
            Console.WriteLine("sayi1% sayi2 :" + (sayi1 %= sayi2));
            Console.WriteLine();

            Console.WriteLine("İlişkisel Operatörler"); // birden fazla değeri karşılaştırıp aralarındaki
                                                        // durumu öğrenmek için kullanırız

            Console.WriteLine($"Sayılar sayi:{sayi1} sayi2: {sayi2} sayi3:{sayi3}");
            Console.WriteLine("sayi1== sayi2 :" + (sayi1 == sayi2));
            Console.WriteLine("sayi1!= sayi2 :" + (sayi1 != sayi2));
            Console.WriteLine("sayi1> sayi2 :" + (sayi1 > sayi2));
            Console.WriteLine("sayi1< sayi2 :" + (sayi1 < sayi2));
            Console.WriteLine("sayi1<= sayi2 :" + (sayi1 <= sayi2));
            Console.WriteLine("sayi1>= sayi2 :" + (sayi1 >= sayi2));

            Console.WriteLine();
            Console.WriteLine("Ternary Operatörü"); // eğer karşıılaştırma için 2 değer kullanıcaksak
                                                    // karşılaştırmanın kısatyolu olarak kullanırız

            Console.WriteLine("Ternary:");
            Console.WriteLine((sayi1==sayi2)? "sayilar eşit": "Sayilar eşit değil");



            Console.WriteLine("Mantiksal Operatörler");
            Console.WriteLine("And & Operatörü");
            Console.WriteLine("& operaatörü her iki şartında sağlanmasını ister");
            //Console.WriteLine((sayi1 < sayi2) && (sayi1 == sayi2) ? "sayilar eşit" : "Sayilar eşit değil");
            Console.WriteLine();
            string email = "admin@site.co", sifre = "adm123";
            Console.WriteLine("Email giriniz:");
            var girilenMail = Console.ReadLine();
            Console.WriteLine("şifre giriniz:");
            var girilenSifre = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine(girilenMail == email && girilenSifre == sifre ? "giriş başarılı" 
                : "giriş başarısız");
            Console.WriteLine();

            Console.WriteLine("veya | operatörü");
            Console.WriteLine("| operatörü her iki şarttan birinin sağlnamasını ister");
            Console.WriteLine();
            Console.WriteLine(girilenMail == email && girilenSifre == sifre ? "giriş başarılı"
                : "giriş başarısız");

        }
    }
}
