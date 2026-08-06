using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConsoleApp
{
    internal class Areas
    {
        public int Length { private get; set; }
        public int Breadth { private get; set; }
        public int Side { private get; set; }
        public double Radius { private get; set; }
        public int AreaOfRectangle
        {
            get
            {
                return Length * Breadth;
            }
        }

        public int AreaOfSquare
        {
            get
            {

                return Side * Side;
            }
        }
        public double AreaOfCircle
        {
            get
            {
                return 3.14 * Radius * Radius;
            }
        }

    }
}
