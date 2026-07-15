using System;
using System.Linq;

namespace LoopsProject
{
    internal class Class29
    {
        static void Main(string[] args)
        {
            int[] a = {4,2,1,6,7,8,5,3 };
            Console.WriteLine("Array elements are");
            foreach(int i in a)
            {
                Console.Write($"{i} ");
            }

            Console.WriteLine("\nArray elements in Ascending oreder");
            var ascelemnts = a.OrderBy(x=>x).ToArray();
            foreach (int i in ascelemnts)
            {
                Console.Write($"{i} ");
            }

            Console.WriteLine("\nArray elements in Descending oreder");
            var descelemnts = a.OrderByDescending(x => x).ToArray();
            foreach (int i in descelemnts)
            {
                Console.Write($"{i} ");
            }
        }
    }
}
