using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorHandling
{
    internal class Class2
    {
        public static int Sum(int num)
        {
            if (num == 0)
            {
                return 0;
            }
            return num + Sum(num - 1);
        }
        static void Main()
        {
            Console.WriteLine(Sum(5));
        }
    }
}
