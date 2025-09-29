using BasicBuilder.Director;
using BasicBuilder.Director.interfaces;
using builderPattern.Builder;
using builderPattern.Builder.interfaces;
using builderPattern.Models;
using Newtonsoft.Json;
using System;

namespace builderPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ICarBuilder builder = new CarBuilder();
            ICarDirector director = new CarDirector();

            Car myCar = director.ConstructSportsCar(builder);
            Console.WriteLine($"built car -> {JsonConvert.SerializeObject(myCar)}");
        }

    }
}
