using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foreach_Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Foreach Döngüsü:

            //int[] sayilar = { 23, 55, 32, 15, 89, 70 };
            //int toplam = 0;
            //foreach (int sonuc in sayilar) 
            //{ 
            //    toplam = toplam + sonuc;
            //    Console.WriteLine(toplam);
            //}


            // Çift Olan sayıları Sıralı bir şekilde ekrana yazdırma:

            //int[] sayilar = { 34, 22, 11, 67, 89, 50, 48 };
            //Array.Sort(sayilar);
            //foreach (int sayi in sayilar) 
            //{ 
            //    if (sayi %2 == 0) 
            //    {
            //        Console.WriteLine(sayi);
            //    }
            //}

            // Diziye Dışarıdan eleman girme:

            string[] sehirler = new string[5];
            for (int i = 0; i < 5; i += 1)
            {
                Console.Write("Şehir İsmi Giriniz: ");
                sehirler[i] = Console.ReadLine();
            }

            Console.WriteLine();
            Console.WriteLine("Girilen Şehir İsimleri:");
            Console.WriteLine();

            for (int j = 0; j < 5; j += 1)
            {
                Console.WriteLine(sehirler[j]);
            }



            Console.Read();
        }
    }
}
