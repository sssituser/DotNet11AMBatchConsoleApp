using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsProject
{
    internal class Class17
    {
        static void Main (string[] args)
        {
            SortedList<Studentt, Employee> slist = new SortedList<Studentt, Employee>();
            slist.Add(new Studentt(111, "abc", 500),new Employee(111,"abc",60000));
            Console.WriteLine(slist.ElementAt(0));
           
           
        }
    }
}
