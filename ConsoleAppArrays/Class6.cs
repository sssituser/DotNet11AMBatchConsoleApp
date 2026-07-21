using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppArrays
{
    internal class Class6
    {
        static void Main(string[] args)
        {
            int[,] a = { {10,34,56 },{6,78,90 },{33,55,66 } };

            Console.WriteLine("=====Array Elements are======");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write($"{a[i, j]}\t");
                }
                Console.WriteLine();
            }

            
            Console.WriteLine("=====Array Elements are======");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write($"{a[i, j]}\t");
                }
                Console.WriteLine();
            }
        }
    }
}
