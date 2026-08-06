using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConsoleApp
{
    internal class Class9
    {
        static void Main(string[] args)
        {
            Studentt s1 = new Studentt();
            s1.StudentId = 111;
            s1.StudentName = "kiran";
            s1.Age = 120;
            Console.WriteLine($"Student Id   : {s1.StudentId}");
            Console.WriteLine($"Student Name : {s1.StudentName}");
            Console.WriteLine($"Student Age  : {s1.Age}");
        }
    }
}
