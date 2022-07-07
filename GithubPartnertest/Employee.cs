using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GithubPartnertest
{
    internal class Employee
    {
        //properties
        public string Name { get; set; }
        public double Salary { get; set; }
        public Employee(string _name, double _salary)
        {
            Name = _name;
            Salary = _salary;
        }
    }
}
