using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorHandling
{
    internal class InvalidMarksException : Exception
    {
        public InvalidMarksException() 
        {
            Console.WriteLine(GetType());
        }
        public InvalidMarksException(string Message):base(Message)
        {
            
        }
    }
}
