using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsProject
{
    internal class Class9
    {
        static void Main(string[] args)
        {
            Stack<int> s = new Stack<int>();
            s.Push(3);
            s.Push(1);
            s.Push(2);
            s.Push(5);
            s.Push(4);
            Console.WriteLine("==================Stack Elements are==============");
            foreach (var item in s)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("=====================Stack Elements After Sorting===========");
            foreach (var item in s.OrderBy(x=>x))
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("=====================Stack Elements After Sorting===========");
            foreach (var item in s.OrderByDescending(x => x))
            {
                Console.WriteLine(item);
            }
        }
    }
}
