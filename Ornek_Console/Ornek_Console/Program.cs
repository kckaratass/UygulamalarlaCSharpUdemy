using System;

namespace Ornek_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kisiler kisiler = new Kisiler();
            //string ads;
            //Console.Write("İsim Giriniz: ");
            //ads = Console.ReadLine();
            //kisiler.kisiListesi(ads);
            //Console.Read();

            //Ogrenci ogrenci = new Ogrenci("Kadir Can - Bilgisayar Mühendisi");
            //string bilgi;
            //Console.Write("Ad - Bölüm Giriniz: ");
            //bilgi = Console.ReadLine();
            //Ogrenci ogrenci = new Ogrenci(bilgi);

            //Ogrenci student = new Ogrenci("Kadir Can", "Karataş", 22, "Öğrenci");

            Kimlik kml = new Kimlik();
            kml.AD = "Kadir Can";
            kml.SOYAD = "Karataş";
            Console.WriteLine("Ad: " + kml.AD);
            Console.WriteLine("Soyad: " + kml.SOYAD);
            Console.WriteLine("Memleket: " + kml.MEMLEKET);
            Console.WriteLine("Yaş: " + kml.YAS);
            Console.WriteLine("Cinsiyet: " + kml.CINSIYET);
            Console.Read();
        }
    }
}
