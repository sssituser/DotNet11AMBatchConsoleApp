using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
namespace ConsoleAppAsnchronousPrograming
{
    internal class Class4
    {
        static void Main (string[] args)
        {
            Type t = typeof (Console);
            Console.WriteLine($"Methods : {t.GetMethods().Count()}");
            Console.WriteLine($"Properties : {t.GetProperties().Count()}");
            Console.WriteLine($"Construtors : {t.GetConstructors().Count()}");
            Console.WriteLine($"ClassName : {t.Name} Its Namespace : {t.Namespace}");

            
        }
    }
}
