using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string metin1, metin2;
            Console.Write("Birinci Metni Giriniz: ");
            metin1 = Console.ReadLine();
            Console.Write("İkinci Metni Giriniz: ");
            metin2 = Console.ReadLine();

            Console.WriteLine("Concat ile Birleştirme: " + string.Concat(metin1, " " ,metin2));
            Console.WriteLine("metin1 için karakter sayısı: " + metin1.Length);
            Console.WriteLine("IndexOf Örneği: " + metin1.IndexOf("İs"));
            Console.WriteLine("Starswith Örneği: " + metin1.StartsWith("Merhaba"));
            Console.WriteLine("    Merhaba Selam:" + metin1.Trim());
            Console.WriteLine("Büyük Harf: " + metin1.ToUpper());
            Console.WriteLine("Küçük Harf: " + metin1.ToLower());
            Console.WriteLine("Remove Metodu: " + metin1.Remove(4));
            Console.WriteLine("Replace Metodu: " + metin1.Replace("a", "A"));
            Console.WriteLine("Substring Metodu: " + metin1.Substring(4));


            Console.Read();
        }
    }
}
