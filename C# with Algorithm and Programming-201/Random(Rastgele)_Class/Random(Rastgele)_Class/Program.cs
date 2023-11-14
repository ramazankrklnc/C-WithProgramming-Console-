using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random_Rastgele__Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int sayi;
            //Random random = new Random();
            //sayi = random.Next(0,51);
            //Console.Write(sayi);

            // Random sınıfı ile dizilerin kullanımı

            //Random rn = new Random();
            //int sehir;
            //string [] sehirler = { "Adana", "Ankara", "Bursa", "İstanbul" };
            //sehir = rn.Next(0, sehirler.Length);
            //Console.Write(sehirler[sehir]);

            // Captcha Oluşturma: Bu sol tarafta rastgele gelen sayılara deniyor.

            int d1, d2, d3, d4;
            Random rn = new Random();
            d1 = rn.Next(0, 10);
            d2 = rn.Next(0, 10);
            d3 = rn.Next(0, 10);
            d4 = rn.Next(0, 10);

            Console.WriteLine(d1);
            Console.WriteLine(d3);
            string[] karakterler = { "a", "A", "b", "B", "c", "C", "d", "D", "e", "E" };
            Console.WriteLine(d1 + karakterler[d2]);
            Console.WriteLine(d3 + karakterler[d4]);

            Console.Read();
        }
    }
}
