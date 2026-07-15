using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet11AMBatchConsoleApp
{
    internal class Class2
    {
        static void Main(string[] args)
        {
            string hName = "Mahesbabu";
            string hFname = "Krishna";
            int age = 45;
            string industry = "MovieIndustry";

            Console.WriteLine("===============First Way Display====================");
            Console.WriteLine(hName);
            Console.WriteLine(hFname);
            Console.WriteLine(age);
            Console.WriteLine(industry);
            Console.WriteLine("===============Second Way Place Holder Display========");

            Console.WriteLine("{0}             {1}                 {2}              {3}",hName,hFname,age,industry);
            
            Console.WriteLine("===============Third Way string Interpolution Display========");
            
            Console.WriteLine($"{hName}       {hFname}         {age}         {industry}");
           
            
            Console.WriteLine($"Hero Name : {hName}\n Father Name : {hFname}\nAge =  {age}\nIndutry =   {industry}");

        }
    }
}
