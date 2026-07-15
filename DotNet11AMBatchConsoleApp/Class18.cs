using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet11AMBatchConsoleApp
{
    internal class Class18
    {
        /*
         *  ++ Increment  POST INCREMENT   PRE INCREMENT
         *  -- Decrement  POST DECREMENT   PRE DECREMENT
         *  x = 10
         *  x++  x = 11
         *   or
         *  ++x  x = 11
         *  
         *  y = 20
         *  y--  y = 19
         *  or
         *  --y  y = 19
         *  
         *  ++x++// syntax error
         */
        static void Main(string[] args)
        {
            int x = 10;
            Console.WriteLine($"x = {++x}");  // x = 11
            Console.WriteLine($"x = {x}");   //  x = 11

        }
    }
}
