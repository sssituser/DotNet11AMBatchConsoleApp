using System;
using System.IO;

namespace FileHandling
{
    internal class Class2
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Folder Name : ");
            string foname = Console.ReadLine();

            DirectoryInfo dinfo = new DirectoryInfo(foname);
            if (dinfo.Exists)
            {
                Console.WriteLine("Folder with SameName available");
            }
            else
            {
                dinfo.Create();
                Console.WriteLine($"{foname} Created Successfully....");
            }
        }
    }
}
