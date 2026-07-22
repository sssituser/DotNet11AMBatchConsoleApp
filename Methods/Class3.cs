using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Class3
    {
        static void Main(string[] args)
        {
            string str = "welcome";
            Console.WriteLine(str); //welcome
            string res = str.ToUpper();
            Console.WriteLine(res);
            Console.WriteLine(str); //welcome

            string s1 = "kiran";
            Console.WriteLine(s1.IndexOf('k'));
            Console.WriteLine(s1.ElementAt(3));
            Console.WriteLine(s1.Replace('k','h'));
            Console.WriteLine(s1);//kiran
            string s2 = "abg";
            string s3 = "abg";
            Console.WriteLine(s2.CompareTo(s3));
        }
    }
}
