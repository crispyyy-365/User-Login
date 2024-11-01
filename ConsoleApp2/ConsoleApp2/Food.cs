using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal abstract class Food
    {
        public int _calorie;

        public int Calorie
        {
            get { return _calorie; }
            set
            {
                if (value < 0)
                {
                    value = 0;
                }
                _calorie = value;
            }
        }
        public Food(int calorie)
        {
            Calorie = calorie;
        }
    }
}
