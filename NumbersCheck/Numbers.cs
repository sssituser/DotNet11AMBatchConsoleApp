using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersCheck
{
    public class Numbers
    {
        public static bool IsPalindrome(int num)
        {
            return num == Reverse(num);
        }
        public static int Reverse(int num)
        {
            int rev = 0;
            while (num > 0)
            {
                rev = rev * 10 + num % 10;
                num /= 10;
            }
            return rev;
        }
        public static bool IsAdam(int num)
        {
            return Square(num) == Reverse(Square(Reverse(num)));
        }
        public static int Square(int num)
        {
            return num * num;
        }
        public ulong Factorial(ulong num)
        {
            ulong fact = 1;
           
                for (ulong i = 1; i <= num; i++)
                {
                    fact *= i;
                }
            return fact;
        }
        public bool IsArmstrong(int num)
        {
            int count = num.ToString().Length;
            int sum = 0;
            int copy = num;
            while (num > 0)
            {
                sum = sum + Power(num%10, count);
                num /= 10;
            }
            return copy == sum;
        }
        public int Power(int bas, int power)
        {
            int res = 1;
            for (int i = 1; i <= power; i++)
            {
                res *= bas;
            }
            return res;
        }
    }
}
