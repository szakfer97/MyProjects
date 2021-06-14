using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;

namespace EmployeeSort
{
    class EmployeesReader : Employee
    {
        private String fileName;
        public EmployeesReader(String fileName)
        {
            this.fileName = fileName;
        }
        public List<Employee> Read()
        {
            Console.WriteLine("Reading from [" + this.fileName + "]");
            List<Employee> Employee = new List<Employee>();
            string[] lines = File.ReadAllLines(this.fileName);
            CultureInfo provider = CultureInfo.InvariantCulture;
            foreach (string line in lines)
            {
                string[] tokens = line.Split(' ');
                string firstName = tokens[0];
                string lastName = tokens[1];
                DateTime employmentDate = DateTime.ParseExact(tokens[2], "dd/MM/yyyy", provider);
                Employee a = new Employee(firstName, lastName, employmentDate);
                Employee.Add(a);
            }
            return Employee;
        }
    }
}
