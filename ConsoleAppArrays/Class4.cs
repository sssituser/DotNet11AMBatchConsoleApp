using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppArrays
{
    internal class Class4
    {
        static void Main(string[] args)
        {
            int[] a = new int[3]; 
            for(int i = 0; i < a.Length; i++) 
            {
                Console.Write($"Enter {i+1} Element : "); //
                a[i] = int.Parse(Console.ReadLine());
            }
        }
    }
}
