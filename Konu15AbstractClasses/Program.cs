namespace Konu15AbstractClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Konu15AbstractClasses");
        }
    }
    abstract class Database // class ın önüne abstract yazarak yapıyı oluşturuyoruz 
    {
        void Add()
        {
            Console.WriteLine("ekleme metodu çalıştı.");
        }
        internal abstract void Delete();   //silme metot imzası 
        internal abstract void Update();    // güncelleme metot imzası 
        internal abstract void Get();   // veri getirme metot imzası 
    }
    class SqlServer : Database
    {
        internal override void Delete()
        {
            Console.WriteLine(" SqlServer Delete metodu çalıştı.");
        }

        internal override void Get()
        {
            Console.WriteLine("SqlServer Get metodu çalıştı.");
        }

        internal override void Update()
        {
            Console.WriteLine("SqlServer Update metodu çalıştı.");
        }
    }
    class Oracle : Database
    {
        internal override void Delete()
        {
            Console.WriteLine(" Oracle Delete metodu çalıştı.");
        }

        internal override void Get()
        {
            Console.WriteLine("Oracle  Get metodu çalıştı.");
        }

        internal override void Update()
        {
            Console.WriteLine("Oracle Update metodu çalıştı.");   // 40 dk
        }
    }
}
