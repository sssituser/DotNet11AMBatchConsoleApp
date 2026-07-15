using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet11AMBatchConsoleApp
{
    internal class Class8
    {
        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 2;
            Console.WriteLine($"num1 = {num1}\tnum2 = {num2}");
            Console.WriteLine($"sum : {num1+num2}");
            Console.WriteLine($"sub : {num1-num2}");
            Console.WriteLine($"mul : {num1*num2}");
            Console.WriteLine($"quo : {num1/num2}");
            Console.WriteLine($"rem : {num1%num2}");
        }
    }
}
