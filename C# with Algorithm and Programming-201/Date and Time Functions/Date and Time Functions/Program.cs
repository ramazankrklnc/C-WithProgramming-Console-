using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date_and_Time_Functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Datetime

            //Console.WriteLine("Bugünün Gün Bilgisi: " + DateTime.Now.Day);
            //Console.WriteLine("Bugünün Ay Bilgisi: " + DateTime.Now.Month);
            //Console.WriteLine("Bugünün Yıl Bilgisi: " + DateTime.Now.Year);
            //Console.WriteLine("Bugünün Saat Bilgisi: " + DateTime.Now.Hour);
            //Console.WriteLine("Bugünün Dakika Bilgisi: " + DateTime.Now.Minute);
            //Console.WriteLine("Bugünün Saniye Bilgisi: " + DateTime.Now.Second);
            //Console.WriteLine("Bugünün Kısa Tarih Bilgisi: " + DateTime.Now.ToShortDateString());
            //Console.WriteLine("Bugünün Uzun Tarih Bilgisi: " + DateTime.Now.ToLongDateString());

            // Time span

            TimeSpan zaman;
            int gunfarki;
            DateTime tarih1, tarih2, tarih3;
            tarih1 = DateTime.Now;
            tarih2 = Convert.ToDateTime("25.11.2002");
            zaman = tarih1 - tarih2;
            gunfarki = zaman.Days;
            Console.Write("Fark: " + gunfarki);


            Console.Read();
        }
    }
}
