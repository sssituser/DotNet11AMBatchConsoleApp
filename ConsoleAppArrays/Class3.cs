using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppArrays
{
    internal class Class3
    {
        static void Main(string[] args)
        {
            int[] a = new int[5];
            Console.WriteLine("Enter Array elements");
            for (int i = 0; i < a.Length; i++) 
            {
                a[i]=int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Array elements are");
            foreach (var item in a)
            {
                Console.WriteLine(item);
            }
        }
    }
}
