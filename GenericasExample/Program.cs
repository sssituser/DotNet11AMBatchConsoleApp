using System;
using System.ComponentModel;
using System.Security.AccessControl;
/*
    It is a template which can be used to change to the data type during the execution is 
    called as Generic.
 */

namespace GenericasExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sample<double>.Display(5.6, 6.7);
            new Sample<double>().Show(8.9,8.7);
            Sample<string>.Display("abc","def");
            new Sample<bool>().Show(true, false);
            
        }
    }
}