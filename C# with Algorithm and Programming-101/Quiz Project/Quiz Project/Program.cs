using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Kurallar: 
             * Toplam soru sayısı: 3
             * Her soru için şık sayısı: 4
             * Diğer sorulara geçebilmek için doğru cevap verebilmek gerekiyor.
             * Yanlış cevap verildiği anda oyun biter.
             * 3 sorunun tamamı doğru cevaplanırsa oyun biter.
             */


            Console.WriteLine("Bilgi Yarışmasına HOŞGELDİNİZ....");
            Console.WriteLine("---------------------------------");
            Console.WriteLine();

            int soru = 1;
            string cevap;

            if (soru == 1)
            {
                Console.WriteLine("Türkiyenin başkenti neresidir?");
                Console.WriteLine("A) İstanbul");
                Console.WriteLine("B) Ankara");
                Console.WriteLine("C) İzmir");
                Console.WriteLine("D) Adıyaman");
                Console.WriteLine();
                Console.Write("Cevabınız:");

                cevap = Console.ReadLine();
                if (cevap == "b" || cevap == "B")
                {
                    soru = soru + 1;
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Cevabınız YANLIŞ!! Toplam Puanınız: 0");
                }
            }

            Console.WriteLine();
            if (soru == 2)
            {
                Console.WriteLine("Cumhuriyet kaç yılında kuruldu?");
                Console.WriteLine("A) 1920");
                Console.WriteLine("B) 1921");
                Console.WriteLine("C) 1922");
                Console.WriteLine("D) 1923");
                Console.WriteLine();
                Console.Write("Cevabınız:");

                cevap = Console.ReadLine();
                if (cevap == "d" || cevap == "D")
                {
                    soru = soru + 1;
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Cevabınız YANLIŞ!! Toplam Puanınız: 1");
                }
            }

            Console.WriteLine();
            if (soru == 3)
            {
                Console.WriteLine("Adıyaman hangi coğrafi bölgede bulunmaktadır?");
                Console.WriteLine("A) Akdeniz");
                Console.WriteLine("B) Karadeniz");
                Console.WriteLine("C) Güneydoğu Anadolu");
                Console.WriteLine("D) Marmara");
                Console.WriteLine();
                Console.Write("Cevabınız:");

                cevap = Console.ReadLine();
                if (cevap == "c" || cevap == "C")
                {
                    Console.WriteLine();
                    Console.WriteLine("TEBRİKLER!! Tüm soruları doğru cevapladınız.");
                    Console.WriteLine("YARIŞMA BİTTİ......");
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Cevabınız YANLIŞ!! Toplam Puanınız: 2");
                }
            }

            Console.Read();
        }
    }
}
