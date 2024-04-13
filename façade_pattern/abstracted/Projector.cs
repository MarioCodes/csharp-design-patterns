using System;

namespace façadePattern.abstracted
{
    public class Projector
    {
        public void On()
        {
            Console.WriteLine("Projector on");
        }

        public void Off()
        {
            Console.WriteLine("Projector off");
        }

        public void TvMode()
        {
            Console.WriteLine("Set tv mode");
        }

        public void WidescreenMode()
        {
            Console.WriteLine("Set widescreen mode");
        }
    }
}
