using System;
using System.Linq;
using Exercise_05._5.Classes;


namespace Exercise_05._5
{
    class App
    {
        static void Main()
        {
            string[] objects = Console.ReadLine()
                    .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

            Vehicle car = new Car(double.Parse(objects[1]), double.Parse(objects[2]));
            car.SeasonFuelConsumation = 0.9;

            objects = Console.ReadLine()
                    .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

            Vehicle truck = new Truck(double.Parse(objects[1]), double.Parse(objects[2]));
            truck.SeasonFuelConsumation = 1.6;

            int n = int.Parse(Console.ReadLine());
            string[] commands;

            for (int i = 0; i < n; i++)
            {
                commands = Console.ReadLine()
                    .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                switch (commands[0]) {
                    case "Drive":
                        if (commands[1] == "Car")
                        {
                            car.Drive(double.Parse(commands[2]));
                        }
                        else
                        {
                            truck.Drive(double.Parse(commands[2]));
                        }
                        break;
                    case "Refuel":
                        if (commands[1] == "Car")
                        {
                            car.Refuel(double.Parse(commands[2]));
                        }
                        else
                        {
                            truck.Refuel(double.Parse(commands[2]));
                        }
                        break;
                }
            }
            Console.WriteLine($"Car: {car.CurrentFuel}");
            Console.WriteLine($"Truck: {truck.CurrentFuel}");

        }
    }
}
