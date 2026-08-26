using System;
using System.IO;

namespace FileHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter File Name : ");
            string fname = Console.ReadLine();
            FileInfo finfo = new FileInfo(fname);
            if (finfo.Exists)
            {
                Console.WriteLine("File with the same exists try with other Name : ");
            }
            else
            {
               finfo.Create();
                Console.WriteLine("File Created");  
                
            }
        }
    }
}
