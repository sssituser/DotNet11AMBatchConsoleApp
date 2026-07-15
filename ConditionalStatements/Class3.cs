using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatements
{
    internal class Class3
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Temparature : ");
            int temp = int.Parse(Console.ReadLine());
            if (temp > 19)
            {
                if(temp < 26)
                {
                    Console.WriteLine("We are at Room Temparature");
                }
                else
                {
                    Console.WriteLine("We are at hot Temparature");
                }
            }
            else
            {
                Console.WriteLine("We are Cool Temparature");
            }
            
        }
    }
}
