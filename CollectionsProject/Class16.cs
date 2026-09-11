using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsProject
{
    internal class Class16
    {
        static void Main (string[] args)
        {
            SortedList<int, string> students = new SortedList<int, string>();
            students.Add(108, "lmn");
            students.Add(107, "pqr");
            students.Add(109, "abc");
            students.Add(106, "def");
            students.Add(111, "ijk");
            students.Add(110, "xyz");
            //students.Add(110, "xyz");
            Console.WriteLine("Keys in the Sorted List");
            foreach (var item in students.Keys)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Values in the Sorted List");
            foreach (var item in students.Values)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("=========================keyvalue pairs===============");
            foreach (var item in students.Keys)
            {
                Console.WriteLine($"{item}\t{students[item]}");
            }

            Console.WriteLine($"Total Element in the Sorted List{students.Count}");
            for (int i = 0; i < students.Count; i++)
            {
                Console.WriteLine($"{i}   {students.ElementAt(i)}");
            }
            students.RemoveAt(0);
            Console.WriteLine("One element deleted");
            Console.WriteLine($"Total Element in the Sorted List{students.Count}");
            for (int i = 0; i < students.Count; i++)
            {
                Console.WriteLine($"{i}   {students.ElementAt(i)}");
            }
        }
    }
}
