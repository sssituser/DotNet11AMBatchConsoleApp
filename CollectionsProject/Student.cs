using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsProject
{
    internal class Student : IComparable<Student>
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }

        public int Marks { get; set; }

        public Student(int StudentId, string StudentName, int Marks)
        {
         this.StudentId = StudentId;
         this.StudentName = StudentName;
        this.Marks = Marks;
        }

        public override string ToString()
        {
            return $"{StudentId}\t{StudentName}\t{Marks}";
        }
        public int CompareTo(Student other)
        {
            if (this.StudentId < other.StudentId) return -1;
            if (this.StudentId > other.StudentId) return 1;
            return 0;
        }
    }
}
