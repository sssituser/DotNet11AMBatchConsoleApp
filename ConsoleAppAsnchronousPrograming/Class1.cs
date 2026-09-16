using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAsnchronousPrograming
{
    internal class Class1
    {
        static async Task Main (string[] args)
        {
            Console.WriteLine("Started Program");
            Task order = TakeOrder();
            Console.WriteLine("Doing Other Task");
            await DrinkingWater();
            await order;
            Console.WriteLine("Program Stoped");
        }
        public static async Task TakeOrder ()
        {
            Console.WriteLine("Dosa Order Taken");
            Console.WriteLine("Prepaing the Dosa takes 5 mins");
            await Task.Delay(5000);
            Console.WriteLine("Dosaprepared");
        }

        public static async Task DrinkingWater ()
        {
            Console.WriteLine("Drinking Water");
        }
    }
}
