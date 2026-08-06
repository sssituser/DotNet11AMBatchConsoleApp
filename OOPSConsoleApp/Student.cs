using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConsoleApp
{
    internal class Student
    {
        private static string collegeName="SSSIT"; // camel case naming convetion or snake case 
        private int studentId;
        private string studentName;
        private string studentEmail; 

        public static string CollegeName  // Read Property Pascal Case
        {
            get
            {
                return collegeName;
            }
           
        }
        public int StudentId
        {
            get
            {
                return studentId;
            }
            set
            {
                studentId= value;
            }
        }
        public string StudentName
        {
            get
            {
                return studentName;
            }
            set
            {
                 studentName= value;
            }
        }
        public string StudentEmail
        {
            get
            {
                return studentEmail;
            }
            set
            {
                studentEmail= value;
            }
        }

    }
}
