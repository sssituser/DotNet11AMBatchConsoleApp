using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace UserDefinedMethods
{
    internal class Class2
    {
        //AM : public static
        //MN : IsPerfect
        //RT : boolean
        //PM : 1-integer
        public static bool IsPerfect(int num) // 6
        {
            int sum = 0;
            for (int i = 1; i < num; i++) // 1,2,3,4,5
            {
                if (num % i == 0)
                {
                    sum += i;
                }
            }
            return sum == num; 
            
        }
        static void Main(string[] args)
        {
            Console.WriteLine(IsPerfect(6));  
            Console.WriteLine(IsPerfect(12));  
            Console.WriteLine(IsPerfect(28));  
        }
    }
}
