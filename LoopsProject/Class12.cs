using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsProject
{
    internal class Class12
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number : ");
            int num = int.Parse(Console.ReadLine());
            int rev = 0;
            int copy = num;
            while (num > 0)
            {
                int digit = num % 10;
                rev = rev * 10 + digit;
                num /= 10;
            }
            if (copy == rev)
            {
                Console.WriteLine($"{copy} is a Palindrome Number");
            }
            else
            {
                Console.WriteLine($"{copy} is not a Palindrome number");
            }
        }
    }
}
