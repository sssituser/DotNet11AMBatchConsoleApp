using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsProject
{
    internal class Class11
    {
        static void Main(string[] args)
        {
            HashSet<int> hs = new HashSet<int>() { 3,1,4,2,5,5,3};
            foreach (var item in hs)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Hash Set elements  afer sorting ");
            foreach (var item in hs.OrderBy(x=>x))
            {
                Console.WriteLine(item);
            }
        }
    }
}
