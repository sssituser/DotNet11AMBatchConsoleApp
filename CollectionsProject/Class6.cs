using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsProject
{
    internal class Class6
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(new Employee(109, "bbb", 60000));
            arrayList.Add(new Employee(108, "kkk", 70000));
            arrayList.Add(new Employee(107, "lll", 50000));
            arrayList.Add(new Employee(105, "mmm", 40000));
            arrayList.Add(new Employee(106, "nnn", 30000));
            arrayList.Add(new Employee(110, "uuu", 90000));
            Console.WriteLine("Employees Information");
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            arrayList.Sort(new ArrayListEmployeeIDComparer());
            Console.WriteLine("After sorting the employees");
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
