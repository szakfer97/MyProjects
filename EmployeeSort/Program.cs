using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EmployeeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("My name is Szakacsi Ferenc-Adam");
                Console.WriteLine("Welcome to my EmployeeSort programme");
                Console.WriteLine();
                Employees Employees = new Employees();
                EmployeesReader reader = new EmployeesReader(@"..\..\Data.txt");
                List<Employee> data = reader.Read();
                for (int i = 0; i < data.Count; i++)
                {
                    Employees.Add(data.ElementAt(i));
                }
                Console.WriteLine("Before Sorting");
                Employees.Print();
                Employees.Sort(EmployeeSortEnum.Alphabetical);
                Console.WriteLine();
                Console.WriteLine("After Sorting By First/Last Names");
                Employees.Print();
                EmployeesWriter writer1 = new EmployeesWriter(@"..\..\DataNameSort.txt");
                writer1.WriteNames(Employees.getList());
                Employees.Sort(EmployeeSortEnum.EmploymentDate);
                Console.WriteLine();
                Console.WriteLine("After Sorting By Employment Date");
                Employees.Print();
                EmployeesWriter writer2 = new EmployeesWriter(@"..\..\DataEmploymentSort.txt");
                writer2.WriteEmployment(Employees.getList());
                Console.WriteLine();
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine($" {e.Message}");
            }
        }
    }
}
