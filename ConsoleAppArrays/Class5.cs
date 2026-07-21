using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppArrays
{
    internal class Class5
    {
        static void Main(string[] args)
        {
            int[,] a = new int[3, 3];
            for(int i = 0; i < a.GetLength(0); i++)
            {
                for(int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write($"Enter a[{i} , {j}] Element : ");
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("=====Array elements are======");
            for(int i = 0; i < a.GetLength(0); i++)
            {
                for(int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write($"{a[i, j]}\t");
                }
                Console.WriteLine("\n");
            }
        }
    }
}
