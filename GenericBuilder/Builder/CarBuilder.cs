using builderPattern.Builder.interfaces;
using builderPattern.Models;
using System;

namespace builderPattern.Builder
{
    public class CarBuilder : ICarBuilder
    {
        private Car _car = new Car();

        public ICarBuilder WithMake(string make)
        {
            _car.Make = make;
            return this;
        }

        public ICarBuilder WithModel(string model)
        {
            _car.Model = model;
            return this;
        }

        public ICarBuilder WithYear(int year)
        {
            _car.Year = year;
            return this;
        }

        public Car Build()
        {
            // you can force required validation here
            if(_car.Year < 1886)
            {
                throw new ArgumentException("Year must be 1886 or later.");
            }

            if(string.IsNullOrEmpty(_car.Make))
            {
                throw new ArgumentException("Make is required.");
            }

            return _car;
        }
    }
}
