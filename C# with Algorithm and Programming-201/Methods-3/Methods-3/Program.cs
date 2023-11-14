using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_3
{
    internal class Program
    {
        // Geriye Değer DÖndüren Parametreli Metot Örneği

        public static int toplam(int s1, int s2)
        {
            int sonuc;
            sonuc = s1 + s2;
            return sonuc;
        }
        static void Main(string[] args)
        {
            Console.Write("Birinci Sayıyı Giriniz: ");
            int s1 = Convert.ToInt16(Console.ReadLine());
            Console.Write("İkinci Sayıyı Giriniz: ");
            int s2 = Convert.ToInt16(Console.ReadLine());
            Console.Write("Toplama Sonucu: ");
            Console.WriteLine(toplam(s1, s2));

            Console.Read();
        }
    }
}
