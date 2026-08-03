using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserDefinedMethods
{
    // static method can be called using class Name
    // non static method can be using object
    // How to create an objec for the class
    //   syx : cration of object  : new ClassName() or   ClassName x = new ClassName();
    internal class Class6
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number : ");
            ulong num = ulong.Parse(Console.ReadLine());
            Class3 p = new Class3();
            if(p.IsStrong(num))
            {
                Console.WriteLine($"{num} is a Strong number");
            }
            else
            {
                Console.WriteLine($"{num} is not a Strong number");
            }


            if(new Class3().IsStrong(456))
            {
                Console.WriteLine($"456 is a Strong number");
            }
            else
            {
                Console.WriteLine($"456 is not a Strong number");
            }
        }
    }
}
