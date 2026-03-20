namespace Konu18SOLIDPrensipleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Konu18 SOLID Prensipleri");
            Console.WriteLine("Robert Cecil Martin tarafından öne sürülen geliştirilecek yazılımın esnek,yeniden kullanılabilir, sürdürülebilir ve anlaşılır olmasını hedefleyen, kod tekrarını önleyen prensipler bütünüdür");
            Console.WriteLine();
            Console.WriteLine("s-Single Responsibility(tek sorumluluk prensibi)");
            Console.WriteLine("\t 1 sınıf ve ya metodun sadece 1 sorumluluğunun olması gerekir!");
            Console.WriteLine();
            Console.WriteLine("0-open closed principle");
            Console.WriteLine("\t bir sınıf ve ya metot var olan özelliklerini korumalı değişikliğe izin vermemelidir");
            Console.WriteLine();
            Console.WriteLine("L-Liskov Substitution ");
            Console.WriteLine("Kodlarımızda herhanği bir değişiklik yapmaya gerek duymadan alt sınıflar türedikleri üst sınıfların yerine kullanabilmeliyiz");
            Console.WriteLine();
            Console.WriteLine("I-İnterface segregation");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("D-Dependency Inversion");
            Console.WriteLine("Sınıflar arası bağımlılıklar olabildiğince az olmalıdır. özellikle üst seviye sınıflar alt seviye sınıflara bağımlı olmaldır ");

        }
    }
}
