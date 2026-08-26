using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling
{
    internal class Class3
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Folder Name : ");
            string foname = Console.ReadLine();

            DirectoryInfo dinfo = new DirectoryInfo(foname);
            if (dinfo.Exists)
            {
                dinfo.Delete();
                Console.WriteLine("Folder deleted .....");
            }
            else
            {
              
                Console.WriteLine($"{foname} Does't Exists....");
            }
        }
    }
}
