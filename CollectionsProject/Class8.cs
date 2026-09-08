using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsProject
{
    internal class Class8
    {
        static void Main(string[] args)
        {
            List<Student> studList = new List<Student>() {
            new Student(109,"kiran",500),
            new Student(107,"arun",550),
            new Student(106,"raj",540),
            new Student(108,"jenita",570),
            new Student(105,"jecintha",570),
            new Student(104,"sirisha",600),
            
            };
            Console.WriteLine("STudents Information");
            foreach (var item in studList)
            {
                Console.WriteLine(item);
            }
            studList.Sort();
            Console.WriteLine("STudents Information after sorting");
            foreach (var item in studList)
            {
                Console.WriteLine(item);
            }

        }
    }
}
