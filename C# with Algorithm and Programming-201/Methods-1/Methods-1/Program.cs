using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_1
{
    internal class Program
    {
        // Void Metotlar(Geriye Değer Döndürmeyen Metot Örnekleri)
        public static void yazdir()
        {
            Console.Write("Bu bir metottur.");
            Console.WriteLine();
            Console.Write("Burası metodun bir başka satırıdır.");
            Console.WriteLine();
        }

        public static void toplamametodu()
        {
            int sayi1 = 24, sayi2 = 30;
            int toplam = sayi1 + sayi2;
            Console.WriteLine(toplam);
        }

        public static void boslukyazdir()
        {
            Console.WriteLine();
            Console.WriteLine("***********************");
            Console.WriteLine();
        }
        public static void ardisikSayilar()
        {
            for (int i = 0; i <= 10; i += 1)
            {
                Console.Write(i + " ");
            }
        }

        static void Main(string[] args)
        {
            yazdir();
            // Console.Write("***********************************");
            // Console.WriteLine();
            boslukyazdir();
            yazdir();
            boslukyazdir();
            toplamametodu();
            boslukyazdir();
            ardisikSayilar();
            Console.Read();
        }
    }
}
