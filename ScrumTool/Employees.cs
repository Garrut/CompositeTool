using ScrumTool.Composite;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrumTool
{
    public delegate void AddEmployeeToList(IEmployee employee);

    public static class Employees
    {
        private static ObservableCollection<IEmployee> AllEmployees = new ObservableCollection<IEmployee>();

        public static void AddEmployee(IEmployee employee)
        {
            AllEmployees.Add(employee);
        }

        public static ObservableCollection<IEmployee> returnEmployees()
        {
            if(AllEmployees != null)
            {
                return AllEmployees;
            }
            else
            {
                throw new Exception("Employees is not initialized!");
            }
        }

        public static void RemoveEmployeeFromList(IEmployee employee)
        {
            throw new NotImplementedException();
        }
    }
}
