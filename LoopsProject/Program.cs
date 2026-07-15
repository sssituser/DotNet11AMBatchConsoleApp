using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsProject
{//Write a program to generate number from 1 to the given number ?
    // num = 5          1 2 3 4 5
    // num = 10         1 2 3 4 5 6 7 8 9 10
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 10;
            int min = 1;
            int max = num;

            while(min <= max) // 1<=5 -T 2<=5-T 3<=5-T 4<=5-T  5<=5-T  6<=5-F
            {
                Console.WriteLine(min); // 1  2 3  4  5
                min++; // min = 2 min = 3  min = 4 min = 5 min = 6
            }
        }
    }
}
