using System;

namespace commandPattern.Models
{
    public class GarageDoor
    {
        private readonly string _location;

        public GarageDoor(string location)
        {
            _location = location;
        }

        public void Open()
        {
            Console.WriteLine($"{_location} garage door is opening");
        }

        public void Close()
        {
            Console.WriteLine($"{_location} garage door is closing");
        }
    }
}