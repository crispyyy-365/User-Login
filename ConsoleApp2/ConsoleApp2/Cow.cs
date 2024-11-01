using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Cow : Animal
    {

        public Cow(string breed) : base(breed) { }
        
        public void ProduceMilk()
        {
            Console.WriteLine("milk produced !");
        }
        public override void MakeSound()
        {
            Console.WriteLine("mooooo");
        }
        public override void EatFood(Food food)
        {
           if (food is Meat)
            {
                MakeSound();
            }
           if(food is Grass)
            {
                Console.WriteLine("ugurla qidalandi !");
            }
        }
    }
}
