using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsProject
{
    internal class Class27
    {
        static void Main(string[] args)
        {
            int[] a = { 555, 666, 777 };
            string[] names = { "kiran", "Raj", "Ravi", "Jacinitha" };
            Console.WriteLine($"No of elements in a are :{a.Length}");
            Console.WriteLine($"No of names present in names are : {names.Length}");
            Console.WriteLine("======================Integer elements are===================");
            for (int i = 0; i < a.Length; i++) { 
                Console.WriteLine(a[i]); 
            }
            Console.WriteLine("======================String elements are===================");
            for (int i = 0; i < names.Length; i++)
            { 
                Console.WriteLine(names[i]); // 
            }

        }
    }
}
