using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTask_2
{
    class Manager
    {
        public Employee Getpromotin(Employee employee)
        {
            employee.Salary = employee.Salary + 100;
            return employee;
        }
    }
}
