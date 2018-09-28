using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_05._5.Classes
{
    class Truck : Vehicle
    {
        public Truck(double currentFuel, double fuelConsumation)
            : base(currentFuel, fuelConsumation)
        {}

        public override void Drive(double distance)
        {
            if(base.CurrentFuel >= (base.FuelConsumation + base.SeasonFuelConsumation) * distance)
            {
                base.CurrentFuel -= (base.FuelConsumation + base.SeasonFuelConsumation) * distance;
                Console.WriteLine($"Truck travelled {distance} km");
            }
            else
            {
                Console.WriteLine($"Truck needs refueling");
            }
        }

        public override void Refuel(double liters)
        {
            base.CurrentFuel += 0.95 * liters;
        }
    }
}
