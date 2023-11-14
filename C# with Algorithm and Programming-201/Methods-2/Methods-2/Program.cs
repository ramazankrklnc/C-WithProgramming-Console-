using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_2
{
    internal class Program
    {
        // Void Metotlarda(Geri Değer Döndürmeyen Metolarda) Parametre Kullanımı
        public static void MetinYaz(string parametre)
        {
            Console.Write("**********");
            Console.WriteLine();
            Console.Write(parametre);
            Console.WriteLine();
            Console.Write("**********");
            Console.WriteLine();
        }

        public static void KlavyeGirisi(string parametre)
        {
            Console.Write("----------");
            Console.WriteLine();
            Console.Write(parametre);
            Console.WriteLine();
            Console.Write("----------");
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Console.Write("Ekrana Kelime Giriniz: ");
            string kelime = Console.ReadLine();
            KlavyeGirisi(kelime);

            MetinYaz("Merhaba");


            Console.Read();
        }
    }
}
