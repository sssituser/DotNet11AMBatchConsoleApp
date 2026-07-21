using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Name : "); // Arun
            string name = Console.ReadLine(); // name = "Arun"
            string rev = string.Empty;
            for(int i = name.Length - 1; i >= 0; i--)
            {
                rev = rev + name[i];// rev =nurA;
            }
            Console.WriteLine($"Reverse string is : {rev}");

        }
    }
}
