using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAsnchronousPrograming
{
    internal class Class2
    {
        static async Task Main (string[] args)
        {
            Console.WriteLine("Breakfast Started");
            Task Dosa = DosaOrder();
            Console.WriteLine("Doing Other Taks");
            Task idly = Idly();
            await idly;
            await Dosa;
            Console.WriteLine("Breakfast Completed");
            
        }
        public static async Task DosaOrder ()
        {
            Console.WriteLine("Dosa Order Taken");
            Console.WriteLine("Waiting time is their for preparation");
            await Task.Delay(5000);
            Console.WriteLine("Dosa Prepared");
        }
        public static async Task Idly ()
        {
            Console.WriteLine("Idly Order Taken");
            Console.WriteLine("No Waiting time is their for preparation");
            Console.WriteLine("Idly Given");
        }
    }
}
