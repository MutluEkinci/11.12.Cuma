using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {

            //Diziler

            int[] numbers = new int[10];
            int[] sayılar = { 23, 56, 32, 48, 20, 78, 88 };

            numbers[5] = 111;

            for (int i = 0; i < numbers.Length; i++)
                Console.WriteLine(numbers[i]);
            foreach(int sayı in sayılar )
                Console.WriteLine(sayı);





        }
    }
}
