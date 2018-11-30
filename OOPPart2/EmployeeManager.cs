using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPart2
{
    public class EmployeeManager
    {

        public int GetTotalSalary(Employee[] employees) 
        {
            return employees.Sum(v => v.GetSalary());
        }

    }
}
