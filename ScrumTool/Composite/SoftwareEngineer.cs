using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrumTool.Composite
{
    public class SoftwareEngineer : IEmployee
    {
        public string jobRole { get; set; }
        public string name { get; set; }
        public int salary { get; set; }

        public SoftwareEngineer(string name)
        {
            this.jobRole = "Software Engineer";
            this.salary = 320;
            this.name = name;
        }
    }
}
