using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace LoopsProject
{
    internal class Class19
    {
        static void Main(string[] args)
        {
            int num = 5;
            for(int start = 1; start <= num; start++)
            {
                Console.WriteLine($"start = {start}");
                for(int j = 1; j <= 10; j++)
                {
                    Console.WriteLine($"{start}x {j} = {start*j}");
                }
            }
        }
    }
}
