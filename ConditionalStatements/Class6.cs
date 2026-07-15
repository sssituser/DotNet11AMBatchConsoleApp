using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatements
{
    internal class Class6
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Subject - 1 Marks : ");
            int sub1 = int.Parse(Console.ReadLine());
            Console.Write("Enter Subject - 2 Marks : ");
            int sub2 = int.Parse(Console.ReadLine());
            Console.Write("Enter Subject - 3 Marks : ");
            int sub3 = int.Parse(Console.ReadLine());
            int total = sub1 + sub2 + sub3;
            int per = total / 3;
            if(sub1>34 && sub2>34 && sub3 > 34)
            {
                if (per >= 60)
                {
                    Console.WriteLine("First Division A Grade");
                }else if (per >= 50)
                {
                    Console.WriteLine("Second Division B Grade");
                }
                else
                {
                    Console.WriteLine("Third Division C Grade");
                }
            }
            else
            {
                Console.WriteLine("Failed");
            }

        }
    }
}
