using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsProject
{
    internal class StudentIdComparer : IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
            if (x.StudentId < y.StudentId) return -1;
            if (x.StudentId > y.StudentId) return 1;
            return 0;
        }
    }
}
