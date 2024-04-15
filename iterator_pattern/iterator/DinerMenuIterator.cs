namespace iteratorPattern.iterator
{
    public class DinerMenuIterator : Iterator
    {
        MenuItem[] _items;
        int position = 0;

        public DinerMenuIterator(MenuItem[] items)
        {
            _items = items;
        }

        public bool HasNext()
        {
            if(position >= _items.Length || _items[position] == null) 
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
