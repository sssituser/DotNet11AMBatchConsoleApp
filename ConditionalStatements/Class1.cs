using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatements
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            Console.Write("Enter num1 : ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter num2 : ");
            int num2 = int.Parse(Console.ReadLine());
            Console.Write("Enter num3 : ");
            int num3 = int.Parse(Console.ReadLine());
            Console.Write("Enter num4 : ");
            int num4 = int.Parse(Console.ReadLine());
            int max = num1;
            if (max < num2)
            {
                max = num2;
            }
            if (max < num3)
            {
                max = num3;
            }
            if (max < num4)
            {
                max = num4;
            }
            Console.WriteLine($"Maximum Number is :{max}");
        }
    }
}
