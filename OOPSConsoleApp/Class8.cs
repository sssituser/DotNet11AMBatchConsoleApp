using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConsoleApp
{
    internal class Class8
    {
        static void Main(string[] args)
        {
            Areas r = new Areas();
            r.Length = 5;
            r.Breadth = 4;
            r.Side = 8;
            r.Radius = 6.7;
           
            Console.WriteLine(r.AreaOfRectangle);
            Console.WriteLine(r.AreaOfSquare);
            Console.WriteLine(r.AreaOfCircle);
        }
    }
}
