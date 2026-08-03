using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserDefinedMethods
{

    

    internal class AdamsList
    {
        public static string AdamnumsList(long start, long end)
        {
            string res = string.Empty;
            for (long i = start; i < end; i++)
            {
                if (IsAdam(i))
                {
                    res += i + ",";
                }
            }
            return res.Substring(0, res.Length - 1) + ".";
        }

        public static bool IsAdam(long num)// num = 12
        {
            return Square(num) == Reverse(Square(Reverse(num)));
        }

        private static long Reverse(long v)
        {
            long rev = 0;
            while (v > 0)
            {
                rev = rev * 10 + v % 10;
                v /= 10;
            }
            return rev;
        }

        private static long Square(long v)
        {
            return v * v;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(AdamnumsList(1,100));
           
        }
    }
}
