using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Assignment_System
{
    [Serializable]
    class Administrator : Person
    {
        public string AdminID { get; set; }
        public string AdminPassword { get; set; }
        public int PhoneNumber { get; set; }
        public DateTime DateOfHire { get; set; }

        public Administrator()
        {

        }
        public Administrator(string ID, string password, int pNumber, DateTime HireDate, string name, DateTime dob, string address, string ppsn) : base(name,dob,address,ppsn)
        {
            this.AdminID = ID;
            this.AdminPassword = password;
            this.PhoneNumber = pNumber;
            this.DateOfHire = HireDate;
        }

        public override string ToString()
        {
            return  String.Join(",",this.AdminID,this.PhoneNumber,this.DateOfHire) + "," + base.ToString();
        }
    }
}
