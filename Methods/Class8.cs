using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Class8
    {
        static void Main(string[] args)
        {
            string[] array = {"lakshmi","vijay","sneha" };
            Console.WriteLine("Names in the Array");
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }

            Array.Reverse(array);

            Console.WriteLine("Names in the Array Reverse");
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }

            Array.Sort(array);

            Console.WriteLine("After Sorting in Ascending Names in the Array ");
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
            Array.Reverse(array);
            Console.WriteLine("After Sorting in Descending Names in the Array ");
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine(Array.IndexOf(array,"vijay"));
            Console.WriteLine(Array.IndexOf(array,"sneha"));
            Console.WriteLine(Array.IndexOf(array,"arun"));
        }
    }
}
