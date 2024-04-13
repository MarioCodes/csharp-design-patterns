using System;

namespace façadePattern.abstracted
{
    public class DvdPlayer
    {
        public void On()
        {
            Console.WriteLine("dvd player on");
        }

        public void Off()
        {
            Console.WriteLine("dvd player off");
        }

        public void Pause()
        {
            Console.WriteLine("pausa dvd player");
        }

        public void Play()
        {
            Console.WriteLine("play dvd player");
        }
    }
}
