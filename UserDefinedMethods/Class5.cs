using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserDefinedMethods
{
    internal class Class5
    {
        static void Main(string[] args)
        {
            Console.Write("Enter A number : ");
            int num = int.Parse(Console.ReadLine());


            if (PalindromeList.IsPalindrome(num))
            {
                Console.WriteLine($"{num} is Palindrome");
            }
            else
            {
                Console.WriteLine($"{num} is not  a Palinrome");
            }
            if (ArmstrongList.IsArmstrong(num))
            {
                Console.WriteLine($"{num} is an Armstrong");
            }
            else
            {
                Console.WriteLine($"{num} is not An Armstrong");
            }
            if (AdamsList.IsAdam(num))
            {
                Console.WriteLine($"{num} is an Adam number");
            }
            else
            {
                Console.WriteLine($"{num} is not An Adam number");
            }


        }
    }
}
