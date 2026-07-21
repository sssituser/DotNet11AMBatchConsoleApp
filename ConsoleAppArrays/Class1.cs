using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppArrays
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            int[,] a = new int[2, 3] { { 11, 56, 78 }, { 90, 98, 97 } };
            Console.WriteLine(a[0,0]);
            Console.WriteLine(a[0,1]);
            Console.WriteLine(a[0,2]);
            Console.WriteLine(a[1,0]);
            Console.WriteLine(a[1,1]);
            Console.WriteLine(a[1,2]);

        }
    }
}
