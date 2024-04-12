using System;

namespace commandPattern.Models
{
    public class Stereo
    {
        private readonly string _location;

        public Stereo(string location)
        {
            _location = location;
        }

        public void On()
        {
            Console.WriteLine($"{_location} stereo is on");
        }

        public void Off()
        {
            Console.WriteLine($"{_location} stereo is off");
        }

        public void SetCd()
        {
            Console.WriteLine($"{_location} set CD in stereo");
        }

        public void SetDvd()
        {
            Console.WriteLine($"{_location} set DVD in stereo");
        }

        public void SetRadio()
        {
            Console.WriteLine($"{_location} set radio for stereo");
        }

        public void SetVolume(int volume)
        {
            Console.WriteLine($"{_location} set volume for stereo to {volume}");
        }

    }
}