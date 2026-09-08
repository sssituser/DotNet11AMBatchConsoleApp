using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsProject
{
    internal class Class4
    {
        static void Main(string[] args)
        {
            ArrayList alist = new ArrayList() { 10,40,50,20,30};
            Console.WriteLine("Array List Elements are");
            foreach (var item in alist)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Displaying the elements using index");
            Console.WriteLine(alist[0]);
            Console.WriteLine(alist[1]);
            Console.WriteLine(alist[2]);
            Console.WriteLine(alist[3]);
            Console.WriteLine(alist[4]);
        }
    }
}
