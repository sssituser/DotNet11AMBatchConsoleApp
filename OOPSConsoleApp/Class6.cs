using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConsoleApp
{
    internal class Class6
    {
        static void Main(string[] args)
        {
            Product p1 = new Product();
            
            p1.ProductId = 123;
            p1.ProductName = "Test";
            p1.ProductPrice = 100;

            Product p2 = new Product() {ProductId=112,ProductName="abc",ProductPrice=600 };

            Console.WriteLine("=============Product-1 Details=============");
            Console.WriteLine($"Product Id    : {p1.ProductId}");
            Console.WriteLine($"Product Name  : {p1.ProductName}");
            Console.WriteLine($"Product Price : {p1.ProductPrice}");


            Console.WriteLine("=============Product-2 Details=============");
            Console.WriteLine($"Product Id    : {p2.ProductId}");
            Console.WriteLine($"Product Name  : {p2.ProductName}");
            Console.WriteLine($"Product Price : {p2.ProductPrice}");

        }
    }
}
