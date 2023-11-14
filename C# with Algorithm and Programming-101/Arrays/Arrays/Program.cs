using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* String Türünde Dizi Örnekleri
             string[] sehirler = { "İstanbul", "Adana", "Bursa", "İzmir", "Ankara" };
             Console.WriteLine("Dizimizin 2. Index Değeri: " + sehirler[2]);
             Console.WriteLine(sehirler[1]);
             Console.WriteLine(sehirler[5]);
            */

            /* Int Türünde Dizi Örnekleri
            int[] sayilar = { 10, 20, 30, 40, 50, 60, 70, 80 };
            Console.WriteLine(sayilar[4]);             // Bu sadece istenilen indeksi yazmaya yarıyor.
            Console.WriteLine();

            for (int i = 0; i < 8; i += 1)             // Bu döngü sayesinde ise tüm indeksleri ekrana yazdırmış olduk.
            { 
                Console.WriteLine(sayilar[i]);
            }
            */

            /* Dizilerle Birlikte Karar Yapısı Kullanımı 
            int [] sayilar = {10, 20, 30, 40, 50, 60, 70, 80, 90 }; 
            for (int i = 0; i < sayilar.Length; i+= 1)
            {
                if (sayilar[i] % 20 == 0 || sayilar[i] %30 == 0)
                {
                    Console.WriteLine(sayilar[i]);
                }
            }
            */

            /*
            int[] sayilar = {10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
            int toplam = 0;
            for (int i = 0; i < sayilar.Length; i += 1)
            {
                toplam += sayilar[i];

                Console.WriteLine(toplam);
            }
            */

            /* Dizi Metodları
             * Sort Metodu:
            
            int[] sayilar = { 20, 14, 12, 35, 17 };
            Array.Sort(sayilar);
            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine(sayilar[i]);
            }
            */

            /* Reverse Metodu ile Sort birlikte kullanılırsa Z'den A'ya alfabetik olarak sıralamış oluruz. Aşağıdaki örnekteki gibi....
            string[] sehirler = { "Adana", "Ankara", "Zonguldak", "İstanbul", "Malatya", "Erzurum", "Bursa" };
            Array.Sort(sehirler);              
            Array.Reverse(sehirler);
            for (int i = 0; i < sehirler.Length; i++)
            {
                Console.WriteLine(sehirler[i]);
            }
            */

            /* IndexOf Metodu
             * IndexOf Metodu ile Sortu beraber kullandık. Yani önce alfabetik olarak sıraladık daha sonra istediğimiz değeri çektik.
            string[] kisiler = { "Buse", "Ali", "Hakan", "Murat", "Eylül" };
            int sira;
            Array.Sort(kisiler);
            sira = Array.IndexOf(kisiler, "Murat");
            Console.Write(sira);
            */

            // Min-Max Metotları: 
            int[] sayilar = { 76, 43, 12, 56, 2, 34 };
            Console.WriteLine("Bu dizideki en küçük sayı: " + sayilar.Min());
            Console.Write("Bu dizideki en büyük sayı: " + sayilar.Max());

            Console.Read();
        }
    }
}
