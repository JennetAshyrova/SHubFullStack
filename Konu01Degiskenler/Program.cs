// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine();
Console.WriteLine("Merhaba Dunya!");
Console.Write("Console");
Console.Write("Write");
Console.WriteLine("Selam");
Console.WriteLine("Merhaba");
//Console.Read();   //enter tuşuna basılmasını bekler 1 karakter için
//Console.Readline(); //enter tuşuna basılmasını bekler tüm satır için 
//değişkenler
//tam sayı veri tipleri
byte plaka_kodu;  // 0-255 arası değer alır 1 byte kaplar
plaka_kodu = 34; //değişkene değer atama
Console.WriteLine(plaka_kodu);  //değişkenin değerini ekrana yazdırma

//değişkenler tiplerine göre bellekte stack ve heap denilen 2 ayrı bölümde saklanır. Değer  
//tipli değişkenler stack alanında saklanırkn referans tipli değişkenler heap bölümünde saklanır
//GC-çöp toplayıcı sistemi

byte birSayi, birSayiDaha; //bir tiple birden fazla değişken oluşturma 
birSayi = 0;
birSayiDaha = 255;
Console.WriteLine(birSayi);
Console.WriteLine(birSayiDaha);

sbyte sbyteTuru = 127;   // +127 ile -128 arası değer alabilir
short kisa = 32767;      // +32767 ile -32768 arası değer alabilir
ushort birazUzun = 65535; //0 -65535
int tamsayi = 1234567898; //32bit 4 byte
uint uzuntamsayi = 4294967295; // 0-4294967295
long dahauzuntamsayi = 12345678980000;
ulong enuzuntamsayi = 12345678900000000000;


//kesirli sayı değişken tipleri
float kesirliSayi = 4.5f;   //4byte yer kaplar 6-7 basamak
double kesirlisayi = 4.5;   //8byte yer kaplar 15-16 basamak
//Decimal veri tipi
decimal UrunFiyati = 9999;   //12 byte, duyarlı basamak 28-29

//Char veri tipi
char karakter = 'a';  //klavyeden girilen he bir karakter için kullanılabilir sadece 1 tane değer alabilir

//string veri tipler
string degisken;  //klavyeden girilen karakterlerden oluşan yapı
string degisken1, degisken2;
string metin = "string veri tipinde tüm karakterleri kullana biliyoruz.";
Console.WriteLine(metin);

//Boolean veri Tipi
bool islemSonuc = false; // geriye true ve ya false dönen veri tipidir, 1byte lik yer kaplar işlem başarılıysa
islemSonuc = true;

byte? kilo = null; //eğer bir değişkene başlangıç değeri olarak null vermek istersek veri tipinin yanınaa ? koyarız
kilo = 66;
//bir ürünün satışta olup olmadığını bilğisini tutacak değişken
bool? isSatistami = null;
//ürün satıştıysa eğer
isSatistami = true; //true ayarla




//var ile değişken oluşturma
var birdegisken = "18";  //var ile oluşturulan değişkenin veri tipi c# tarafından değişkene atanan değere göre otomatik algılanır
var birsayi = 18;
var strmetin = "var kullanırsak değişkene değer atamak zorundayız!";
var sonuc = false;

Console.WriteLine(birdegisken);
Console.WriteLine(birdegisken.GetType());    //ctrl+d kodu kopyalar
Console.WriteLine(birsayi);
Console.WriteLine(birsayi.GetType());
Console.WriteLine(strmetin);
Console.WriteLine(strmetin.GetType());      //system kütüphane demek
Console.WriteLine(sonuc);
Console.WriteLine(sonuc.GetType());     // get.type değişkenin değerinin hanği türde olduğunu söyler

sonuc = true;
//sonuc=1;// var ile tanımlanan bir değişkenin türü sonradan değiştirilemez,ama içindeki değer değiştirelibilir.
Console.WriteLine();
Console.WriteLine("object veri tipi");
object nesne = "bu bir nesnedir";   //bu değişken türüne her türden nesne atanabilir
Console.WriteLine(nesne);
Console.WriteLine(nesne.GetType());
nesne = 18;  //object ile tanımlanan nesne değiştirilebilir
Console.WriteLine(nesne);
Console.WriteLine(nesne.GetType());
Console.WriteLine();


object a = 10; // tam sayi
Console.WriteLine(a.GetType());
Console.WriteLine();
object b = 'k'; //karakter
Console.WriteLine(b.GetType());
Console.WriteLine();
object c = "metin "; // string
Console.WriteLine(c.GetType());
Console.WriteLine();
object d = 12.9f; //float
Console.WriteLine(d.GetType());

Console.WriteLine();

//c# ta sabitt tanıımlama 
Console.WriteLine("C# sabit tanımlama");
const int kdvOrani = 18; //sabitleri const olarak tanımlayıp program içerisinde kullanabiliriz,
                         //sabitleri değeri tanımlandıığıı yerde verilir sonradan değişmez

Console.WriteLine("kdv Orani:");
Console.WriteLine(kdvOrani);


//ekrandan değer alma
Console.WriteLine("Ekrandan değer alma");
var deger = Console.ReadLine();
Console.WriteLine("Girdiğiniz değer:");
Console.WriteLine(deger);
 
//değişken ve veri tipleri bitti