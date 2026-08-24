using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorHandling
{
    internal class InvalidAgeException :Exception
    {
        public InvalidAgeException()
        {
            Console.WriteLine(GetType());
        }
        public InvalidAgeException(string Message):base(Message)
        {
            
        }
    }
}
