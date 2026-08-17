
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    // IS-A is Relation
    class Test
    {
        public virtual void Show()
        {
            Console.WriteLine("Hi this is Show method from Test class");
        }
        public void Display()
        {
            Console.WriteLine("Hi this is Display method from class Test");
        }
    }
    class Sample : Test
    {
        public override void Show()
        {
            Console.WriteLine("Hi this is Show method from class Sample");
        }
        public void Hi()
        {
            Console.WriteLine("Hi this is Hi Method from class Sample");
        }
    }
    internal class MethodOverridngExample
    {
        static void Main(string[] args)
        {
            Test t;
            t = new Sample();
            t.Show();
            t = new Test();
            t.Show();
           
        }
    }
}
