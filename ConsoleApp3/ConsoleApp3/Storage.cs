using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Storage<T>
    {
        List<T> items = new List<T>();
        public void Add(T item)
        {
            items.Add(item);
        }
        public void Remove(T item)
        {
            items.Remove(item);
        }
        public void GetAll()
        {
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
        }
        public T Find(Func<T, bool> predicate)
        {
            return Find(predicate);
        }
    }
}
