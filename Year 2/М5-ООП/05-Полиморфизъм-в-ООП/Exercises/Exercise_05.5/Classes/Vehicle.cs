using System;
using System.Collections.Generic;
using System.Text;
using Exercise_05._5.Interfaces;

namespace Exercise_05._5.Classes
{
    abstract class Vehicle : IDrivable, IRefuel, IExtraFuel
    {
        private double currentFuel;
        private double fuelConsumation;
        private double extraFuelConsumation;
        private double tankCapacity;
        private double refuelPercentage;

        public Vehicle(double currentFuel, double fuelConsumation, double tankCapacity)
        {
            this.CurrentFuel = currentFuel;
            this.FuelConsumation = fuelConsumation;
            this.TankCapacity = tankCapacity;
        }

        public double RefuelPercentage
        {
            get { return refuelPercentage; }
            set { refuelPercentage = value; }
        }

        public double TankCapacity
        {
            get { return tankCapacity; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Fuel must be a positive number");
                    return;
                }
                else
                {
                    tankCapacity = value;
                }
            }
        }


        public double ExtraFuelConsumation
        {
            get { return extraFuelConsumation; }
            set { extraFuelConsumation = value; }
        }


        public double FuelConsumation
        {
            get { return fuelConsumation; }
            set { fuelConsumation = value; }
        }

        public double CurrentFuel
        {
            get { return currentFuel; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Fuel must be a positive number");
                }
                else
                {
                    currentFuel = value;
                }
            }
        }



        public void Drive(double distance)
        {
            if (this.CurrentFuel >= (this.FuelConsumation + this.ExtraFuelConsumation) * distance)
            {
                this.CurrentFuel -= (this.FuelConsumation + this.ExtraFuelConsumation) * distance;
                Console.WriteLine($"Vehicle travelled {distance} km");
            }
            else
            {
                Console.WriteLine($"Vehicle needs refueling");
            }
        }


        public void Refuel(double liters)
        {
            if (this.TankCapacity < this.RefuelPercentage * liters)
            {
                Console.WriteLine("Cannot fit fuel in tank");
            }
            else
            {
                double temp = CurrentFuel;
                this.CurrentFuel = this.RefuelPercentage * liters;

                if (CurrentFuel >= 0)
                {
                    this.CurrentFuel = temp + this.RefuelPercentage * liters;
                }
            }
        }

    }
}
