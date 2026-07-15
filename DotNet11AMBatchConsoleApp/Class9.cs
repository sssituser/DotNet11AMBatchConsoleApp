using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet11AMBatchConsoleApp
{
    internal class Class9
    {
        static void Main(string[] args)
        {
            int num1 = 8;
            int num2 = 4;

            Console.WriteLine($"num1 : {num1}   num2 : {num2}");
            Console.WriteLine($"{num1} + {num2} : {num1+num2}\n{num1} - {num2} : {num1 - num2}\n{num1} * {num2} : {num1 * num2}\n{num1} / {num2} : {num1 / num2}\n{num1} % {num2} : {num1 % num2}");

        }
    }
}
