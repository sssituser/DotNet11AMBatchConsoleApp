using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsProject
{
    internal class Class7
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 9,6,4,7,5,1,3,2};
            Console.WriteLine("LIst Elements");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            list.Sort();
            list.Reverse();
            Console.WriteLine("LIst Elements after sorting");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

        }
    }
}
