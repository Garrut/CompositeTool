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
        AddEmployeeToList addLead = new AddEmployeeToList(Employees.AddEmployee);
        
        public ObservableCollection<IEmployee> employeeList = new ObservableCollection<IEmployee>();
        public IEmployee Lead;

        public TeamLead(IEmployee lead)
        {
            Lead = lead;
            Employees.RemoveEmployeeFromList(lead);
            addLead(this);
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
        public int EmployeeNumber
        {
            get
            {
                return Lead.EmployeeNumber;
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
