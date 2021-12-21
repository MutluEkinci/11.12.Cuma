using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            //break ve continue

            //for (int i = 0; i < 10; i++)
            //{
            //    if (i == 5) continue;//break;
            //    Console.WriteLine(i);
            //}

            //Nested (bir döngü içinde başka döngülerin olması)
            for (int i = 0; i < 10; i++)
                for(int j=0;j<10;j++)
                {
                    if (i == 1) continue;
                    Console.WriteLine("{0},{1}",i,j);
                }        
            for (long i=0;i<99999999; i++)
                Console.WriteLine("Deneme");

            


        }
    }
}
