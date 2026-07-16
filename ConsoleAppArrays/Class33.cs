using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsProject
{
    internal class Class33
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string : ");
            string res = Console.ReadLine();
            Console.WriteLine($"Given String : {res}");

            var fre = res.OrderBy(x=> x).GroupBy(x=>x).ToDictionary(x=>x.Key,x=>x.Count());
            foreach (var item in fre)
            {
                Console.WriteLine(item);
            }


        }
    }
}
