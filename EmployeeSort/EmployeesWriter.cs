using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EmployeeSort
{
    class EmployeesWriter
    {
        private String fileName;
        public EmployeesWriter(String fileName)
        {
            this.fileName = fileName;
        }
        public void WriteNames(List<Employee> Employees)
        {
            Console.WriteLine("Writing to [" + this.fileName + "]");
            StreamWriter writer = new StreamWriter(this.fileName);
            foreach (Employee Employee in Employees)
            {
                writer.WriteLine(Employee.firstName + " " + Employee.lastName);
            }
            writer.Close();
        }
        public void WriteEmployment(List<Employee> Employees)
        {
            Console.WriteLine("Writing to [" + this.fileName + "]");
            StreamWriter writer = new StreamWriter(this.fileName);
            foreach (Employee Employee in Employees)
            {
                string duration = DateUtils.Duration(Employee.employmentDate);
                writer.WriteLine(Employee.firstName + " " + Employee.lastName + " " + duration);
            }
            writer.Close();
        }
    }
}
