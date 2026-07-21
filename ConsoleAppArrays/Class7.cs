using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppArrays
{
    internal class Class7
    {
        static void Main(string[] args)
        {
            int[,] a = { { 1, 2 }, { 3, 4 } };
            Console.WriteLine("A matrix elements");
            for(int i = 0; i < a.GetLength(0); i++)
            {
                for(int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write($"{a[i, j]}\t");
                }
                Console.WriteLine();
            }
            int[,] b = { { 5, 6 }, { 7, 8 } };
            Console.WriteLine("B matrix elements");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write($"{b[i, j]}\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Sum of A matrix and B matrix elements");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write($"{a[i, j] + b[i,j]}\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Sub of A matrix and B matrix elements");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write($"{a[i, j] - b[i, j]}\t");
                }
                Console.WriteLine();
            }
        }
    }
}
