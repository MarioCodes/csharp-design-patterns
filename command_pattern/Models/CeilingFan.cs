using System;

namespace commandPattern.Models
{
    public class CeilingFan
    {
        private readonly string _location;

        public CeilingFan(string location)
        {
            _location = location;
        }

        public void On()
        {
            Console.WriteLine($"{_location} ceiling fan is on");
        }

        public void Off()
        {
            Console.WriteLine($"{_location} ceiling fan off");
        }
    }
}