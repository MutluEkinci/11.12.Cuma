using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Soru3:Kullanıcı pozitif tamsayı girdiği müddetçe toplama işlemi yapan, ilk negatif sayıda programı bitiren kodu yazınız.

            //for(; ; )
            //{
            //    Console.WriteLine("yaz");
            //}
            //while (true){
            //Console.WriteLine("...");


            int sayi;
            int toplam = 0;
            //do
            //{
            //    sayi = int.Parse(Console.ReadLine());
            //    if (sayi > 0) toplam += sayi;
            //    //Console.WriteLine(toplam); bu şekilde de olabilir.(her seferinde toplar.
            //} while (sayi > 0);
            //Console.WriteLine(toplam);

            for (; ;  )
            {
                Console.WriteLine("Bir Sayi Giriniz");
                sayi = int.Parse(Console.ReadLine());
                if (sayi > 0) 
                    toplam += sayi;
                else if (sayi < 0) 
                    break;
            }
            Console.WriteLine("Sayilarin Toplami=" +toplam); ;            
        }
    }
}
