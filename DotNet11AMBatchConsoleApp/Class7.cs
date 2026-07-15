using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet11AMBatchConsoleApp
{
    internal class Class7
    {
        static void Main(string[] args)
        {
            // Initializaion
            string name = "Ram";
            string fname = "Raj";
            int age = 25;
            string edu = "B.Tech";
            float per = 86.3f;
            string area = "KPHB";
            // Display
            Console.WriteLine(name);
            Console.WriteLine(fname);
            Console.WriteLine(age);
            Console.WriteLine(edu);
            Console.WriteLine(per);
            Console.WriteLine(area);
            Console.WriteLine($"Name : {name}\n\aFather Name : {fname}\n\aAge : {age}\n\aPercentage : {edu}\n\aArea : {area}");
            Console.WriteLine($"Name : {name}\t\aFather Name : {fname}\t\aAge : {age}\t\aPercentage : {edu}\t\aArea : {area}");
       }
    }
}
