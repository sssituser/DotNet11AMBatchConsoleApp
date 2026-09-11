using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsProject
{
    internal class Class18
    {/*
      Write a program to remove the duplicte values from the given array
      */
        static void Main (string[] args)
        {
            HashSet<int> set = new HashSet<int>();
            int[] array = { 33,1,45,33,44,55,1,33,45,33};
            Console.WriteLine("Array element are");
            foreach (var item in array)
            {
                Console.WriteLine(item);
                set.Add(item);
            }

            Console.WriteLine("Elements of the array after removing duplicates");
            foreach (var item in set)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Removing duplicate");
            foreach (var item in array.Distinct())
            {
                Console.WriteLine(item);
                
            }

        }
    }
}
