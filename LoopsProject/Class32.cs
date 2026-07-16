using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsProject
{
    internal class Class32
    {
        static void Main(string[] args)
        {
            // find the frequency of the numbers in the given array or characters in the given string
            int[] nums = { 34, 56, 78, 90, 12, 34, 45, 67, 89, 34, 58, 78, 90 };

            Console.WriteLine("========Array elememts are============");
            foreach (var item in nums)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine("\nFrequency of the given elements in the array");
            var freqeny = nums.OrderBy(x=>x).GroupBy(x => x).ToDictionary(x => x.Key, x => x.Count());

            foreach (var item in freqeny)
            {
                Console.WriteLine($"{item}");   
            }

        }
    }
}
