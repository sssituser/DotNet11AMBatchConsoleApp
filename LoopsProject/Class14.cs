using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LoopsProject
{
    internal class Class14
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number : ");
            int num = int.Parse(Console.ReadLine());
            int copy = num;
            int count = 0;
            int sum = 0;
            while (num > 0) // 153>0-T 15>0-T 1>0-T 0>0-F
            {
                int digit = num % 10;// digit = 153%10 digit = 3 digit = 15/10 digit = 5 digit = 1/%10 digit = 1
                count++; // count = 1 count = 2 count = 3
                num /= 10; // num = 153/10 num = 15/10 num = 15/10 num = 1/10 num = 0
            }
            num = copy;
            while (num > 0) // 153>0-T
            {
                int digit = num % 10;  // digit = 153%10 digit = 3
                int start = 1;int pval = 1;
                while (start <= count)
                {
                    pval *= digit;
                    start++;
                }
                sum += pval;
                num /= 10;
            }
            num = copy;
            if (num == sum)
            {
                Console.WriteLine($"{num} is an Armstrong");
            }
            else
            {
                Console.WriteLine($"{num} is Not An Armstrong");
            }



        }
    }
}
