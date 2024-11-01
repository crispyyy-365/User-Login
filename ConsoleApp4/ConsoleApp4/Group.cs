using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Group 
    {
        public int _num {  get; set; }
        public string _category { get; set; }
        public string _name { get; set; } 
        public bool _isOnline { get; set; }
        public int _limit { get; set; }

        Student[] students = new Student[0];

        public Group(int num, string category, bool isOnLine)
        {
            _num = num;
            _category = category;
            _isOnline = isOnLine;
        }
    }
}
