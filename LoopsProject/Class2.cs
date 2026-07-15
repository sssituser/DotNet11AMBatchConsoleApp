using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsProject
{
    /*Write a program to generate numbers from the given number to 1
     * num = 5   5 4 3 2 1
     * num = 10  10 9 8 7 6 5 4 3 2 1
     */
    internal class Class2
    {
        static void Main(string[] args)
        {
            int num = 20;
            int start = num;
            int end = 1;

            do
            {
                Console.WriteLine(start);
                start--;
            } while (start >= end);





        }
    }
}
