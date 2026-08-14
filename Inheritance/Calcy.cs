using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    internal class Calcy
    {
        public void Sum(int a,int b)
        {
            Console.WriteLine($"Sum is : {a+b}");
        }
        public void Sub(int a, int b)
        {
            Console.WriteLine($"Sub is : {a - b}");
        }
        public void Mul(int a, int b)
        {
            Console.WriteLine($"Mul is : {a * b}");
        }
        public void Div(int a, int b)
        {
            Console.WriteLine($"Quo is : {a * b}");
        }
    }
}
