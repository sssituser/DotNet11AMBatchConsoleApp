using System;

namespace ConsoleAppArrays
{
    internal class Class8
    {
        static void Main(string[] args)
        {
            int[,] a = { {1,2,3 }, { 4,5,6 } };
            int[,] b = { { 5, 6 }, { 7, 8 },{ 9, 10 } };
            int[,] c = new int[2, 2];

            Console.WriteLine("A matrix elements");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write($"{a[i,j]}\t");
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine("B matrix elements");
            for (int i = 0; i < b.GetLength(0); i++)
            {
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    Console.Write($"{b[i, j]}\t");
                }
                Console.WriteLine("\n");
            }
            ///===========Logic
            ///

            for(int i = 0; i < 2; i++) 
            {
                for(int j = 0;j < 2; j++) 
                {
                    for(int k = 0; k < 3; k++) 
                    {
                        c[i, j] = a[i, k] * b[k, j] + c[i, j];
                    }                                        
                                                            
                }
            }

            Console.WriteLine("Product of A and B matrix elements");
            for (int i = 0; i < c.GetLength(0); i++)
            {
                for (int j = 0; j < c.GetLength(1); j++)
                {
                    Console.Write($"{c[i, j]}\t");
                }
                Console.WriteLine("\n");
            }
        }
    }
}
