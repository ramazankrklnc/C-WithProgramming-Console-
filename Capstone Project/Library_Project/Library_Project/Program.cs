using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Library_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int toplam_fiyat = 0;
            string secim;
            Console.WriteLine("*************************************************************************************************");
            Console.WriteLine();
            Console.WriteLine("****     Turkish Book Categories           ****          Other Book Categories               ****");
            Console.WriteLine();
            Console.WriteLine("****     1-Çalıkuşu: Reşat Nuri            ****          7-Tuna Kılavuzu: June Verne         ****");
            Console.WriteLine();
            Console.WriteLine("****     2-Yaban: Yakup Kadri              ****          8-Bir Kuzey Macerası: Jack London   ****");
            Console.WriteLine();
            Console.WriteLine("****     3-Sinekli Bakkal: Halide Edip     ****          9-Altıncı Koğuş: Anton Çehov        ****");
            Console.WriteLine();
            Console.WriteLine("****     4-Tehlikeli Oyunlar: O.Atay       ****          10-Kumarbaz: Dostoyevski            ****");
            Console.WriteLine();
            Console.WriteLine("****     5-Geçtiğim Günlerden: H.Yücel     ****          11-İki Şehrin Hikayesi: C.Dickens   ****");
            Console.WriteLine();
            Console.WriteLine("****     6-Kuyucaklı Yusuf: S.Ali          ****          12-Vişne Bahçesi: Anton Çehov       ****");
            Console.WriteLine();
            Console.WriteLine("*************************************************************************************************");
            Console.WriteLine();
            Console.WriteLine("***** İişlemler Menüsü *****");
            Console.WriteLine();
            Console.WriteLine("1-Fiyat Sorgulama");
            Console.WriteLine("2-Yeni Okur Kaydı");
            Console.WriteLine("3-Günün Kitabı");
            Console.WriteLine("4-Kitap Arşivi");
            Console.WriteLine("5-Yeni Kitap Satın Al");
            Console.WriteLine("6-Oyun");
            Console.WriteLine();
            Console.Write("Yapmak İstedğiniz İşlemin Numarasını Giriniz: ");
            char islem;
            islem = Convert.ToChar(Console.ReadLine());
            if (islem == '1')
            {
                Console.WriteLine();
                Console.Write("Lütfen fiyatını doğrulamak istedğiniz kitabin numarasını giriniz: ");
                string numara;
                numara = Console.ReadLine();
                switch (numara)
                {
                    case "1" :Console.WriteLine("Çalıkuşu: 12TL");break;
                    case "2": Console.WriteLine("Yaban: 14TL"); break;
                    case "3": Console.WriteLine("Sinekli Bakkal: 16TL"); break;
                    case "4": Console.WriteLine("Tehkileli Oyunlar: 11TL"); break;
                    case "5": Console.WriteLine("Geçtiğim Günlerden: 8TL"); break;
                    case "6": Console.WriteLine("Kuyucaklı Yusuf: 13TL"); break;
                    case "7": Console.WriteLine("Tuna Kılavuzu : 17TL"); break;
                    case "8": Console.WriteLine("Bir Kuzey Macerası: 4TL"); break;
                    case "9": Console.WriteLine("Bir Kuzey Macerası: 5TL"); break;
                    case "10": Console.WriteLine("Kumarbaz: 10TL"); break;
                    case "11": Console.WriteLine("İki Şehrin Hikayesi: 13TL"); break;
                    case "12": Console.WriteLine("Vişne Bahçesi: 6TL"); break;
                    default:Console.WriteLine("Böyle Bir Kitap mevcut değildir. Lütfen Girdiğiniz Numarayı Kontrol Ediniz!!!");break;
                }
            }
            if (islem == '2')
            {
                Console.WriteLine("***** Yeni Okur Kaydı *****");
                string ad, soyad, universite;
                Console.Write("Lütfen Adınızı Giriniz: ");
                ad = Console.ReadLine();
                Console.Write("Lütfen Soyadınızı Giriniz: ");
                soyad = Console.ReadLine();
                Console.Write("Lütfen Üniversitenizi Giriniz: ");
                universite = Console.ReadLine();
                string dosya = (@"C:\Users\ASUS\OneDrive\Masaüstü\C# with Programming\Capstone Project\Library_Project\Kişi Kaydı.txt");
                StreamWriter sw = new StreamWriter(dosya);
                sw.WriteLine("Adınız: " + ad);
                sw.WriteLine("Soyadınız: " + soyad);
                sw.WriteLine("Üniversiteniz: " + universite);
                sw.Close();
            }
            if (islem == '3')
            {
                Console.WriteLine();
                Console.WriteLine("*****************************************");
                Console.WriteLine("*                                       *");
                Console.WriteLine("***** Bugünün Kitabı: Vişne Bahçesi *****");
                Console.WriteLine("*                                       *");
                Console.WriteLine("*****************************************");
                Console.WriteLine();
            }
            if (islem == '4')
            {
                Console.WriteLine();
                Console.WriteLine("***********************************************");
                FileStream fs = new FileStream(@"C:\Users\ASUS\OneDrive\Masaüstü\C# with Programming\Capstone Project\Library_Project\Kitap Arşivi.txt", FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                string metin = sr.ReadLine();
                while(metin != null)
                {
                    Console.WriteLine(metin);
                    metin = sr.ReadLine();
                }
                sr.Close();
                fs.Close();
                Console.WriteLine("***********************************************");
                Console.WriteLine();
            }
            if (islem == '5')
            {
                for (int i = 0; i <= 100; i+= 1)
                {
                    Console.WriteLine();
                    Console.Write("Alacağınız Kitabın Numarası: ");
                    secim = Console.ReadLine();
                    if (secim == "1")
                    {
                        toplam_fiyat = toplam_fiyat + 12;
                    }
                    else if (secim == "2")
                    {
                        toplam_fiyat = toplam_fiyat + 14;
                    }
                    else if (secim == "3")
                    {
                        toplam_fiyat = toplam_fiyat + 16;
                    }
                    else if (secim == "4")
                    {
                        toplam_fiyat = toplam_fiyat + 111;
                    }
                    else if (secim == "5")
                    {
                        toplam_fiyat = toplam_fiyat + 18;
                    }
                    else if (secim == "6")
                    {
                        toplam_fiyat = toplam_fiyat + 13;
                    }
                    else if (secim == "7")
                    {
                        toplam_fiyat = toplam_fiyat + 17;
                    }
                    else if (secim == "8")
                    {
                        toplam_fiyat = toplam_fiyat + 4;
                    }
                    else if (secim == "9")
                    {
                        toplam_fiyat = toplam_fiyat + 5;
                    }
                    else if (secim == "10")
                    {
                        toplam_fiyat = toplam_fiyat + 10;
                    }
                    else if (secim == "11")
                    {
                        toplam_fiyat = toplam_fiyat + 13;
                    }
                    else if (secim == "12")
                    {
                        toplam_fiyat = toplam_fiyat + 6;
                    }
                    else
                    
                        Console.WriteLine("Böyle Bir Kitap Numarası Yok.");
                        Console.WriteLine();
                        Console.WriteLine("Başka Bir Kitap almak İster Misiniz? ");
                        Console.Write("Cevabınızı Buraya Yazınız: ");
                        string cevap;
                        cevap = Console.ReadLine();
                        if (cevap == "h" || cevap == "H" || cevap == "Hayır" || cevap == "hayır" || cevap == "HAYIR")
                            break;
                }
                Console.WriteLine("Toplam Tutar: " + toplam_fiyat);

            }
            if (islem == '6')
            {
                Console.WriteLine();
                int tahmin = 0;
                Random rn = new Random();
                int sayi = rn.Next(1, 100);
                while (sayi != tahmin)
                {
                    Console.Write("Sayı Giriniz: ");
                    tahmin = Convert.ToInt16(Console.ReadLine());
                    if (tahmin > sayi)
                    {
                        Console.Write("Daha Küçük ");
                    }
                    if (tahmin < sayi)
                    {
                        Console.WriteLine("Daha Büyük ");
                    }
                    if (tahmin == sayi)
                    {
                        Console.WriteLine("Tebrikler Doğru Tahmin!!!!");
                    }
                }
            }
            Console.Read();
        }
    }
}
