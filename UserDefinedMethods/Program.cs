using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserDefinedMethods
{
    internal class Program
    {
        public static int Sum(int num1,int num2)  // Defining the method
        {
          return  num1+num2;
        }
        public static int Sub(int num1, int num2)  // Defining the method
        {
            return num1 - num2;
        }
        public static int Mul(int num1, int num2)  // Defining the method
        {
            return num1 * num2;
        }
        public static int Div(int num1, int num2)  // Defining the method
        {
            return num1 / num2;
        }


        static void Main(string[] args)
        {
            int res = Sum(5,2);
            Console.WriteLine(res);

            Console.WriteLine(Sum(5,6)); // 11
            Console.WriteLine(Sub(5,6)); // -1
            Console.WriteLine(Mul(5,6));  // 30
            Console.WriteLine(Div(5,6)); // 0
        }
    }
}
