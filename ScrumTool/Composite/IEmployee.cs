using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrumTool.Composite
{
    public interface IEmployee
    {
        int salary { get; }
        string name { get; set; }
        string jobRole { get; }

        

    }
}
