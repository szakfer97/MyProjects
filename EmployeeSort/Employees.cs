using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EmployeeSort
{
    class Employees : IEmployee
    {
        private List<Employee> listofEmployees;
        public Employees()
        {
            this.listofEmployees = new List<Employee>();
        }
        public List<Employee> getList()
        {
            return this.listofEmployees;
        }
        public void Add(Employee Employee)
        {
            this.listofEmployees.Add(Employee);
        }
        public void Remove(Employee Employee)
        {
            this.listofEmployees.Remove(Employee);
        }
        public List<Employee> Sort(EmployeeSortEnum EmployeeSortEnum)
        {
            if (EmployeeSortEnum == EmployeeSortEnum.Alphabetical)
            {
                this.listofEmployees.Sort(EmployeesSorting.CompareByNames);
            }
            else if (EmployeeSortEnum == EmployeeSortEnum.EmploymentDate)
            {
                this.listofEmployees.Sort(EmployeesSorting.CompareByEmploymentDate);
            }
            return this.listofEmployees;
        }
        public List<Employee> Sort(Comparison<Employees> comparison)
        {
            return null;
        }
        public void Print()
        {
            for (int i = 0; i < listofEmployees.Count; i++)
            {
                Console.WriteLine(listofEmployees.ElementAt(i));
            }
            Console.WriteLine();
        }
    }
}
