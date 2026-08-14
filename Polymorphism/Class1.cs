using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{

    class Areas
    {
        public void Area(int side)
        {
            Console.WriteLine($"Area of a Square is :{side*side}");
        }
        public void Area(int length,int breadth)
        {
            Console.WriteLine($"Area of a Rectangle is :{length * breadth}");
        }
        public void Area(double radius)
        {
            Console.WriteLine($"Area of a Circl is :{3.14 * radius*radius}");
        }
    }




    internal class Class1
    {
        static void Main(string[] args)
        {
            Areas areas = new Areas();
            areas.Area(5);
            areas.Area(5.2);
            areas.Area(5,2);
        }
    }
}
