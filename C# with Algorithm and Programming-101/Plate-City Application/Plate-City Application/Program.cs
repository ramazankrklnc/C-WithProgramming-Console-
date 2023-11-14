using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plate_City_Application
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte plaka;
            Console.Write("Lütfen plakayı giriniz:");
            plaka= byte.Parse(Console.ReadLine());

            switch (plaka)
            {
                case 1:Console.Write("Merhaba Adana");break;
                case 2:Console.Write("Merhaba Adıyaman");break;
                case 3:Console.Write("Merhaba Afyon");break;
                default:Console.Write("Henüz bu şehir bilgisi girilmedi");break;
                // Buradaki şehir örnekleri gittikçe artabilir. Size kalmış....
            }

            Console.Read();
        }
    }
}
