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
            Bolum bolum = new Bolum();
            Console.WriteLine("hanği alanda eğitim almak istersiniz");
            var bolumAdi = Console.ReadLine();
            bolum.SetBolumAdi(bolumAdi);
            Console.WriteLine("bölüm:"+ bolum.GetBolumAdi());
        }
    }
}
