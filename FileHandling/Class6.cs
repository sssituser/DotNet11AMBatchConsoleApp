using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling
{
    internal class Class6
    {
        static void Main(string[] args)
        {
            Console.Write("Enter File Name : ");
            string finame = Console.ReadLine();
            StreamReader sr = new StreamReader(finame);
            Console.WriteLine("=========================Entered Information is ========================");
            Console.WriteLine(sr.ReadToEnd());
            sr.Close();
        }
    }
}
