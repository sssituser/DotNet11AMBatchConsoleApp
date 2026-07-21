using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppArrays
{
    internal class JaggedArray
    {
        static void Main(string[] args)
        {
            int[][] a = new int[3][];
            a[0] = new int[]{ 10, 20, 30 };
            a[1] = new int[] { 11, 23 };
            a[2] = new int[] { 22, 33, 44, 55, 66 };
            Console.WriteLine("====Jagged Array elements are=======");
            foreach (var array in a)
            {
                foreach(var i in array)
                {
                    Console.Write($"{i}\t");
                }
                Console.WriteLine();
            }


        }
    }
}
