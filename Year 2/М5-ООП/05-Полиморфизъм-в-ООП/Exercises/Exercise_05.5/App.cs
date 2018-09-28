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

            Vehicle car = new Car(double.Parse(objects[1]), double.Parse(objects[2]), double.Parse(objects[3]));
            car.ExtraFuelConsumation = 0.9;

            objects = Console.ReadLine()
                    .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

            Vehicle truck = new Truck(double.Parse(objects[1]), double.Parse(objects[2]), double.Parse(objects[3]));
            truck.ExtraFuelConsumation = 1.6;

            objects = Console.ReadLine()
                    .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

            Vehicle bus = new Truck(double.Parse(objects[1]), double.Parse(objects[2]), double.Parse(objects[3]));
            bus.ExtraFuelConsumation = 1.6;

            int n = int.Parse(Console.ReadLine());
            string[] commands;

            for (int i = 0; i < n; i++)
            {
                commands = Console.ReadLine()
                    .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                switch (commands[0]) {
                    case "DriveEmpty":
                        if (commands[1] == "Truck")
                        {
                            truck.ExtraFuelConsumation = 0;
                            truck.Drive(double.Parse(commands[2]));
                            truck.ExtraFuelConsumation = 1.6;
                        }
                        else
                        {
                            bus.ExtraFuelConsumation = 0;
                            bus.Drive(double.Parse(commands[2]));
                            bus.ExtraFuelConsumation = 1.4;
                        }
                        
                        break;
                    case "Drive":
                        if (commands[1] == "Car")
                        {
                            car.Drive(double.Parse(commands[2]));
                        }
                        else if (commands[1] == "Truck")
                        {
                            truck.Drive(double.Parse(commands[2]));
                        }
                        else
                        {
                            bus.Drive(double.Parse(commands[2]));
                        }
                        break;
                    case "Refuel":
                        if (commands[1] == "Car")
                        {
                            car.Refuel(double.Parse(commands[2]));
                        }
                        else if (commands[1] == "Truck")
                        {
                            truck.Refuel(double.Parse(commands[2]));
                        }
                        else
                        {
                            bus.Refuel(double.Parse(commands[2]));
                        }
                        break;
                }
            }
            Console.WriteLine($"Car: {car.CurrentFuel}");
            Console.WriteLine($"Truck: {truck.CurrentFuel}");
            Console.WriteLine($"Bus: {bus.CurrentFuel}");

        }
    }
}
