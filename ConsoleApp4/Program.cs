using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {

            //Soru4:kullanıcı tarafından 10lu sistemde girilen bir tamsayıyı 2li sisteme çeviren programı yazınız.

            int sayi = int.Parse(Console.ReadLine());
            string ikiliSayi = "";
            while (sayi > 0) 
            {
                ikiliSayi = (sayi % 2).ToString() + ikiliSayi;
                sayi = sayi / 2;
                
            }
            Console.WriteLine(ikiliSayi);
            
            
        }
    }
}
