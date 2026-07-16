using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatements
{
    internal class Class11
    {
        static void Main(string[] args)
        {
            int[] nums = {  34, 56, 78, 90, 12, 34,45,67,89,34,58,78 };
            Console.WriteLine("Array elments are");
            foreach (var item in nums)
            {
                Console.Write(item+" ");
            }
            Console.WriteLine();
        }
    }
}
