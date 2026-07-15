using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet11AMBatchConsoleApp
{
    internal class Class21
    {
        static void Main(string[] args)
        {
            Console.Write("Enter  number-1 : ");
            int num1 = int.Parse(Console.ReadLine()); // num1 = 10
            Console.Write("Enter a number-2 : ");
            int num2 = int.Parse(Console.ReadLine()); //num2 = 20
            //Console.WriteLine(num1>num2? "Hi":"Bye");
            string res = num1 > num2 ? "Hi" : "Bye";
            Console.WriteLine(res);

            int result = num1 > num2 ? num1 : num2;
            Console.WriteLine(result);

        }
    }
}
