using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var lot = new CarLot();

            var tannerCar = new Car();
            tannerCar.Year = 2016;
            tannerCar.Make = "Volkswagen";
            tannerCar.Model = "Jetta";
            tannerCar.EngineNoise = "vroom";
            tannerCar.HonkNoise = "honk";
            tannerCar.IsDrivable = true;

            lot.Cars.Add(tannerCar);

            var anthonyCar = new Car()
            {
                Year = 2017,
                Make = "GMC",
                Model = "Terrain",
                EngineNoise = "brrrr",
                HonkNoise = "beep beep",
                IsDrivable = true
            };
            lot.Cars.Add(anthonyCar);

            var oldCar = new Car(2003, "Lexus", "RX350", "BRRRR", "BEEP", false);
            lot.Cars.Add(oldCar);
            //TODO

            tannerCar.MakeEngineNoise(tannerCar.EngineNoise);
            anthonyCar.MakeEngineNoise(anthonyCar.EngineNoise);
            oldCar.MakeEngineNoise(oldCar.EngineNoise);

            tannerCar.MakeHonkNoise(tannerCar.HonkNoise);
            anthonyCar.MakeHonkNoise(anthonyCar.HonkNoise);
            oldCar.MakeHonkNoise(oldCar.HonkNoise);

            CarLot._numberOfCars = 0;
            foreach(var car in lot.Cars)
            {
                Console.WriteLine($"Year: {car.Year} Make: {car.Make} Model {car.Model}");
                CarLot._numberOfCars += 1;
            }

            Console.WriteLine($"Number of Cars: {CarLot._numberOfCars}");
        }
    }
}
