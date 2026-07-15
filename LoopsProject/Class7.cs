using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsProject
{
    internal class Class7
    {
        
        static void Main(string[] args)
        {
            int num = 123;
            while (num > 0) // 123>0 12>0 1>0 0>0
            {
                int digit = num % 10;//digit = 123%10 digit = 3 digit = 12%10 digit = 2 digit = 1%10 digit = 1
                Console.WriteLine(digit); // 3   2  1
                num /= 10;// num = 123/10 num = 12/10 num = 1/10 num = 0

            }
        }
    }
}
