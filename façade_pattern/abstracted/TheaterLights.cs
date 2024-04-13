using System;

namespace façadePattern.abstracted
{
    public class TheaterLights
    {
        public void On()
        {
            Console.WriteLine("theater lights on");
        }

        public void Off()
        {
            Console.WriteLine("theater lights off");
        }

        public void Dim()
        {
            Console.WriteLine("dim theater lights");
        }
    }
}
