using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTask_2
{
    class Assistant:Manager
    {
        public Employee GetFeedBack(Employee employee)
        {
            if (employee.IsSuccessfull == true)
            {
                Getpromotin(employee);
            }
            return employee;
        }
    }
}
