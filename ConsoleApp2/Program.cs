using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Soru1:1den 10a kadar olan sayıların toplamını bulan programı yazınız.

            int toplam = 0;
            for (int i = 0; i < 10; i++)
            {
                toplam += i; //toplam = toplam + i
            }
            Console.WriteLine("toplam ={0}",toplam);


            //Soru2:Kullanıcı tarafından girilen sayıya kadar olan tek sayilarin kaç adet olduğunu bulan programı yazınız...
            Console.WriteLine("Bir sayı giriniz");
            int a= Convert.ToInt32(Console.ReadLine());
            int tekSayılarınAdedi = 0;
            for (int i = 0; i <= a; i++)
            {
                if (i % 2 == 1) tekSayılarınAdedi++;
            }
            Console.WriteLine("Tek sayıların adedi="+tekSayılarınAdedi);

        }
    }
}
