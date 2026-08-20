using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorHandling
{ 
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.Write("Enter num1 : ");
                    int num1 = int.Parse(Console.ReadLine());
                    Console.Write("Enter num2 : ");
                    int num2 = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Quo : {num1 / num2}");
                }
                catch
                {
                    Console.WriteLine("Error Occured");
                }

            }
        }
    }
}
