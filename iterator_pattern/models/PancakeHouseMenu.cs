using System.Collections.Generic;

namespace iteratorPattern.iterator
{
    public class PancakeHouseMenu
    {
        public List<MenuItem> _menuItems { get; set; }

        public PancakeHouseMenu()
        {
            _menuItems = new List<MenuItem>();

            AddItem("KB Pancake breakfast", "Pancakes with scramblers eggs, and toast", true, 2.99);
            AddItem("Regular pancake breakfast", "Pancakes with fried eggs, sausage", false, 2.99);
            AddItem("Blueberry pancakes", "Pancakes made with fresh blueberries", true, 3.49);
            AddItem("Waffles", "Waffles, with your choice of blueberries or strawberries", true, 3.59);
        }

        public void AddItem(string name, string description, bool vegetarian, double price)
        {
            MenuItem menuItem = new MenuItem(name, description, vegetarian, price);
            _menuItems.Add(menuItem);
        }

        public Iterator CreateIterator()
        {
            return new PancakeHouseIterator(_menuItems);
        }
    }
}
