using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet11AMBatchConsoleApp
{
    internal class Class16
    {
        static void Main(string[] args)
        {
            
            Console.Write("Entr intger 1 : ");
            int i1 = int.Parse(Console.ReadLine());

            Console.Write("Enter Integer 2 : ");

            int i2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Float Value1 : ");
            float f1 = Convert.ToSingle(Console.ReadLine());

            Console.Write("Enter Float value 1 : ");
            float f2 = float.Parse(Console.ReadLine());

            Console.Write("Enter Double value 1 :");
            double d1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Double Value 2 : ");
            double d2 = double.Parse(Console.ReadLine());

            Console.Write("Enter  Decimal Value1 : ");
            decimal dm1 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Enter Decimal Value2 : ");
            decimal dm2 = decimal.Parse(Console.ReadLine());
         }
    }
}
