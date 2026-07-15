using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatements
{
    internal class Class10
    {
        static void Main(string[] args)
        {
            int price = 0;
        Menu:
            Console.Write("1.IDLY  2.DOSA   3.POORI  4.BONDA  5.Total: ");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    price += 40;
                    goto Menu;
                case 2:
                    price += 50;
                    goto Menu;
                case 3:
                    price += 60;
                    goto Menu;
                case 4:
                    price += 40;
                    goto Menu;
                case 5:
                    Console.WriteLine($"Total Amount : {price}");
                    price = 0;
                    goto Menu;
                default:
                    Console.WriteLine("Invalid choice : ");
                    goto Menu;
            }

        }
    }
}
