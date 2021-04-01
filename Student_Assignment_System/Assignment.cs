using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Assignment_System
{
    [Serializable]
    class Assignment
    {
        public string AssignmentID { get; set; }
        public string Name { get; set; }
        public string DateIssued { get; set; }
        public string DateDue { get; set; }
        public string ClassGroup { get; set; }
        public string Module { get; set; }
        public string LecturerID { get; set; }
        public string Description { get; set; }

        public Assignment(string assignmentID, string name, string dateIssued, string dateDue, string classGroup,
            string module, string lecturerID)
        {
            this.AssignmentID = assignmentID;
            this.Name = name;
            this.DateIssued = dateIssued;
            this.DateDue = dateDue;
            this.ClassGroup = classGroup;
            this.Module = module;
            this.LecturerID = lecturerID;
        }
    }
}
