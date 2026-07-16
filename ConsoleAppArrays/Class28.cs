using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsProject
{
    internal class Class28
    {
        static void Main(string[] args)
        {
            //Arrays with Linq

            int[] array = { 34, 56, 78, 90, 33, 34,44, 55, 77, 12, 13, 15, 18 };

            Console.WriteLine($"Max value : {array.Max()}");
            Console.WriteLine($"Min Value : {array.Min()}");
            Console.WriteLine($"Sum of the Array elmemnts : {array.Sum()}");
            Console.WriteLine($"Avg of the Array elmemnts : {array.Average()}");
            Console.WriteLine("Array elments are");
            foreach(int i in array)
            {
                Console.Write($"{i}  ");
            }

            Console.WriteLine();
            var evens = array.Where(x=>x%2==0).ToArray();
            Console.WriteLine("Even elements in the given array");
            foreach(int i in evens)
            {
                Console.Write($"{i}   ");
            }















        }
    }
}
