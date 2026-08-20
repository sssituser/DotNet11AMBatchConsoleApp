using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{

    /*
     * public  : pubilc members of a class can be accessed in side the class and out side of the class, and outside of the namesapce
     * internal : internal members of class can be acccesse in side the clas and out side of the class, and can't be outside of the namespace
     * protected :protected members can be accessed with in the class but not out side of the class , but it can be inherted
     * private : private can be accessed with in the class but not side, we can not Inherit
     *
     *
     * If class declared with Sealed Keyword, then class is said to be sealed class,
     * Sealed class is a class which can't be inherited.
     *
     */
    class A
    {
      protected  int num1;
      protected  int num2;
        public void ReadNums()
        {
            Console.Write("Enter num1 : ");
             num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter num2 : ");
             num2 = int.Parse(Console.ReadLine());

        }
        public void ShowNums()
        {
            Console.WriteLine($"num1 = {num1}\tnum2 = {num2}");
        }
    }

    class B : A
    {
        public void Sum()
        {
            Console.WriteLine($"Sum is : {num1+num2}");
        }
        public void Sub()
        {
            Console.WriteLine($"Sub is : {num1-num2}");
        }
    }

    class C : B
    {
        public void Mul()
        {
            Console.WriteLine($"Mul is : {num1*num2}");
        }
        public void Div()
        {
            Console.WriteLine($"Quo is : {num1/num2}");
        }
    }

    internal class Class6
    {
        public static void Main()
        {
            C p = new C();
            p.ReadNums();
            p.ShowNums();
            p.Sum();
            p.Sub();
            p.Mul();
            p.Div();
        }
    }
}
