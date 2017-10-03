using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrumTool.Composite
{
    class SoftwareArchitect : Worker
    {
        public SoftwareArchitect(string name, int age) : base(name, "Software Architect", age, 3000)
        {

        }
    }
}
