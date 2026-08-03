using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserDefinedMethods
{
    //List of Strong Numbers ?
    // What is  a strong numer 145  => 1!+4!+5!=> 1+24+120=>145
    // Need generate strong numbers from starting and ending values.
    // AM :public static
    // MN : StrongList / StongsNums
    // PM : start and end values
    // RT : string
    internal class Class3
    {
        public static string StrongList(ulong start,ulong end)
        {
            string res = string.Empty;
            for(ulong i = start; i <= end; i++)
            {
                if (new Class3().IsStrong(i))
                {
                    res += i + ",";
                }
            }
            return res.Substring(0, res.Length - 1) + ".";
        }

        public  bool IsStrong(ulong num)
        {
            ulong sum = 0;
            ulong copy = num;
            while (num > 0)
            {
                ulong ld = num % 10;
                sum += Factorial(ld);
                num /= 10;
            }
            return sum == copy;
        }

        private static ulong Factorial(ulong num)
        {

            ulong res = 1;
            for(ulong i = 1; i <= num; i++)
            {
                res = res * i;
            }
            return res;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(StrongList(1,10000000));
        }
    }
}
