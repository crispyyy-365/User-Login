using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int GroupNo { get; set; }
        public string Group {  get; set; }
        public bool Type {  get; set; }

        public Student(string name, string surname, int groupNo, bool type)
        {
            Name = name;
            Surname = surname;
            GroupNo = groupNo;
            Type = type;
        }
    }
}
