using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSort
{
    class EmployeesSorting
    {
        public static int CompareByNames(Employee employee1, Employee employee2)
        {
            if (employee2.firstName.Equals(employee1.firstName))
            {
                int ret = employee1.lastName.CompareTo(employee2.lastName);
                if (ret == 0)
                {
                    return 0;
                }
                else
                {
                    return ret;
                }
            }
            else
            {
                return employee1.firstName.CompareTo(employee2.firstName);
            }
        }
        public static int CompareByEmploymentDate(Employee employee1, Employee employee2)
        {
            return employee1.employmentDate.CompareTo(employee2.employmentDate);
        }
    }
}
