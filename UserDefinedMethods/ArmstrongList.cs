using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserDefinedMethods
{
    //AM : public static MN :ArmsList/Armstrongs/  PM : 2-long   RT : string


    internal class ArmstrongList
    {
        public static string ArmsList(long start,long end)
        {
            string res = string.Empty;
            for (long i = start; i < end; i++)
            {
                if (IsArmstrong(i))
                {
                    res += i + ",";
                }
            }
            return res.Substring(0, res.Length - 1)+".";
        }



        public  static bool IsArmstrong(long num)
        {
            long pow = DigitCount(num);
            long sum = 0;
            long copy = num;
            while (copy>0)
            {
                long digit = copy % 10;
                sum += Power(digit, pow);
                copy /= 10;
            }
            return num == sum;
        }

        private static long DigitCount(long num)
        {
            // return (num + "").Length;
            int count = 0;
            while (num > 0)
            {
                count++;
                num /= 10;
            }
            return count;
        }

        private static long Power(long digit, long pow)
        {
            long res = 1;
            for(long i=1;i<=pow;i++)
            {
                res *= digit;
            }
            return res;
        }

        static void Main(string[] args)
        {
            Console.WriteLine($"Armstrong List : {ArmsList(1,100000)}");
        }
    }
}
