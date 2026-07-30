using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace UserDefinedMethods
{
    internal class PalindromeList
    {
        //start=1 end=100000  1,2,3.....9999.
        //AM : public static
        //MN : Palindormes/PalinList/PalindromeList
        //PM : 2-long
        //RT : string
        public static string PalinList(long start,long end)//100, 2000
        {
            string res = string.Empty;
            for(long i = start; i <= end; i++)
            {
                if (IsPalindrome(i))
                {
                    res += i + ",";
                }
            }
            return res.Substring(0,res.Length-1)+".";
        }

        public static bool IsPalindrome(long num)// 123
        {
            return num == Reverese(num);

        }

        public static long Reverese(long num)
        {
            long rev = 0;
            while (num > 0)
            {
                rev = rev * 10 + num % 10;
                num /= 10;
            }
            return rev;
        }

        //AM : public static  MN : IsPalindrome RT : boolean  PM : 1-long
        //AM : public static  MN : Reverse RT : 1-long PM : 1-long

        static void Main(string[] args)
        {
            Console.WriteLine($"Palindrome List : {PalinList(1,10000000)}");
        }
    }
}
