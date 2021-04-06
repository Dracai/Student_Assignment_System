using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Assignment_System
{
    [Serializable]
    public class ClassGroup
    {

        public string ClassGroupName { get; set; }
        public string Course { get; set; }
        public string YearOfStudy { get; set; }
        public int NumberOfStudents { get; set; }

        public ClassGroup(string classgroupname, string course, string year, int numstudents)
        {
            this.ClassGroupName = classgroupname;
            this.Course = course;
            this.YearOfStudy = year;
            this.NumberOfStudents = numstudents;
        }

        ~ClassGroup()
        {

        }

        public override string ToString()
        {
            return String.Join(",", this.ClassGroupName, this.Course, this.YearOfStudy, this.NumberOfStudents);
        }

    }
}
