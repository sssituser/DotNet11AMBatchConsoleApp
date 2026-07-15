using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Subject 1 Marks : ");
            int m1 = int.Parse(Console.ReadLine());// m1 = 30

            Console.Write("Enter Subject 2 Marks : ");
            int m2 = int.Parse(Console.ReadLine()); // m2 = 50

            Console.Write("Enter Subject 3 Marks : ");
            int m3 = int.Parse(Console.ReadLine()); // m3 = 60

            if(m1>34 && m2>34 && m3 > 34) //40>34 && 50>34 && 60>34  T && T && T
            {
                Console.WriteLine("You Got Passed"); // You Got Passed
            }

            if(m1<35 || m2<35 || m3 < 35) // 40<35  || 50<35 || 60<35  F||F||F => f
            {
                Console.WriteLine("You Got Failed");
            }

        }
    }
}
