using System;
using façadePattern.abstracted;

namespace façadePattern.façade
{
    public class HomeTheaterFacade : IHomeTheaterFacade
    {
        private readonly DvdPlayer _dvdPlayer;
        private readonly Projector _projector;
        private readonly TheaterLights _theaterLights;

        public HomeTheaterFacade(
            DvdPlayer dvdPlayer,
            Projector projector,
            TheaterLights theaterLights)
        {
            _dvdPlayer = dvdPlayer;
            _projector = projector;
            _theaterLights = theaterLights;
        }

        public void WatchMovie(string movie)
        {
            Console.WriteLine($"Get ready to watch movie {movie}");
            _dvdPlayer.On();
            _projector.On();
            _projector.TvMode();
            _theaterLights.Off();
            _dvdPlayer.Play();
        }

        public void EndMovie()
        {
            Console.WriteLine($"Ending movie");
            _theaterLights.On();
            _dvdPlayer.Off();
            _projector.Off();
        }
    }
}
