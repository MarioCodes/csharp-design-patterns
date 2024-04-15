using System.Collections.Generic;

namespace iteratorPattern.iterator
{
    public class PancakeHouseIterator : Iterator
    {
        List<MenuItem> _items;
        int position = 0;

        public PancakeHouseIterator(List<MenuItem> items)
        {
            _items = items;
        }

        public bool HasNext()
        {
            if(position >= _items.Count || _items[position] == null)
            {
                return false;
            } else
            {
                return true;
            }
        }

        public MenuItem Next()
        {
            return _items[position++];
        }
    }
}
