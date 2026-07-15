using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsProject
{
    internal class Class5
    {
        static void Main(string[] args)
        {
            int start = 1;
            int end = 10;
            while (start <= end)
            {
                Console.WriteLine(start*start);
                start++;
            }
        }
    }
}
