using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsProject
{
    internal class Class14
    {
        static void Main(string[] args)
        {
            SortedSet<Studentt> hs = new SortedSet<Studentt>()
            {

                new Studentt(111,"abc",500),
                new Studentt(109,"lmn",550),
                new Studentt(112,"pqr",450),
                new Studentt(110,"def",570),
            };
            Console.WriteLine("Student Set is");
            foreach (var item in hs)
            {
                Console.WriteLine(item);
            }
        }
    }
}
