using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Mover
    {
        public static void Show(int val)
        {
            Console.WriteLine(val);
        }
        public static void Show(double val)
        {
            Console.WriteLine(val);
        }
        public static void Show(string val)
        {
            Console.WriteLine(val);
        }
        public static void Show(decimal val)
        {
            Console.WriteLine(val);
        }
        public void Display(int val)
        {
            Console.WriteLine(val);
        }
        public void Display(string val)
        {
            Console.WriteLine(val);
        }
        public void Display(bool val)
        {
            Console.WriteLine(val);
        }
         public void Display(double val)
        {
            Console.WriteLine(val);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Mover.Show("Hi");
            Mover.Show(10);
            Mover.Show(5.6);
            Mover.Show(7.8m);

            Mover p = new Mover();
            p.Display(true);
            p.Display("abc");
            p.Display(5);
            p.Display(5.6);
        }
    }
}
