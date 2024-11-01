using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Lion : Animal
    {
        public bool IsPrideLeader {  get; set; } 

        public Lion(string breed , bool isPrideLeader) : base (breed)
        {
            IsPrideLeader = isPrideLeader;
        }
        public override void MakeSound()
        {
            Console.WriteLine("roaaaarghhh");
        }
        public override void EatFood(Food food)
        {
            if(food is Grass)
            {
                MakeSound();
            }
            if(food is Meat)
            {
                Console.WriteLine("ugurla qidalandi !");
            }
        }
    }
}
