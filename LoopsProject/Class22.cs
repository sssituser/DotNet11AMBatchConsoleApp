using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsProject
{
    // Write a program to find the ASCII Sum of the given name;
    internal class Class22
    {
        // name = "abcd" 97+98+99+100
        static void Main(string[] args)
        {
            Console.Write("Enter Name : ");
            string name = Console.ReadLine();
            int sum = 0;
            foreach(char ch in name)
            {
                sum += (int)ch;
            }
            Console.WriteLine($"Sum of ASCII Values of the Given name : {sum}");
        }
    }
}
