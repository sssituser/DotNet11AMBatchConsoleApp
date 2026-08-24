using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorHandling
{ 
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.Write("Enter num1 : ");
                    int num1 = int.Parse(Console.ReadLine());
                    Console.Write("Enter num2 : ");
                    int num2 = int.Parse(Console.ReadLine());
                    if (num2 == 0)
                    {
                        Console.WriteLine("Hi Iam In if block");
                        throw new DivideByZeroException("You have Entered the value is zero");
                    }
                    Console.WriteLine($"Quo : {num1 / num2}");
                }
                catch (DivideByZeroException dx)
                {
                    Console.WriteLine($"num2 can't be zero : {dx.Message}");
                }
                catch (FormatException)
                {
                    Console.WriteLine($"Enter Only Numbers with out decimal values");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error Occured : {ex}");
                }
                finally
                {
                    Console.WriteLine("===========================");
                    Console.WriteLine("Thankyou Visit Again");
                    Console.WriteLine("===========================");

                }
               

            }
        }
    }
}
