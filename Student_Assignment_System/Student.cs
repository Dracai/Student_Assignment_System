using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Assignment_System
{
    [Serializable]
    public class Student : Person
    {
        public string StudentID { get; set; }
        public string StudentPassword { get; set; }
        public string Course { get; set; }
        public string ClassGroup { get; set; }
        public DateTime DateEnrolled { get; set; }

        public Student(string pName, DateTime pDOB, string pAddress, string pPPSNumber,
            string sSID, string sPW, string course, string sClassGroup, DateTime sDateEnrolled) : base(pName, pDOB, pAddress, pPPSNumber)
        {
            this.StudentID = sSID;
            this.StudentPassword = sPW;
            this.Course = course;
            this.ClassGroup = sClassGroup;
            this.DateEnrolled = sDateEnrolled;
        }

        public override string ToString()
        {
            return String.Join(",", this.StudentID, this.ClassGroup, this.DateEnrolled) + "," + base.ToString();
        }
    }
}