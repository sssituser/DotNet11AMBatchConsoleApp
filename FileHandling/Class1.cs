using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            Console.Write("Enter File Name : ");
            string fname = Console.ReadLine();
            FileInfo finfo = new FileInfo(fname);
            if (finfo.Exists)
            {
                finfo.Delete();
                Console.WriteLine($"{fname} Deleted Successfully");
            }
            else
            {

                Console.WriteLine("File Doest't Exist");
            }
        }
    }
}
