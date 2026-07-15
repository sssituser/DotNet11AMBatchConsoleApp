using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet11AMBatchConsoleApp
{
    internal class Class17
    {
        static void Main(string[] args)
        {
            int num1 = 10;
            int num2 = 20;
            Console.WriteLine($"num1 : {num1}\nnum2 : {num2}");
            num1 += num2; //num1 = num1 + num2;
            Console.WriteLine($"num1 : {num1}");
            num1 -= num2; // num1 = num1-num2
            Console.WriteLine($"num1 : {num1}");
            num1 *= num2; // num1 =num1*num2
            Console.WriteLine($"num1 : {num1}");

            num1 /= num2; // num1 = num1/num2

            Console.WriteLine($"num1 : {num1}");

            num1%= num2;// num1 = num1%num2

            Console.WriteLine($"num1 : {num1}");

        }
    }
}
/*
 * + -  * / %
 * > < >= <= ==  !=
 *   =  Asignment
 *  += Additive Assignment,
 *  -= Subtractive Assigment,
 *  *= Multiplicative Assinment ,
 *  /= Divsion Assigment,
 *  %= ModeAssigment
 */