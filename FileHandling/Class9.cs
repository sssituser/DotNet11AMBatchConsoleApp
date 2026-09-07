using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NumbersCheck;
using SnehaSystem;
namespace FileHandling
{
    internal class Class9
    {
        static void Main(string[] args)
        {
            SnehaConsole.Write("Enter a number : ");
            int num = SnehaConsole.ReadInt();
            if (Numbers.IsPalindrome(num))
            {
                SnehaConsole.WriteLine($"{num} is a Palindrome Number");
            }
            if (Numbers.IsAdam(num))
            {
                SnehaConsole.WriteLine($"{num} is an Adam Numbr");
            }
            SnehaConsole.WriteLine($"{num} Square is : {Numbers.Square(num)} Number Reverse Is : {Numbers.Reverse(num)}");
            Numbers n = new Numbers();
            ulong num1 = Convert.ToUInt64(num);
            SnehaConsole.WriteLine($"{num} Factorial is : {n.Factorial(num1)}");
        }
    }
}
