using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatements
{
    internal class Class4
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Age  : ");
            int age = int.Parse(Console.ReadLine()); // 22  19  16
            if (age > 17) // 22>17-T  19>17-T 16>17-F
            {
                if (age < 21) // 22<21-F  19<21-T
                {
                    Console.WriteLine("Your Major ,Eligible for Vote But Not For Marriage ");
                }
                else
                {
                    Console.WriteLine("Your Major , Eligible for Vote also for Marriage");
                }
            }
            else
            {
                Console.WriteLine("Your Minor");
            }
        }
    }
}
