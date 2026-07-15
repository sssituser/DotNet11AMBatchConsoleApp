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
    internal class Class9
    {
        static void Main(string[] args)
        {
            Console.Write("Enter num1 : ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter num2 : ");
            int num2 = int.Parse(Console.ReadLine());
            Menu:
            Console.Write("ADD   SUB   MUL   DIV   REM   Enter Choice : ");
            string choice = Console.ReadLine();
            choice = choice.ToUpper();

            switch (choice)
            {
                case "ADD":
                    Console.WriteLine($"Sum :{num1 + num2}");
                    goto Menu;

                case "SUB":
                    Console.WriteLine($"Sub : {num1 - num2}");
                    goto Menu;
                case "MUL":
                    Console.WriteLine($"Mul : {num1 * num2}");
                    goto Menu;
                case "DIV":
                    Console.WriteLine($"Quo : {num1 / num2}");
                    goto Menu;
                case "REM":
                    Console.WriteLine($"Rem : {num1 % num2}");
                    goto Menu;
                default:
                    Console.WriteLine("Invalid choice......");
                    break;

            }
        }
    }
}
