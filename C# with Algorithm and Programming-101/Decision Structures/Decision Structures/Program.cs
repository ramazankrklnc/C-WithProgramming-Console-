using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decision_Structures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             string sehir;
             Console.Write("Şehir İsmi Giriniz: ");
             sehir = Console.ReadLine();

             if (sehir == "İstanbul")
             {
                 Console.Write("Doğru Tahmin ");
             }

             else
             {
                 Console.Write("Yanlış Tahmin !!!");
             }

             Console.Read();
             */


            /* Student Note App (Öğrenci Not Uygulaması)
            
            int s1, s2, ort;
            Console.Write("1. Sınav Notunuzu Giriniz: ");
            s1 = Convert.ToInt16(Console.ReadLine());
            Console.Write("2. Sınav Notunuzu Giriniz: ");
            s2 = Convert.ToInt16(Console.ReadLine());
            ort = (s1 + s2) / 2;
            Console.WriteLine("Ortalamanız: " + ort);
            if (ort >= 50)
            {
                Console.Write("Tebrikler! Geçtiniz.");
            }
            else
            {
                Console.Write("Büte Kaldınız :( ");
            }
            Console.Read();

            */

            // Use of Multiple if Blocks (Birden Fazla İf Bloğu Kullanımı)

            /*
            int s1, s2, s3,ort;
            Console.Write("1. Sınav Notunuzu Giriniz: ");
            s1 = Convert.ToInt16(Console.ReadLine());
            Console.Write("2. Sınav Notunuzu Giriniz: ");
            s2 = Convert.ToInt16(Console.ReadLine());
            Console.Write("3. Sınav Notunuzu Giriniz: ");
            s3 = Convert.ToInt16(Console.ReadLine());
            ort = (s1 + s2 + s3) / 3;
            Console.WriteLine("Ortalamanız: " + ort);

            if (ort <= 49)
            {
                Console.WriteLine("Durum: Vasat");
            }

            if (ort >= 50 & ort <= 65)
            {
                Console.WriteLine("Durum: Orta");
            }

            if (ort >= 66 & ort <= 79)
            {
                Console.WriteLine("Durum: İyi");
            }

            if (ort >= 80 & ort == 100)
            {
                Console.WriteLine("Durum: Çok İyi");
            }
            */

            // Using String Variables with Switch-Case (Switch Case ile String Değişkenlerin Kullanımı)

            Console.WriteLine("String Değişkenler ile Switch-Case Mevsim Uygulaması");
            Console.WriteLine();

            string mevsim;
            Console.Write("Lütfen Mevsim Giriniz: ");
            mevsim = Console.ReadLine();

            switch (mevsim)
            {
                case "ilkbahar":Console.Write("Mart - Nisan - Mayıs");break;
                case "yaz": Console.Write("Haziran - Temmuz - Ağustos"); break;
                case "sonbahar": Console.Write("Eylül - Ekim - Kasım"); break;
                case "kış": Console.Write("Aralık - Ocak - Şubat"); break;
                default: Console.Write("Hatalı mevsim girişi!!!");break;
            }

            Console.Read();
            
        }
    }
}
