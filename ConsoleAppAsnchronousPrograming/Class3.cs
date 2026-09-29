using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAsnchronousPrograming
{
    internal class Class3
    {
        static async Task Main (string[] args)
        {
            Console.WriteLine("Program Started");
            Task<int> res1 = Square();
            Task<int> res2 = Add();
            Console.WriteLine("Doing Other Task");
            int t1 = await res1;
            Console.WriteLine($"Square : {t1}");
            int t2 = await res2;
            Console.WriteLine($"Adddition is : {t2}");
            Console.WriteLine("Execution Stopped");

        }
        public static async Task<int> Add ()
        {
            Console.WriteLine("Addition Started");
            Console.Write("Enter Num1 : ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter Num2 : ");
            int num2 = int.Parse(Console.ReadLine());
            await Task.Delay(5000);
            return num1 + num2;

        }
        public static async Task<int> Square ()
        {
            Console.Write("Enter num : ");
            int num = int.Parse(Console.ReadLine());
            await Task.Delay(6000);
            return num * num;
        }
    }
}
