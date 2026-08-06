using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConsoleApp
{
    internal class Studentt
    {
        private int studentId;
        private string studentName;
        private int age;
        public int Age
        {
            get { return age; }
            set
            {
                if (value <= 0 || value > 120)
                {
                    Console.WriteLine("Age is not Valid Age Must Be 1 - 120");
                }
                else
                {
                    age = value;
                }
            }
        }

        public string StudentName
        {
            get { return studentName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Stdent Name Can't be Empty or Null");
                }
                else
                {

                    studentName = value;
                }
            }
        }

        public int StudentId
        {
            get { return studentId; }

            set
            {

                if (value > 100)
                {
                    studentId = value;
                }
                else
                {
                    Console.WriteLine("ID Can't be -ve or Zero");
                }

            }
        }

    }
}
