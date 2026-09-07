using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnehaSystem
{
    public class SnehaConsole
    {
        public static void WriteLine(string val)
        {
            Console.WriteLine(val);
        }
        public static void Write(string val)
        {
            Console.Write(val);
        }
        public static  int ReadInt()
        {
            return int.Parse(Console.ReadLine());
        }
        public static string ReadLine()
        {
            return Console.ReadLine();
        }
        public static double ReadDouble()
        {
            return double.Parse(Console.ReadLine());
        }
    }
}
