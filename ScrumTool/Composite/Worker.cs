using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrumTool.Composite
{
    public abstract class Worker : IEmployee
    {
        public Worker(string name, string job, int age, int salary)
        {
            this.Name = name;
            this.Job = job;
            this.Age = age;
            this.Salary = salary;
        }

        public string Name { get; set; }
        public string Job { get; set; }
        public int Age { get; set; }
        public int Salary { get; set; }
    }
}
