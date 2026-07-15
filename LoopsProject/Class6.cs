using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsProject
{
    internal class Class6
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number : ");
            int num = int.Parse(Console.ReadLine());
            int start = 1;
            int end = num;
            int sum = 0;
            while (start <= end)
            {
                //Console.WriteLine($"start --> {start}");
                sum +=  start;
                start++;
            }
            Console.WriteLine($"Sum of {num} numbers is : {sum}");
        }
    }
}
