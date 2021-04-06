using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Assignment_System
{
    [Serializable]
    class Module
    {
        public string ModuleCode { get; set; }
        public string ModuleName { get; set; }
        public int Credits { get; set; }
        public List<string> ClassGroups { get; set; }

        public Module()
        {

        }
        public Module(string code, string name, int creds, List<string> classgrouplist)
        {
            this.ModuleCode = code;
            this.ModuleName = name;
            this.Credits = creds;
            this.ClassGroups = classgrouplist;
        }
    }
}
