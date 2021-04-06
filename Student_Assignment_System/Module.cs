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

        public Module(string code, string name, int creds)
        {
            this.ModuleCode = code;
            this.ModuleName = name;
            this.Credits = creds;
        }
    }
}
