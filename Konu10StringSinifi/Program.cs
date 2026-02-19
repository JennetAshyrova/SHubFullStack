namespace Konu10StringSinifi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Konu10StringSinifi");
            string degisken;
            char karakter = 'a';
            string metinlericin = "yanyan karakterlerden oluşan metot";
            //Ornek1();
            StringMetotlari();
            SplitMetodu();
        }
        static void Ornek1()
        {
            string birMetin = "Ankara başkenttir";
            string birdsayi = "123456789";
            System.String birTarih = "21.012026";
            string kod = "//5456dfgd\n"; // buradaki \n kodu enter görevi görür ve kendinden sonra gelecek olan metni bir alt satıra kaydırır
            Console.WriteLine(birMetin.GetType());
            Console.WriteLine(birdsayi.GetType());
            Console.WriteLine(birTarih.GetType());
            Console.WriteLine(kod);
            string s = "Jennet Ashyrova";
            Console.WriteLine(s);
            Console.WriteLine("For döngüsü");
            for (int i = 0; i < s.Length; i++)   // s değişkeninin uzunluğu kadar dön
            {
                Console.WriteLine(s[i]);  //s değişkeninin i.indexindeki değeri yazdır
            }
            Console.WriteLine("Foreach döngüsü");
            Console.WriteLine();
            foreach (var item in s)
            {
                Console.WriteLine(item);
            }


            //34:58 kaldım
        }
        static void StringMetotlari()
        {
            string metin = "stringin birçok metodu vardır ";
            Console.WriteLine(metin);
            Console.WriteLine("metin in karakter sayisi metin.Length: "+ metin.Length);
            Console.WriteLine();

            var klon = metin.Clone();  // clone metodu metin değişkeninin klonlayıp klon değişkenine atar
            Console.WriteLine("metin klonu :" + klon);
            Console.WriteLine();
            metin = "My name is Jennet";
            Console.WriteLine(metin + "EndsWith i:" + metin.EndsWith("t"));
            Console.WriteLine(metin + "EndsWith r:" + metin.EndsWith("r"));
            Console.WriteLine();
            Console.WriteLine(metin + "StartsWith S: " + metin.StartsWith("S"));
            Console.WriteLine(metin + "StartsWith m: " + metin.StartsWith("m"));
            Console.WriteLine(metin + "StartsWith M: " + metin.StartsWith("M"));
            Console.WriteLine();
            Console.WriteLine(metin + "Indexof name: " + metin.IndexOf("name"));
            Console.WriteLine(metin + "Indexof Name: " + metin.IndexOf("Name"));
            Console.WriteLine(metin + "LastIndexof t: " + metin.LastIndexOf("t"));
            Console.WriteLine();
            Console.WriteLine(metin + "Insert Merhaba: " + metin.Insert(0,"Merhaba:"));
            Console.WriteLine(metin);
            Console.WriteLine("Substring 2:"+metin.Substring(2));
            Console.WriteLine("Substring 2,5:"+metin.Substring(2,5));   //2.indexten başlayarak 5 karakter 
            Console.WriteLine();
            Console.WriteLine("metin.ToLower:" + metin.ToLower()); //metni küçük harfe çevir
            Console.WriteLine("metin.Upper:" + metin.ToUpper()); //metni büyük harfe çevir
            Console.WriteLine("metin.ToLower Replace:" + metin.ToLower().Replace(" ","-")) ; //metni küçük harfe çevir ve içindeki boşlukları  - ile değiştir
            Console.WriteLine("metin.Remove 2:" + metin.Remove(2));
            Console.WriteLine("metin.Remove 2,5:" + metin.Remove(2,5));

        }
        static void SplitMetodu()
        {
            string sehirler = "istanbul,ankara,izmir,sivas,çankırı";
            Console.WriteLine(sehirler);
            string[] sehirlerArray = sehirler.Split(',');  //splt
            Console.WriteLine("4.şehir: " + sehirlerArray[3]);
            foreach(var item in sehirlerArray)
            {
                Console.WriteLine("şehir: "+item);
            }
        }
    }
}
