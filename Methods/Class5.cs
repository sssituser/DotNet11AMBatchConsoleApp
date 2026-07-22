using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Class5
    {
        static void Main(string[] args)
        {
            string res = "arunkumar,";
            Console.WriteLine($"res = {res.Substring(0)}");
            Console.WriteLine($"res = {res.Substring(1)}");
            Console.WriteLine($"res = {res.Substring(2)}");
            Console.WriteLine($"res = {res.Substring(3)}");
            Console.WriteLine($"res = {res.Substring(4)}");
            Console.WriteLine($"res = {res.Substring(0,3)}");
            Console.WriteLine($"res = {res.Substring(1,3)}");
            Console.WriteLine(res.Length);
            Console.WriteLine($"res = {res.Substring(0,res.Length)}");
            Console.WriteLine($"res = {res.Substring(0,res.Length-1)}");
            Console.WriteLine($"res = {res.Substring(0,res.Length-1)+"."}");
           

        }
    }
}
