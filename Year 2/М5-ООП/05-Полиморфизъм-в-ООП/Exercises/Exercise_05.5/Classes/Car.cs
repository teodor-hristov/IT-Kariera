using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_05._5.Classes
{
    class Car : Vehicle
    {
        public Car(double currentFuel, double fuelConsumation)
            : base(currentFuel, fuelConsumation)
        { }

        public override void Drive(double distance)
        {
            if (base.CurrentFuel > (base.FuelConsumation + base.SeasonFuelConsumation) * distance*0.9)
            {
                base.CurrentFuel -= (base.FuelConsumation + base.SeasonFuelConsumation) * distance;
                Console.WriteLine($"Car travelled {distance} km");
            }
            else
            {
                Console.WriteLine($"Car needs refueling");
            }
        }

        public override void Refuel(double liters)
        {
            base.CurrentFuel += liters;
        }
    }
}
