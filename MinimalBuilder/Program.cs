using builderPattern.Builder;
using builderPattern.Builder.interfaces;
using builderPattern.Models;
using Newtonsoft.Json;

ICarBuilder carBuilder = new CarBuilder();
Car myCar = carBuilder.WithMake("Renault")
    .WithModel("Clio")
    .WithYear(2020)
    .Build();

Car anotherCar = new Car
{
    Make = "Peugeot",
    Model = "208",
    Year = 2021
};

Console.WriteLine($"built car -> {JsonConvert.SerializeObject(myCar)}");