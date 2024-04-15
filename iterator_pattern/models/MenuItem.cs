namespace iteratorPattern.iterator
{
    public class MenuItem
    {
        public string _name { get; set; }
        public string _description { get; set; }
        public bool _vegetarian { get; set; }
        public double _price { get; set; }

        public MenuItem(
            string name,
            string description,
            bool vegetarian,
            double price)
        {
            _name = name;
            _description = description;
            _vegetarian = vegetarian;
            _price = price;
        }
    }
}
