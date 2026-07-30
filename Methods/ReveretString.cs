using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class ReveretString
    {
        public static string Reverse(string name) // name ="abc"
        {
            name = name.ToLower();
          

            string res = string.Empty;
            for(int i=name.Length-1;i>=0;i--)
            {
                res += name[i];
            }
            return res;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter a string : ");
            string str = Console.ReadLine();
            Console.WriteLine($"Given string is  : {str} and Its Reverse String is : {Reverse(str)} ");
        }
    }
}
