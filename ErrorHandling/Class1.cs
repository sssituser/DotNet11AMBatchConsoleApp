using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorHandling
{
    internal class Class1
    {
        public static void Main()
        {
            while (true)
            {
                try
                {
                    Console.Write("Enter Name : ");
                    string name = Console.ReadLine();
                    Console.Write("Enter Age : ");
                    double age = double.Parse(Console.ReadLine());
                    if (age < 0 || age >= 120)
                    {
                        throw new InvalidAgeException("Age can't be less than zero or not greater than 119");
                    }
                    Console.Write("Enter Subject - 1 Marks : ");
                    int marks = int.Parse(Console.ReadLine());
                    if (marks < 0 || marks > 100)
                    {
                        throw new InvalidMarksException("Marks Can't be less than 0 Or greter than 100");
                    }
                    Console.WriteLine($"Name\t:\t{name}\nAge\t:\t{age}\nMarks\t:\t{marks} ");

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
