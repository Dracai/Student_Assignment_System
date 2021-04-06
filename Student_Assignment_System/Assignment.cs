﻿using System;
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
        public DateTime DateIssued { get; set; }
        public DateTime DateDue { get; set; }
        public string ClassGroup { get; set; }
        public string Module { get; set; }
        public string LecturerID { get; set; }
        public string Description { get; set; }

        public Assignment(string assignmentID, string name, DateTime dateIssued, DateTime dateDue, string classGroup,
<<<<<<< Updated upstream
            string module, string lecturerID, string descript)
=======
            string module, string lecturerID, string description)
>>>>>>> Stashed changes
        {
            this.AssignmentID = assignmentID;
            this.Name = name;
            this.DateIssued = dateIssued;
            this.DateDue = dateDue;
            this.ClassGroup = classGroup;
            this.Module = module;
            this.LecturerID = lecturerID;
<<<<<<< Updated upstream
            this.Description = descript;
=======
            this.Description = description;
>>>>>>> Stashed changes
        }
    }
}
