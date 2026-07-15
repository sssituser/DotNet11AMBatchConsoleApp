using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsProject
{
    internal class Class10
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number  : ");
            int num = int.Parse(Console.ReadLine());
            int max = num % 10;  // max = 3
            while (num > 0) // 523>0-T 52>0-T 5>0-T 0>0-F
            {
                int digit = num % 10; //digit = 5%10 digit = 5 digit = 523%10 digit = 3 digit = 52%10 digit =2
                if (digit > max) // 3>3-F 2>3-F  5>3-T
                {
                    max = digit; // max = 5
                }
                num = num / 10;// num = 523/10 num = 52/10 num = 5/10 num = 0

            }
            Console.WriteLine($"Max digit is of the above number: {max}");
        }
    }
}
