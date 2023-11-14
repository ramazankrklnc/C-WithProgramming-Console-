using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Classs_and_Object_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Araba Sınıfı
            /*
            Car arbam = new Car();        // Sınıftan nesne türettik.
            arbam.marka = "Tesla";
            arbam.model = "2021";
            arbam.renk = "Kırmızı";
            arbam.hiz = 270;
            arbam.motor = 1.6;

            Console.WriteLine("*****Araba Tanıtım Kartı*****");
            Console.WriteLine();
            Console.WriteLine("Marka: " + arbam.marka);
            Console.WriteLine("Model: " + arbam.model);
            Console.WriteLine("Renk: " + arbam.renk);
            Console.WriteLine("Hız: " + arbam.hiz);
            Console.WriteLine("Motor Gücü: " + arbam.motor);
            Console.WriteLine();
            Console.WriteLine();
            
            //---------------------------------------------------------------------------------------------------------------

            // Müşteri Sınıfı
            Customer m = new Customer();

            m.Id = 1;
            m.Name = "Murat";
            m.Surname = "Yücedağ";
            m.City = "İstanbul";


            Console.Write("***** Müşteri Bilgisi ******");
            Console.WriteLine();
            Console.WriteLine(m.Id + "-" + "Ad Soyad: " + m.Name + " " + m.Surname);
            Console.WriteLine("Şehir: " + m.city);
            Console.WriteLine();

            m.Id = 2;
            m.Name = "Ramazan";
            m.Surname = "Karakılınç";
            m.City = "İstanbul";


            Console.WriteLine();
            Console.WriteLine(m.Id + "-" + "Ad Soyad: " + m.Name + " " + m.Surname);
            Console.WriteLine("Şehir: " + m.city);
            */

            // Sınıf İçindeki Niteliklere Klavyeden Değer Girişi

            Customer m = new Customer();

            Console.Write("ID Değerini Giriniz: ");
            m.Id = Convert.ToInt16(Console.ReadLine());
            Console.Write("Adınız: ");
            m.Name = Console.ReadLine();
            Console.Write("Soyadınız: ");
            m.Surname = Console.ReadLine();
            Console.Write("Şehriniz: ");
            m.city = Console.ReadLine();

            Console.WriteLine("***** Müşteri Kimlik Kartı *****");
            Console.WriteLine();
            Console.WriteLine(m.Id + "-" + m.Name + " " + m.Surname + " " + m.city );



            Console.Read();
        }
    }
}
