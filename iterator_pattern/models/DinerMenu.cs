using System;
using iteratorPattern.iterator;

namespace iteratorPattern.models
{
    public class DinerMenu
    {
        private const int MAX_ITEMS = 6;

        private int _numberOfItems = 0;
        public MenuItem[] MenuItems { get; private set; }

        public DinerMenu()
        {
            MenuItems = new MenuItem[MAX_ITEMS];

            AddItem("Vegetarian BLT", "(fake) Bacon with lettuce and tomato on whole wheat", true, 2.99);
            AddItem("BLT", "Bacon with lettuce & tomato on whole wheat", false, 2.99);
            AddItem("Soup of the day", "soup of the day with a side of potato salad", false, 3.29);
            AddItem("Hotdog", "a hot dog with saurkraut, relish, onions, topped iwth cheese", false, 3.05);
        }

        public void AddItem(string name, string description, bool vegetarian, double price)
        {
            MenuItem menuItem = new MenuItem(name, description, vegetarian, price);
            if (_numberOfItems > MAX_ITEMS)
            {
                Console.WriteLine("Sorry, the menu is full");
            }
            else
            {
                MenuItems[_numberOfItems] = menuItem;
                _numberOfItems++;
            }
        }

        public Iterator CreateIterator()
        {
            return new DinerMenuIterator(MenuItems);
        }

    }
}
