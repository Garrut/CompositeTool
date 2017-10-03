using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrumTool.Composite
{
    public class TeamLead : IEmployee
    {
        public ObservableCollection<IEmployee> employeeList = new ObservableCollection<IEmployee>();
        public string jobRole { get; private set; }
        public string name { get; set; }
        public int salary { get; private set; }

        public TeamLead (string name)
        {
            this.name = name;
            this.salary = 400;
            this.jobRole = "Team leader";
        }

        public void Add(IEmployee employee)
        {
            employeeList.Add(employee);
        }

        public void Remove(IEmployee employee)
        {
            employeeList.Remove(employee);
        }


    
    }
}
