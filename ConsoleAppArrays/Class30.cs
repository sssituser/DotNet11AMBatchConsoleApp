using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsProject
{
    internal class Class30
    {
        static void Main(string[] args)
        {
            int[] array = { 34, 56, 78,78, 90, 90,33, 34, 44, 55, 77, 12, 13, 15, 18 };

            Console.WriteLine("Array elemetns are");
            foreach (var item in array)
            {
                Console.Write($"{item}  ");
            }

            Console.WriteLine("\nArray Duplicate elemetns are");
            var dups = array.GroupBy(x => x).Where(x => x.Count() == 2).Select(g => g.Key).ToArray();
            foreach (var item in dups)
            {
                Console.Write($"{item} ");
            }


        }
    }
}
