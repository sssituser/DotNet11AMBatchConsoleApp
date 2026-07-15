
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet11AMBatchConsoleApp
{
    internal class Class24
    {
        static void Main(string[] args)
        {
            
            Console.Write("Enter User Name : ");
            string uname = Console.ReadLine(); // "Admin"
            Console.Write("Enter Password : ");
            Console.ForegroundColor = ConsoleColor.Black;
            string password = Console.ReadLine(); // "1234"
            Console.ForegroundColor = ConsoleColor.White;
            string res = uname == "admin" && password == "1234" ? "Success" : "Failed";
            Console.WriteLine($"Your Login is : {res}");
            


        }
    }
}
