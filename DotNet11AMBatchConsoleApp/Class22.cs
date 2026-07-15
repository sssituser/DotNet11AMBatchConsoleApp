using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet11AMBatchConsoleApp
{
    internal class Class22
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Subject - 1 Marks :");
            int sub1 =  int.Parse(Console.ReadLine()); // s1 = 30
            Console.Write("Enter Subject - 2 Marks :");
            int sub2 = int.Parse(Console.ReadLine());  // s2 = 50
            Console.Write("Enter Subject - 3 Marks :");
            int sub3 = int.Parse(Console.ReadLine());  // s3 = 60
            string res = sub1 > 34 && sub2 > 34 && sub3 > 34 ? "Hello" : "Chello";
            Console.WriteLine($"You got {res}");
        }
    }
}
