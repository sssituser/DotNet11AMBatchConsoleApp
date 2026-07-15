using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsProject
{
    internal class Class20
    {
        static void Main(string[] args)
        {
            int num = 5;
            int k = 1;
            for (int row = 1; row <= num; row++)
            {
              
                for(int j = 1; j <= row; j++)
                {
                    Console.Write($"{j}\t");
                }
                Console.WriteLine();

            }

            for(int row = num - 1; row >= 1; row--)
            {
                for(int j=1;j<= row; j++)
                {
                    Console.Write($"{j}\t");
                }
                Console.WriteLine();
            }
        }
    }
}
