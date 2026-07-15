using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DotNet11AMBatchConsoleApp
{
    internal class Class10
    {
        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 2;
            Console.WriteLine($"num1 : {num1}    num2 : {num2}");
            Console.WriteLine($"{num1} > {num2} : {num1>num2}");
        }
    }
}
