using System;
using System.Collections.Generic;
using System.Text;

namespace Konu08SiniflarClasses
{
    internal class User
    {
        //  classlarda property kullanımı
        //property ler değişken ve metotların karışımı  gibi çalışırlar
        //değişken gibi değer taşımak içinde  metoto gibi kullana bilirler
        //property oluşturmak için prop yazıp tab tuşuna basarak kısayol kullana biliriz.

        public int Id { get; set; }  //prop +tab
        public string Name { get; set; }   // User classından oluşturduğumuz nesne üzerinden burdaki property lere değer ataması yaparsak set bloğu , değer okuması yaparsak get bloğu çalışır
        public string Password { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Username { get; set; }
        public DateTime CreateDate { get; set; }
        public bool KullaniciGiris (string kullaniciAdi, string sifre)
        {
            if (kullaniciAdi == "admin" && sifre == "adm123")
            {
                return true;
            }
            return false;
        }
    }
}
