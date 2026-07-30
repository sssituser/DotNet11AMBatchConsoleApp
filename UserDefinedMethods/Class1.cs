using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserDefinedMethods
{
    //  DigitSum    num = 123   sum = 6
    //  SumOfNums   num = 5     Sum = 15
    //  Factorial   num = 5    fact = 1*2*3*4*5
    //  MaxDigit    num = 657  MaxDigit = 7
    //  MinDigit    num = 654  MinDigit = 4
    //  Reverse     num = 123  Revere = 321
    //  ReverseString str = "arun" reverse ="nura"
    //  PalidromeNum num = 121     true  num = 123  false
    //  Armstong    num = 153  True, num = 123 False num = 370 True num = 1634 True
    //  Strong      num = 145  True
    //  FactorsOf Num   num = 12    res = 1,2,3,4,6,12.
    //  FactorsCount    num = 12    Count : 6
    //  FactorsSum      num = 4     Sum = 1+2+4 => 7
    //  PrimeCheck      num = 7     True num = 8   False
    //  PerfectNum      num = 6     1+2+3=>6   True
    //  AdamNum         num = 12    True
    //====================
    // PalindromeList start=1 end=1000  1,2,.....11,22,..99,111,121...999.
    // ArmstrongList
    // PrimeList
    // AdamList
    // PerfectLlist
    // StrongList
    //==========================================
    // GetMaxNumber
    // GetLuckNumber
    // NameScore
    // AsciiSum
    // SpinningArray



    // AM : public static
    // RT : int
    // PM : int
    // MN : DigitSum


    internal class Class1
    {
        public static int DigitSum(int num) // 456
        {
            int sum = 0;
            while (num != 0) // 456!=0-T
            {
                int digit = num % 10;
                sum += digit;
                num/=10;
            }
            return sum;
        }
        static void Main(string[] args)
        {
           

        }
    }
}
