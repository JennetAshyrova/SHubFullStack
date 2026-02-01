namespace Konu08SiniflarClasses
{
    internal class Ev   //sınıf tanımlama
    {
        internal string sokakAdi;
        internal int kapiNo;
    }

    /*
     erişim belirticileri 4 ana sınıfa ayrılır
    pubblic: erişim kısıtı yoktur, her yerden erişilebilir
    protected: ait olduğu sınıftan ve o sınıftan türetilen sınıflardan erişilebilir
    internal: etkin projeye ait sınıflardan erişilebilir, onların dışında erişilemez
    private: yalnız bulunduğu sınıftan erişilebilir, dıştaki sınıflardan erişilemez

     */
    public class deneme
    {
        public string UrunAdi = "public öğeye herkez ulaşabilir";
        protected class test
        {
            string UrunAdi;
        }
    }   
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Konu08SınıflarClasses");
            #region Örnek1
            Ev ilkEv = new Ev(); //soyut bir yapı olan ev sınıftan somut bir nesne oluşturduk
            ilkEv.sokakAdi = "pınar sk";
            ilkEv.kapiNo = 10;
            Console.WriteLine("ilkEv sokakAdi:" + ilkEv.sokakAdi);
            Console.WriteLine("ilkEv kapiNo:" + ilkEv.kapiNo);
            Console.WriteLine();

            Ev yazlikEv = new();
            yazlikEv.sokakAdi = "deniz sk.";
            yazlikEv.kapiNo = 18;
            Console.WriteLine("yazlık ev sokakAdi:" + ilkEv.sokakAdi);
            Console.WriteLine("yazlık ev kapiNo:" + ilkEv.kapiNo);

            Console.WriteLine();

            Ev koyEvi = new()
            {
                kapiNo = 25,
                sokakAdi = "maho ağa sokak"
            };

            Console.WriteLine("koy evi sokakAdi:" + koyEvi.sokakAdi);
            Console.WriteLine("koy evi kapiNo:" + koyEvi.kapiNo);

            Console.WriteLine();
            #endregion
            #region  Örnek 2
            Kullanici kullanici = new()
            {
                Adi="jennet", Soyadi ="ashyrova ", KullaniciAdi="jen", Sifre="j123", Id=1,
            };
            Console.WriteLine("kullanıcı adınız:");
            var kullaniciAdi = Console.ReadLine();
            Console.WriteLine("şifreniz:");
            var sifre = Console.ReadLine();

            if (kullaniciAdi==kullanici.KullaniciAdi && sifre ==kullanici.Sifre)
            {
                Console.WriteLine($"hoşgeldin {kullanici.Adi} {kullanici.Soyadi}");//sisteme giriş yap 
            }
            else
            {
                Console.WriteLine("giriş başarısız");
            }
            #endregion
            #region         örnek3
            Araba araba = new()
            {
                Id = 1,
                Marka = "TOGG",
                KasaTipi="Suv",
                Model="T10X",
                Renk= "kırmızı",
                ModelYili=2025
            };

            Araba araba2 = new()
            {
                Id = 2,
                Marka = "TOGG",
                KasaTipi = "Sedan",
                Model = "T10F",
                Renk = "BEYAZ",
                ModelYili = 2023
            };




            #endregion


            #region örnek4
            Kategori kategori = new()
            {
                Id=3, KategoriAdi="Elektronik"
            };

            Kategori kategori2 = new()
            {
                Id = 4,
                KategoriAdi = "bilgisayar"
            };
            Kategori kategori3 = new()
            {
                Id = 4,
                KategoriAdi = "telefon"
            };
            Console.WriteLine($"Anasayfa Hakkımızda{ kategori.KategoriAdi} {kategori2.KategoriAdi}           {kategori3.KategoriAdi}İletişim");

            #endregion
        }

    }
    class Kullanici
    {
        internal int Id;
        internal string KullaniciAdi;
        internal string Sifre;
        internal string Email;
        internal string Adi;
        internal string Soyadi;
    }
    class Araba
    {
        internal int Id;
        internal string Marka;
        internal string Model;
        internal string KasaTipi;
        internal string YakıtTipi;
        internal string VitesTipi;
        internal string Renk;
        internal int ModelYili;
    }
}