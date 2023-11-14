using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_and_Object_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            papagan p = new papagan();
            p.tur = "Papağan";
            p.hiz = 50;
            p.isim = "Sultan";
            p.renk = "Sarı - Kırmızı ";
            p.agirlik = 1650;
            p.sescikar();

            Console.WriteLine("Tür: " + p.tur);
            Console.WriteLine("Hız: " + p.hiz);
            Console.WriteLine("İsim: " + p.isim);
            Console.WriteLine("Renk: " + p.renk);
            Console.WriteLine("Ağırlık: " + p.agirlik);
            Console.WriteLine("Ses: " + p.sescikar());

            Console.WriteLine();
            Console.WriteLine();

            karga k = new karga();
            k.tur = "Alaca Karga";
            k.hiz = 70;
            k.isim = "Karga";
            k.renk = "Siyah ";
            k.agirlik = 1950;
            k.sescikar();

            Console.WriteLine("Tür: " + k.tur);
            Console.WriteLine("Hız: " + k.hiz);
            Console.WriteLine("İsim: " + k.isim);
            Console.WriteLine("Renk: " + k.renk);
            Console.WriteLine("Ağırlık: " + k.agirlik);
            Console.WriteLine("Ses: " + k.sescikar());

            Console.Read();

        }
    }
}
