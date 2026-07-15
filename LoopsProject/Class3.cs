using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsProject
{
    internal class Class3
    {
        // -1 , -2 , -3 ,......-10
        // -10 , -9,-7,.........-1
        static void Main(string[] args)
        {
            int start = -1;
            int end = -20;
            do
            {
                Console.WriteLine(start);
                start--;
            } while (start >= end);

        }
    }
}
