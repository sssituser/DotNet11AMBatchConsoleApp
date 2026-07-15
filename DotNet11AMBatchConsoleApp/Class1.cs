using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet11AMBatchConsoleApp
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hi");
            Console.WriteLine(sizeof(byte));
            Console.WriteLine(sizeof(sbyte));
            Console.WriteLine(sizeof(short));
            Console.WriteLine(sizeof(int));

            Console.WriteLine(byte.MinValue);
            Console.WriteLine(byte.MaxValue);


            Console.WriteLine(sbyte.MinValue);
            Console.WriteLine(sbyte.MaxValue);

        }
    }
}
