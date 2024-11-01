using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPerson
{
    internal class Employee : IPerson
    {
        public static int EmployeeCount { get; set; } = 0;
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public static string CompanyName { get; set; }
        
        public Employee(string name , string surname)
        {
            Name = name;
            Surname = surname;
            Id = ++EmployeeCount;
        }
        public static void ShowEmployeeCount()
        {
            Console.WriteLine($"Total number of the employees : {EmployeeCount}.");
        }
        public void FullName()
        {
            Console.WriteLine(Name + Surname);
        }
    }
}
