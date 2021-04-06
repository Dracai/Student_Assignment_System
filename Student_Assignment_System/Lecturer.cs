using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Student_Assignment_System
{
    [Serializable]
    class Lecturer : Person
    {
        public string LecturerID { get; set; }
        public string LecturerPassword { get; set; }
        public List<string> ModulesToTeach { get; set; }
        public DateTime DateOfHire { get; set; }

        public Lecturer(
            string pname, DateTime pDOB, string pAddress, string pPPSNumber, string LecturerID, string LecturerPassword, List<string> ModulesToTeach, DateTime DateOfHire)
            : base(pname, pDOB, pAddress, pPPSNumber)
        {
            this.LecturerID = LecturerID;
            this.LecturerPassword = LecturerPassword;
            this.ModulesToTeach = ModulesToTeach;
            this.DateOfHire = DateOfHire;
        }

        ~Lecturer()
        {

        }

        public override string ToString()
        {
            return String.Join(",", base.ToString(), this.LecturerID, this.LecturerPassword, this.ModulesToTeach, this.DateOfHire);
        }





    }
}
