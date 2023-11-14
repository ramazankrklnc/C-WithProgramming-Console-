using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            // Örnek For Döngüsü Kullanımı-1 (Example of For Loop Usage-1)

            int i;

            for(i= 1; i <= 10;  i++)
            {
                Console.WriteLine("Ramazan");
            }
            */

            /*
            // Örnek For Döngüsü Kullanımı-2 (Example of For Loop Usage-2)
            
            // 1'den 10'a kadar olan sayıları ekrana yazdıran kodu yazınız.

            int i;

            for(i = 1; i < 11;  i++)
            {
                Console.WriteLine(i);
            }
            */

            /*
            // 0 ile 20 arasındaki çift sayıları ekrana yazdıran kodu yazınız.

            int j;

            for (j = 0; j < 21; j += 2)
            {
                Console.WriteLine(j);
            }
            */

            /*
            // Ekrana 100 defa "Merhaba İstanbul" yazdıralım fakat adım sırası da yazsın.

            int k;

            for (k = 0; k<=100; k += 1)
            {
                Console.WriteLine(k + "-" + "Merhaba İstanbul" );
            }
            */

            /*
            // Using Mod (Mod Kullanımı)

            int sayi = 24 % 9; 
            Console.WriteLine(sayi);

            */

            /*
            // Using Mods with Decision Structures (Karar Yapıları ile Mod Kullanımı ) 

            int sayi;
            Console.Write("Sayıyı Giriniz: ");
            sayi = Convert.ToInt32(Console.ReadLine());

            if (sayi %2 == 0)
            {
                Console.WriteLine("Sayı Çifttir.");
            }

            else
            {
                Console.WriteLine("Sayı Tektir.");
            }
            */

            /*
            // 1 ile 20 arası 3'e tam bölünen sayıların listesini ekrana yazdıran kod bloğunu yazınız.

            for (int i = 0; i <= 20; i++)
            {
                if (i %3 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            */

            /*
            //Tam bölenleri bulma
            // 20 --> 1 2 4 5 10 20

            int sayi;
            Console.Write("Sayı Giriniz: ");
            sayi = Convert.ToInt16(Console.ReadLine());
            for (int i = 1; i < sayi; i++)
            {
                if (sayi % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
            */

            /*
            // Algorithmic Interview Question (Algoritmik Mülkakat Sorusu)
            // Soru: Bir bakteri türü her saatin sonunda kendini 2'ye bölerek çoğaltmaktadır.
            //Yeni oluşan bakteriler de aynı şekilde çoğalmaktadırlar.
            //24 saatin sonunda bu ortamda kaç tane bakteri olur?

            int bakteri = 1;

            for (int i = 1; i <= 24; i += 1)
            {
                bakteri = bakteri * 2;
                Console.WriteLine(bakteri);
            }
            */

            /*
            // Operations with Consecutive Numbers (Ardışık Sayılarla İşlemler)
            // 1 ile 10 arasındaki sayıların toplamını hesaplamaya yarayan kodu yazınız.

            int toplam = 0;
            for (int i = 1; i <= 10; i += 1)
            {
                toplam = toplam + i;
                Console.WriteLine(toplam);
            }
            */

            /*
            // Faköriyel hesaplamaya yarayan kod 

            int faktoriyel = 1;

            for (int i = 5; i >= 1; i--)
            
            {
                faktoriyel = faktoriyel * i;
                Console.WriteLine(faktoriyel);
            }
            */


            /*
            // While Loop (While Döngüsü)
            // "Deneme" kelimesini ekrana 10 kez yazdıran while döngülü kod bloğınu yazınız.

            int sayac = 1;
            while (sayac <= 10)
            {
                Console.WriteLine("Deneme");
                sayac += 1;           // Eğer biz bunu yazmazsak kod sonsuz döngüya girecekti.
            }
            */


            /*
            // 1 ile 20 arasındaki sayıları listeleyen while döngülü kod bloğunu yazınız.

            int sayac = 1;
            while (sayac <= 20)
            {
                Console.WriteLine(sayac);
                sayac += 1;           
            }
            */


            /*
            // 1 ile 10 arasındaki sayıların toplamını hesaplayan while döngülü kod bloğunu yazınız.

            int sayac = 1;
            int toplam = 0;
            while (sayac <= 10)
            {
                toplam = toplam + sayac;
                Console.WriteLine(toplam);
                sayac += 1;
            }
            */


            // Soru: Klavyeden girilen sayının faktöriyelini while döngüsü ile hesaplayan kodu yazınız.

            int sayi;
            int faktoriyel = 1;

            Console.Write("Sayı Giriniz: ");
            sayi = Convert.ToInt16(Console.ReadLine());
            while (sayi >= 1)
            {
                faktoriyel = faktoriyel * sayi;
                sayi -= 1;
                Console.WriteLine("Sonuç: " + faktoriyel);
            }

            Console.Read();
        }
    }
}
