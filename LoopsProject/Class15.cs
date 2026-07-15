using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsProject
{
    internal class Class15
    {
        static void Main(string[] args)
        {
            int num = 12;
            int factor = 1;
            while (factor <= num) 
            {
                if (num % factor == 0) 
                {
                    Console.WriteLine(factor); 
                }
                factor++; 
            }

        }
    }
}
