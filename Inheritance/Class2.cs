using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    internal class Class2
    {
        public static void Main(string[] args)
        {
            SciCalcy s = new SciCalcy();
            s.Sine(90);
            s.Cos(0);
            s.Sum(4, 3);
            s.Sub(5, 2);
            s.Mul(5, 6);
            s.Div(6,3);
            
            s.ToString();
            s.GetType();
            s.GetHashCode();
        }
        
    }
}

// PM MN CN RT