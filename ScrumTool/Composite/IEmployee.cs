using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrumTool.Composite
{
    public interface IEmployee
    {
        string Name { get; }
        string Job { get;}
        int Age { get;}
        int Salary { get;}
    }
}
