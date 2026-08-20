using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.Arm;
using System.Text;

namespace Inheritance
{
    internal class Class8
    {
        public static void Main()
        {
            DD p = new DD();
            p.ReadNums();
            p.WriteNums();
            p.Sum();
            p.Sub();
            p.Mul();
            p.Div();
            p.Rem();
        }
    }
}
