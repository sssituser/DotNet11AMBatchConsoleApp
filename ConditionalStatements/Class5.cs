using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatements
{
    internal class Class5
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
            if(sub1<35 || sub2 < 35 || sub3 < 35)  // 34<35||50<35||40<35
            {
                Console.WriteLine("Student Failed");

            }else if (per >= 60)
            {
                Console.WriteLine("Student Passed in A Grade  or First Division");
            }else if (per >= 50)
            {
                Console.WriteLine("Student Passed in B Grade or Second Class");
            }
            else
            {
                Console.WriteLine("Student Passed in C Grade or Third Class");
            }


        }
    }
}
