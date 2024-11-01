namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cow cow = new("Sari inek");
            Lion lion = new("white lion", true);
            Animal[] animals = { cow, lion };

            foreach (var animal in animals)
            {
                if (animal is Lion)
                {
                    Meat meat = new("deer", 1000);
                    animal.EatFood(meat);
                }
                if (animal is Cow)
                {
                    Grass grass = new("hay", 400);
                    animal.EatFood(grass);
                }
            }
        }
    }
}