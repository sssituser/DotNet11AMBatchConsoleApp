using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet11AMBatchConsoleApp
{
    internal class Class19
    {
        static void Main(string[] args)
        {
            //bool P = true;
            //bool Q = true;
            //bool R = false;
            //Console.WriteLine(P && Q && R);

            bool A = false;
            bool B = false;
            bool C = true;
            Console.WriteLine(A||B||C);

            //Console.WriteLine(A);
            //Console.WriteLine(!A);



            
        }
    }
}
/*
 *      && ---> LOGICAL AND
 *      || ---> LOGICAL OR
 *      !  ---> LOGICAL NOT
 *      
 *      && --> IF ALL THE CONDITIONS ARE TRUE RESULT IS TRUE
 *      OTHER WISE FALSE
 *      
 *      P   Q   R   P && Q && R
 *      T   T   T     T
 *      T   T   F     F
 *      T   F   T     F
 *      
 *      || ---> IF ALL THE CONDITION ARE FALSES THEN RESULT IS FALSE
 *      OTHERWISE TRUE.
 *      
 *      P   T   P||Q
 *      F   F   F
 *      T   F   T
 *      F   T   T
 *      T   T   T
 *      
 *      
 *      P   !P
 *      T   F
 *      F   T
 *      
 *      
 */