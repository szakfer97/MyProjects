using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EmployeeSort
{
    interface IEmployee
    {
        void Add(Employee employee);
        void Remove(Employee employee);
        List<Employee>Sort(Comparison<Employees>comparison);
    }
}
