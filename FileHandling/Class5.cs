using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling
{
    internal class Class5
    {
        static void Main(string[] args)
        {
            Console.Write("Enter File Name : ");
            string finame = Console.ReadLine();
            FileInfo finfo=new FileInfo(finame);
            if (finfo.Exists)
            {
                FileStream fs = new FileStream(finame,FileMode.Append,FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                Console.WriteLine("=================Enter Your Info===================");
                string info = string.Empty;
                while ((info = Console.ReadLine()) != string.Empty)
                {
                    sw.WriteLine(info);
                }
                sw.Close();
                Console.WriteLine("File Appended Successfully......");
            }
            else
            {
                Console.WriteLine("==========Created File Successfully======================");
                StreamWriter sw = new StreamWriter(finame);
                Console.WriteLine("=================Enter Your Info===================");
                string info = string.Empty;

                while ((info = Console.ReadLine()) != string.Empty)
                {
                    sw.WriteLine(info);
                }
                sw.Close();
            }
        }
    }
}
