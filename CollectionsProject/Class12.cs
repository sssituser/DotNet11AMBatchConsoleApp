using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsProject
{
    internal class Class12
    {
        static void Main(string[] args)
        {
            SortedSet<int> set = new SortedSet<int>() { 56,23,45,12,78,12};
            Console.WriteLine("===================Set Elements are=============");
            foreach (var item in set)
            {
                Console.WriteLine(item);
            }

        }
    }
}
