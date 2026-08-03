using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserDefinedMethods
{

    // IN keyword can be used to provide input parameters 
    // out keyword can be used to get the out put parameter
    internal class Class4
    {
        public static int AriOperations( int a,  int b, out int sum, out int sub,out int mul)
        {
            sum = a + b;
            sub = a - b;
            mul = b - a;
            return a / b;
        }
        static void Main(string[] args)
        {
            Console.WriteLine($"Quo : {AriOperations(5,2,out int s,out int d,out int m)} sum :{s} sub = {d}  Mul = {m}");
        }
    }
}
