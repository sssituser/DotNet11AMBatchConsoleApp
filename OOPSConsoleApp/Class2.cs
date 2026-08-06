using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConsoleApp
{

    // static members can be accessed using classname
    // non static memberes can be accessed using object
    
    internal class Class2
    {
        static void Main(string[] args)
        {

            
            Console.WriteLine(Student.CollegeName); // Read
            
            
            Student s1 = new Student();
            s1.StudentId = 111;
            s1.StudentName = "kiran";
            s1.StudentEmail = "kiran@gmail.com"; // Write 

            Console.WriteLine($"Student Id :{s1.StudentId}");
            Console.WriteLine($"Student Name :{s1.StudentName}");
            Console.WriteLine($"Student Email :{s1.StudentEmail}"); //Read

        }
    }
}
