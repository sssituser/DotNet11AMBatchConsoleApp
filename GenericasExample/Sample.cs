using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericasExample
{
    internal class Sample<T>
    {
        public void Show(T a,T b)
        {
            Console.WriteLine($"a  = {a}\tb = {b}");
        }
        public static void Display(T a,T b)
        {
            Console.WriteLine($"a  = {a}\tb = {b}");
        }
    }
}
