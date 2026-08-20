using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    internal class DD : AA, BB, CC
    {
        public void Sum()
        {
            Console.WriteLine($"Sum : {a+b}");
        }
        public void Sub()
        {
            Console.WriteLine($"Sub : {a - b}");
        }
        public void Mul()
        {
            Console.WriteLine($"Mul : {a * b}");
        }
        public void Div()
        {
            Console.WriteLine($"Quo : {a / b}");
        }
        public void Rem()
        {
            Console.WriteLine($"Rem : {a%b}");
        }

    }
}
