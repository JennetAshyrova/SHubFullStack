using System.Threading.Channels;

namespace Konu13KapsullemeEncapsulation
{
    internal class Bolum
    {
        private string BolumAdi;    // dişarıdan erişime kapalı değişkenimiz 
        public string GetBolumAdi()   // dişariye string veri gönderen metot 
        {
            return BolumAdi;   // GetBolumAdi çağrılınca BolumAdi değişken değerini yolla 
        }
        public void SetBolumAdi(string İstenenEgitim)
        {
            if (İstenenEgitim=="yazılım eğitimi")
            {
                BolumAdi = İstenenEgitim;  //Mutator(setter) seçilen eğitime izin verildi.
            }
            else
            {
                Console.WriteLine("kurumumuzda bu eğitim verilmemektedir"); ;   
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Konu13 Kapsulleme Encapsulation");
            Console.WriteLine("metot ile kapsulleme");
            Bolum bolum = new Bolum();  //bölüm  classından bölüm adında bir nesne üret
            Console.WriteLine("hanği alanda eğitim almak istersiniz");  
            var bolumAdi = Console.ReadLine();   // ekrandan girilecek değeri oku 
            bolum.SetBolumAdi(bolumAdi);   //girilen değeri bölüm nesnelerindeki set metoduna gönder 
            Console.WriteLine("bölüm:"+ bolum.GetBolumAdi());  //bölüm nesnesindeki metotla private değişkenin değerini oku
            Console.WriteLine();
            // property ile kapsülleme
            Console.WriteLine(  "property ile kapsülleme");
            Fakulte fakulteNesnesi = new Fakulte();  //burada nesneyi oluşturuyoruz
            fakulteNesnesi.Bolum = bolumAdi; // veri atama : set bloğunu çalıştırır.
            Console.WriteLine("Fakülte bölüm:"+fakulteNesnesi.Bolum); // veri okuma : get bloğğunu çalıştırır
        } 

    }
    public class Fakulte
    {
        private string bolum;
        public string Bolum
        {
            get { return bolum; }
            set
            {
                if (value=="yazılım eğitimi")  // eğer gönderilen değer yazılım eğitim ise 
                {
                    bolum = value;  // property e değer atamasına izin ver 
                }
                else
                {
                    Console.WriteLine("kurumumuzda bu eğitim verilmemektedir");
                }
                
            }
        }
    }
}
