using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsProject
{
    internal class Class16
    {
        static void Main(string[] args)
        {
            int start = 1;
            int end = 10;
            int num = 6;
            do
            {
                Console.WriteLine($"{num} x {start} = {num * start}");
                start++;
            } while (start <= end);
        }
    }
}
