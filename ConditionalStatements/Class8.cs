using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatements
{
  /*
    jumping statement

    Label:


    goto Label;
   
   
   */
    internal class Class8
    {
        static void Main(string[] args)
        {
            Console.Write("Enter num1 : ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter num2 : ");
            int num2 = int.Parse(Console.ReadLine());
             Menu:
            Console.Write("1.ADD   2.SUB   3.MUL   4.DIV   5.Rem   Enter Choice : ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine($"Sum :{num1 + num2}");
                    goto Menu;

                case 2:
                    Console.WriteLine($"Sub : {num1 - num2}");
                    goto Menu;
                case 3:
                    Console.WriteLine($"Mul : {num1 * num2}");
                    goto Menu;
                case 4:
                    Console.WriteLine($"Quo : {num1 / num2}");
                    goto Menu;
                case 5:
                    Console.WriteLine($"Rem : {num1 % num2}");
                    goto Menu;
                default:
                    Console.WriteLine("Invalid choice......");
                    break;

            }
        }
    }
}
