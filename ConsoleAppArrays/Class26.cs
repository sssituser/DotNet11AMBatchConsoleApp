using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsProject
{
    internal class Class26
    {
        static void Main(string[] args)
        {
            int[] a = { 555,666,777 };
            string[] names = { "kiran","Raj","Ravi","Jacinitha"};

            Console.WriteLine("==========Integer elements are================");
            foreach(int i in a)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("================Names in the given array============");
            foreach(string s in names)
            {
                Console.WriteLine(s);
            }
        }
    }
}
