using System.ComponentModel;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Storage<string> storage = new();
            List<string> list = new List<string>();

            storage.Add("Milk");
            storage.Add("Cereal");
            storage.Add("egg");

            storage.Remove("egg");
            storage.GetAll();
            var a = storage.Find(x => x == "egg");
            Console.WriteLine(a);
        }
    }
}
