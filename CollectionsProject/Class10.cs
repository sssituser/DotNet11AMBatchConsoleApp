using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsProject
{
    internal class Class10
    {
        static void Main(string[] args)
        {
            HashSet<Student> hs= new HashSet<Student>()
            {

                new Student(111,"abc",500),
                new Student(109,"lmn",550),
                new Student(112,"pqr",450),
                new Student(110,"def",570),
            };

            Console.WriteLine("Student Information After soring with id");
            foreach (var item in hs.OrderBy(x=>x.StudentId))
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Student Information After soring with Name");
            foreach (var item in hs.OrderBy(x => x.StudentName))
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Student Information After soring with Name");
            foreach (var item in hs.OrderBy(x => x.Marks))
            {
                Console.WriteLine(item);
            }


        }
    }
}
