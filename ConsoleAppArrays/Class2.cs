using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppArrays
{
    internal class Class2
    {
        static void Main(string[] args)
        {
            int[,] a = { { 11, 56, 78 }, { 90, 98, 97 } };

            Console.WriteLine("Array elements using foreach are");
            foreach (int item in a)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Array elemens usinng for loop");
            for(int i= 0; i < a.GetLength(0); i++)
            { 
                for(int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write($"{a[i, j]}");
                }
                Console.WriteLine();

            }
            
        }
    }
}

