using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Class2
    {
        static void Main(string[] args)
        {
            string res = " "; // reference variable
            Console.WriteLine(string.IsNullOrEmpty(res));
            Console.WriteLine(string.IsNullOrWhiteSpace(res));
            string res1 = "abc", res2 = "123";
            Console.WriteLine(string.Concat(res1,res2));
            Console.WriteLine(string.Compare("a","b"));
            Console.WriteLine(string.Compare("a","z"));
            Console.WriteLine(string.Compare("b","a"));
            Console.WriteLine(string.Compare("a","a"));







        }
    }
}
