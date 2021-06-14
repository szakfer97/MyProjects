using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EmployeeSort
{
    class Employee : IComparable
    {
        public string firstName;
        public string lastName;
        public DateTime employmentDate;
        public Employee()
        { 
        }
        public Employee(string firstName, string lastName, DateTime employmentDate)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.employmentDate = employmentDate;
        }
        public int CompareTo(object obj)
        {
            if (obj == null)
            {
                return 1;
            }
            Employee Employee1 = obj as Employee;
            if (this.firstName.Equals(Employee1.firstName))
            {
                int ret = Employee1.lastName.CompareTo(this.lastName);
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
                return Employee1.firstName.CompareTo(this.firstName);
            }
        }
        public override string ToString()
        {
            return firstName + " " + lastName + " " + employmentDate;
        }
    }
}
