namespace Konu07Donguler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Konu07Donguler");
            Console.WriteLine("1-For Döngüsü");
            for (int i=0; i<5; i++) // i değişkeni oluştur ve o değerini ata; i 5 den küçük olduğu sürece dön;her dönüşte i yi 1 artır i++ ile
            {
                Console.WriteLine("i değişkeninin değeri: {0} , i");
            }
            Console.WriteLine();

            Console.WriteLine( "2-While Döngüsü");
            int j = 0;    //dişarıda bir değişken tanımlıyoruz
            while (j < 5)// j 5ten küçük olduğu sürece dön
            {
                Console.WriteLine("j değikeninin değeri: {0}", j);
                j++;
            }
            Console.WriteLine();
            Console.WriteLine("3-Do While Dönğüsü");

            int toplam = 5;
            do
            {
                Console.WriteLine("toplam ın değeri:" + toplam);  //önce kod çalışır
                toplam++;
            }
            while (toplam < 5);  // sonra şarta bakar
            Console.WriteLine();

            Console.WriteLine("4-Foreach Döngüsü");

            string[] kategoriler = { "elektronik", "bilgisayar", "telefon", "beyaz eşya", "kitap" };
            Console.WriteLine();
            foreach(var item in kategoriler)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine("İç İçe döngü kullanımı");
            string[] urunler = { "ürün 1", "ürün 2", "ürün 3" }; //elimizde örnek ürün listesi var
            foreach(var kategori in kategoriler) // kategoriler isimli dizide dönüyoruz
            {
                Console.WriteLine(kategori);  // kategoriler dizisindeki her kategoriyi burda ekrana yaz
                foreach(string item in urunler) //ekrana kategori adını yazdıktan sonra ürünler isimli dizide dön ve 
                {
                    Console.WriteLine(item); //ve listedeki ürünleri tek tek yazdır

                    Console.WriteLine("iç içe for döngüsü:");

                    for (int i = 0; i < 5; i++)
                    {
                        Console.WriteLine("1.döngüdeki i nin değeri :" + i);
                        for(int k =0; k<3; k++)
                        {
                            Console.WriteLine("2.döngüdeki k nın değeri:" + k);
                        }
                    }
                }
            }
        }
    }
}
