using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsProject
{
    internal class Class8
    {
        static void Main(string[] args)
        {
            int num = 567;
            int count = 0;
            int sum = 0;
            while (num > 0) // 567>0 56>0-T 5>0 0>0-F
            {
                int digit = num % 10; // digit = 567%10 digit 7  digit = 56%10 digit = 6  digit = 5%10 => 5
                Console.WriteLine(digit);
                sum +=  digit;
                count++;
                num = num / 10;// num = 567/10 num = 56/10 num = 5/10 num = 0
            }
            Console.WriteLine($"No of Digits in the Given number is : {count}");
            Console.WriteLine($"Sum of the Digits of the Given number is : {sum}");
        }
    }
}
