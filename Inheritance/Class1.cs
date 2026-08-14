using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.Arm;
using System.Text;

namespace Inheritance
{
    internal class Class1
    {
        public static void Main(string[] args)
        {
            Calcy cal = new Calcy();
            cal.Sum(5, 2);
            cal.Sub(4, 2);
            cal.Mul(5, 2);
            cal.Div(7, 3);
        }
    }
}
