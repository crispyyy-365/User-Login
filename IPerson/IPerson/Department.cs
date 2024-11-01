using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPerson
{
    internal class Department
    {
        public static Department[] departments = new Department[0];
        public static int DepartmentCount { get; set; } = 0;
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }

        public static Employee[] employees = new Employee[0];

        public Department(string departmentName)
        {
            DepartmentName = departmentName;
            DepartmentId = ++DepartmentCount;
        }
    
        public static void AddEmployee(Employee employee)
        {
            Array.Resize(ref employees, employees.Length + 1);
            employees[employees.Length - 1] = employee;
        }
        public static void AddDepartment(Department department)
        {
            Array.Resize(ref departments, departments.Length + 1);
            departments[employees.Length - 1]= department;
        }
        public void ShowEmployees()
        {
            for (int i = 0; i < employees.Length; i++)
            {
                Console.WriteLine(employees[i].Name + employees[i].Surname);
            }
        }
        public void ShowAllDepartments()
        {
            for (int i = 0;i < departments.Length;i++)
            {
                Console.WriteLine($"Department id : {departments[i].DepartmentId} Department name : {departments[i].DepartmentName}");
            }
        }
    }
}
