using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsProject
{
    internal class Class13
    {
        static void Main(string[] args)
        {
            SortedSet<Student> hs = new SortedSet<Student>()
            {

                new Student(111,"abc",500),
                new Student(109,"lmn",550),
                new Student(112,"pqr",450),
                new Student(110,"def",570),
            };
            Console.WriteLine("Student Set is");
            foreach (var item in hs)
            {
                Console.WriteLine(item);
            }
        }
    }
}
