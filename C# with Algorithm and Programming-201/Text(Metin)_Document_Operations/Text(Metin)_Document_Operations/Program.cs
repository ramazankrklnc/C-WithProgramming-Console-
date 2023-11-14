using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Text_Metin__Document_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Dosya oluşturma ve Oluşturulan dosya içine yazı yazma

            //StreamWriter sw = new StreamWriter("C:\\Users\\ASUS\\OneDrive\\Masaüstü\\C# with Programming\\C# with Algorithm and Programming-201\\Text(Metin)_Document_Operations\\Deneme.txt");
            //sw.WriteLine("Merhaba! Bu yazı, bu dosyayı doldurmak için yazılan bir yazıdır.");
            //sw.Close();

            // Metin Belgesi İçine Klavyeden veri girilmesi

            //StreamWriter sw = new StreamWriter(@"C:\Users\ASUS\OneDrive\Masaüstü\C# with Programming\C# with Algorithm and Programming-201\Text(Metin)_Document_Operations\Deneme2.txt");
            //string metin;
            //Console.Write("Metni Giriniz: ");
            //metin = Console.ReadLine();
            //sw.Write(metin);
            //sw.Close();


            // Mevcut Metin Belgesi Okuma

            FileStream fs = new FileStream(@"C:\Users\ASUS\OneDrive\Masaüstü\C# with Programming\C# with Algorithm and Programming-201\Text(Metin)_Document_Operations\Deneme3.txt" , FileMode.Open, FileAccess.Read );
            StreamReader sr = new StreamReader(fs);
            string metin = sr.ReadLine();
            while( metin != null )
            {
                Console.WriteLine( metin );
                metin = sr.ReadLine();
            }

            sr.Close();
            fs.Close();

            Console.Read();
        }
    }
}
