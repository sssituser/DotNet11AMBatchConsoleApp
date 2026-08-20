using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Inheritance
{
    internal class AA
    {
        protected int a,b;
        public void ReadNums()
        {
            Console.Write("Enter a numbrer  ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Enter a numbrer ");
            b = int.Parse(Console.ReadLine());
        }
        public void WriteNums()
        {
            Console.WriteLine($"a = {a}\tb = {b}");
        }
    }
}
