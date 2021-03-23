using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Assignment_System
{
    class Student : Person
    {
        public string StudentID { get; set; }
        public string StudentPassword { get; set; }
        public string ClassGroup { get; set; }
        public string DateEnrolled { get; set; }

        public Student(string pName, string pDOB, string pAddress, string pPPSNumber, 
            string sSID, string sPW, string sClassGroup, string sDateEnrolled) : base(pName, pDOB, pAddress, pPPSNumber)
        {
            this.StudentID = sSID;
            this.StudentPassword = sPW;
            this.ClassGroup = sClassGroup;
            this.DateEnrolled = sDateEnrolled;
        }
    }
}
