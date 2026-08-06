using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConsoleApp
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            Customer.company_Name = "SSSIT";
            Customer.company_Address = "KPHB"; // static

            Customer c1 = new Customer();
            c1.customerId = 111;
            c1.customerName = "kriran";
            c1.customerAddress = "Hyd"; // Writing

            Customer c2 = new Customer();
            c2.customerId = 112;
            c2.customerName = "Raj";
            c2.customerAddress = "NLG";

            Console.WriteLine("==================================Customer-1 Infomration==========");
            Console.WriteLine($"Cusomer ID     : {c1.customerId}");
            Console.WriteLine($"Cusomer Name   : {c1.customerName}");
            Console.WriteLine($"Cusomer Addres : {c1.customerAddress}"); // Reading the customer

            Console.WriteLine("==================================Customer-2 Infomration==========");
            Console.WriteLine($"Cusomer ID     : {c2.customerId}");
            Console.WriteLine($"Cusomer Name   : {c2.customerName}");
            Console.WriteLine($"Cusomer Addres : {c2.customerAddress}");
            Console.WriteLine("==================================Company Infomration==========");

            Console.WriteLine($"Company Name    : {Customer.company_Name}");
            Console.WriteLine($"Company Address : {Customer.company_Address}");










        }
    }
}
