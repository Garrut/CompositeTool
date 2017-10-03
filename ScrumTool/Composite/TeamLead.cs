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
        public IEmployee Lead;

        public TeamLead(IEmployee lead)
        {
            Lead = lead;
        }

        #region Fields
        public string Name
        {
            get
            {
                return Lead.Name;
            }
        }

        public string Job
        {
            get
            {
                return Lead.Job;
            }
        }

        public int Age
        {
            get
            {
                return Lead.Age;
            }
        }
        public int Salary
        {
            get
            {
                return Lead.Salary;
            }
        }
        #endregion

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
