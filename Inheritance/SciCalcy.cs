using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    internal class SciCalcy : Calcy
    {
        public void Sine(int val)
        {
            Console.WriteLine(Math.Sin(val));
        }
        public void Cos(int val)
        {
            Console.WriteLine(Math.Cos(val));
        }
    }
}
