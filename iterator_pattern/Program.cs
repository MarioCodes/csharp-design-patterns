using iteratorPattern.iterator;
using iteratorPattern.models;
using System;

namespace iterator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // this holds List<MenuItem> ... 
            var pancakeHouseMenu = new PancakeHouseMenu();
            Iterator pancakeIterator = pancakeHouseMenu.CreateIterator();

            // this holds MenuItem[] ...
            var dinerMenu = new DinerMenu();
            Iterator dinerIterator = dinerMenu.CreateIterator();

            // ... but we're able to iterate them both with the same method
            PrintMenu(pancakeIterator);
            PrintMenu(dinerIterator);
        }

        private static void PrintMenu(Iterator iterator)
        {
            while(iterator.HasNext())
            {
                MenuItem item = iterator.Next();
                Console.WriteLine($"menuItem {item.Name}");
            }
        }

    }
}
