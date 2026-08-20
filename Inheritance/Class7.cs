using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.Arm;
using System.Text;

namespace Inheritance
{

    class Home
    {
        public static  int Amount = 20000;
        public void Spent(int spentamount)
        {
            Amount = Amount - spentamount;
            Console.WriteLine($"You Have Spent Rs.{spentamount}");
        }
        public void ShowBalance()
        {
            Console.WriteLine($"Balance : Rs.{Amount}");
        }
        
    }
    internal class Class7
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("========Brother - 1 Object==================");
            Home br1 = new Home();
            br1.ShowBalance();
            br1.Spent(4000);
            br1.ShowBalance();
            Console.WriteLine("========Brother - 2 Object==================");
            Home br2 = new Home();
            br2.ShowBalance();
            br2.Spent(2000);
            br2.ShowBalance();
            Console.WriteLine("========Brother - 1 & - 2 Object==================");
            br1.ShowBalance();
            br2.ShowBalance();
        }
    }
}
