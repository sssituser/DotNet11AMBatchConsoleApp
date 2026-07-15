using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet11AMBatchConsoleApp
{
    internal class Class25
    {
        static void Main(string[] args)
        {
            
            Console.Write("Enter User Name : ");
            string uname = Console.ReadLine();
            string res =   uname == string.Empty ? "Empty String" :  uname;
            Console.WriteLine($"Entred String is : {res}");

        }
    }
}
