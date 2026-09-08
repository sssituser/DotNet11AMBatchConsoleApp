using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsProject
{
    internal class Class3
    {
        static void Main(string[] args)
        {
            ArrayList li = new ArrayList();
            li.Add(10);
            li.Add(20);
            li.Add(30);
            li.Add(50);
            li.Add(40);
            li.Add(20);
            li.Add(60);
            Console.WriteLine("Arraylist Items are");
            foreach (var item in li)
            {
                Console.WriteLine(item);
            }
            li.Remove(20);
            li.Sort();
            Console.WriteLine("Elements after sorting");
            foreach (var item in li)
            {
                Console.WriteLine(item);
            }

        }
    }
}
