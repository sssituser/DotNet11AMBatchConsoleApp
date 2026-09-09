using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsProject
{
    internal class Studentt : IComparable<Studentt>
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }

        public int Marks { get; set; }

        public Studentt(int StudentId, string StudentName, int Marks)
        {
            this.StudentId = StudentId;
            this.StudentName = StudentName;
            this.Marks = Marks;
        }

        public override string ToString()
        {
            return $"{StudentId}\t{StudentName}\t{Marks}";
        }

        public int CompareTo(Studentt other)
        {
           if(StudentId>other.StudentId) return -1 ;
           if(StudentId<other.StudentId) return 1 ;
            return 0;
        }
    }
}
