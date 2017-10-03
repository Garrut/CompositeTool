using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrumTool.Composite
{
    class SoftwareArchitect : IEmployee
    {
        public string jobRole { get; private set; }
        public string name { get; set; }
        public int salary { get; private set; }

        public SoftwareArchitect (string name)
        {
            this.jobRole = "Software Architect";
            this.salary = 300;
            this.name = name;
        }
    }
}
