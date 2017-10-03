using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrumTool.Composite
{
    public class SoftwareEngineer : Worker
    {
        public SoftwareEngineer(string name, int age) : base(name, "Software Engineer", age, 2800)
        {
        }
    }
}
