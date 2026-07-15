using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsProject
{
    /*
        write a program to generate the even numbers from 2 to the given value?

        num = 40
        2 4 6 8 10 12 14 16 18 20 22 24  26  28 30 32 34 36  38 40
     */
    internal class Class1
    {
        static void Main(string[] args)
        {
            int num = 40;
            int start = 1;
            int end = num;
            while(start <= end) // 2<=40-T  4<=40 6<40 38<=40 40<=40 42<=40
            {
                Console.WriteLine(start); // 2  4   6    38 40
                start += 2; // start = 4 start = 6   start = 38 start = 40 start = 42

            }


            
        }
    }
}
