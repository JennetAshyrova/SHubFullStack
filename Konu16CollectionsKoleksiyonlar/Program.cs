using System.Collections;    // koleksiyonları kullana bilmek için gerekli kütüphane
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Channels;
namespace Konu16CollectionsKoleksiyonlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Konu16CollectionsKoleksiyonlar");
            //Ornek1();
            //Ornek2();
            Ornek3();
        }
        static void Ornek1()
        {
            ArrayList arrayList = new();
            arrayList.Add(1);
            arrayList.Add("iki");
            arrayList.Add(3.0);
            arrayList.Add(true);
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine("ArrayList ilk eleman :" + arrayList[0]); // listede indexini verdiğimiz elemana ulaşma
            Console.WriteLine();

        }
        
        static void Ornek2()
        {
            ArrayList arrayList = new();
            arrayList.Add("İstanbul");
            arrayList.Add("Ankara");
            arrayList.Add("İzmir");
            arrayList.Add("Sivas");
            arrayList.Add("Çankırı");
            arrayList.Add("Zonguldak");
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine("ArrayList sıralama yapabiliriz");
            arrayList.Sort(); // a-z sıralama 
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            arrayList.Reverse();  // tersten sırala 
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

        }
        public static void Ornek3()
        {
            var strings = new StringCollection();
            strings.Add("istanbul");
            strings.Add("ankara");
            strings.Add("bursa");
            // strings.Add(34); //StringCollection a sadece string veriler eklene bilir.
            Console.WriteLine("StringCollection");
            foreach ( var item in strings)
            {
                Console.WriteLine(item);
            }
            

        }
    }
}
