using System;
using fa�adePattern.abstracted;
using fa�adePattern.fa�ade;

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
