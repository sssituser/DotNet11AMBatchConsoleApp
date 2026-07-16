using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsProject
{
    internal class Class31
    {
        static void Main(string[] args)
        {
            int[] nums = { 34, 56, 78, 90, 12, 34, 45, 67, 89, 34, 58, 78,90 };
            Console.WriteLine("Array elments are");
            foreach (var item in nums)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            var dups = nums.GroupBy(x => x).Where(x => x.Count() >= 2).Select(g => g.Key).ToArray();
            Console.WriteLine("Dupliates elements in the array");
            foreach (var item in dups)
            {
                Console.Write(item+" ");
            }
            Console.WriteLine();
            Console.WriteLine("Unique elements in the array");
            var uniques = nums.GroupBy(x=>x).Where(x=>x.Count()==1).Select(g=> g.Key).ToArray();

            foreach (var item in uniques)
            {
                Console.Write(item+" ");
            }
            Console.WriteLine();
            var rmdups = nums.Distinct().ToArray();

            Console.WriteLine("After Removing duplicate elements");
            foreach (var item in rmdups)
            {

                Console.Write(item+" ");
            }


        }
    }
}
