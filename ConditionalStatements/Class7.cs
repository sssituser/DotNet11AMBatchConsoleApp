using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatements
{
    /*
     * switch(constant){
     * case const1:
     *      stmt1;
     *      break;
     * case const2:
     *      smts2;
     *      break;  // Break can stop the execution of the application
     *      ....
     *      ....
     *  default:
     *      ....
     *      break;
     * }
     */
    internal class Class7
    {
        static void Main(string[] args)
        {
            Console.Write("Enter num1 : ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter num2 : ");
            int num2 = int.Parse(Console.ReadLine());

            Console.Write("1.ADD   2.SUB   3.MUL   4.DIV   5.Rem   Enter Choice : ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine($"Sum :{num1+num2}");
                    break;
                case 2:
                    Console.WriteLine($"Sub : {num1-num2}");
                    break;
                case 3:
                    Console.WriteLine($"Mul : {num1*num2}");
                    break;
                case 4:
                    Console.WriteLine($"Quo : {num1/num2}");
                    break;
                case 5:
                    Console.WriteLine($"Rem : {num1%num2}");
                    break;
                default:
                    Console.WriteLine("Invalid choice......");
                    break;

            }
        }
    }
}
