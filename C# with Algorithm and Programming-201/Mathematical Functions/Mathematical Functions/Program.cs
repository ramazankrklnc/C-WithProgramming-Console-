using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathematical_Functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sayi1;
            double sayi2;
            Console.Write("Birinci Sayıyı Giriniz: ");
            sayi1 = double.Parse(Console.ReadLine());
            Console.Write("İkinci Sayıyı Giriniz: ");
            sayi2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Mutlak Değer: " + Math.Abs(sayi1));
            Console.WriteLine("Üst Taban: " + Math.Ceiling(sayi1));
            Console.WriteLine("Alt Taban: " + Math.Floor(sayi1));
            Console.WriteLine("Karekök: " + Math.Sqrt(sayi1));
            Console.WriteLine("Üs Alma: " + Math.Pow(sayi1,sayi2));   // Burada iki değer girilmesi gerekiyor.
            Console.WriteLine("Pi: " + Math.PI);          // pi ssayısında değer girilmiyor. Bu şekil kullanılıyor


            Console.Read();
        }
    }
}
