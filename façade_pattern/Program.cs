using System;
using façadePattern.abstracted;
using façadePattern.façade;

namespace adapter
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var dvdPlayer = new DvdPlayer();
            var lights = new TheaterLights();
            var projector = new Projector();
            IHomeTheaterFacade homeTheater = new HomeTheaterFacade(dvdPlayer, projector, lights);
            homeTheater.WatchMovie("something");
            Console.WriteLine();
            homeTheater.EndMovie();
        }

    }
}
