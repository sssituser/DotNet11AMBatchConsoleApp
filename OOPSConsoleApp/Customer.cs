using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConsoleApp
{
    internal class Customer
    {
        internal static string company_Name;
        public static string company_Address;
        public  int customerId;
        public  string customerName;
        public  string customerAddress; // 
        // fields always must follow camel case naming convention or snake case naming convention
        // Staic member can be declared if they are common to every object
        // non static members can be declared if it is not common every object
        // static members can be accessed using classname if they are public or internal
        // non static members of a class can be accessed using object.

    }
}
