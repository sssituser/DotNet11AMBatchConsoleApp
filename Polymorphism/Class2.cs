using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class OperOver
    {
        int a, b;
        public void ReadValues(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public void ShowValues()
        {
            Console.WriteLine($"a = {a}\tb = {b}");
        }
        public static OperOver operator+( OperOver left, OperOver right)
        {
            OperOver res = new OperOver();
            res.a = left.a + right.a;
            res.b = left.b + right.b;
            return res;
        }
    }
    internal class Class2
    {
        static void Main(string[] args)
        {
            Console.WriteLine(10+2);
            Console.WriteLine("kiran " + "Raj");
            Console.WriteLine(5.6+6.7);
            Console.WriteLine("===========================P Object=======================");
            OperOver p = new OperOver();
            p.ReadValues(5, 6);
            p.ShowValues();
            Console.WriteLine("===========================Q Object=======================");
            OperOver q = new OperOver();
            q.ReadValues(7, 8);
            q.ShowValues();
            Console.WriteLine("===========================R Object=======================");
            OperOver r = new OperOver();
            r = p + q;
            r.ShowValues();



        }
    }
}
