using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {            
            //i,j,k kullanılır genelde sayaçlar için.genel bir jargondur.

            for (int i = 0; i <= 10; i++) 
                Console.WriteLine(i);


            int a = 0;
            while (a<10)
            {
                Console.WriteLine(a);
                a++;
            }
            
            
            int j = 0;
            do
            {
                Console.WriteLine(j);
                j=j+2;
            } while (j < 10);
        }
    }
}
