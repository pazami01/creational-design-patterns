using System;

namespace QuestionTwo
{
    public static class TestBuilderPattern
    {
        public static void Main(string[] args)
        {
            ICarBuilder carBuilder = new SedanCarBuilder();
            ICarDirector director = new CarDirector(carBuilder);
            director.Build();
            ICar car = carBuilder.GetCar();
            Console.WriteLine(car);

            carBuilder = new SportsCarBuilder();
            director = new CarDirector(carBuilder);
            director.Build();
            car = carBuilder.GetCar();
            Console.WriteLine(car);
        }
    }
}