using System;
using System.Collections.Generic;
using System.Text;
using Exercise_05._5.Interfaces;

namespace Exercise_05._5.Classes
{
    abstract class Vehicle : IDrivable, IRefuel, ISeason
    {
        private double currentFuel;
        private double fuelConsumation;
        private double seasonFuelConsumation;

        public Vehicle(double currentFuel, double fuelConsumation)
        {
            this.CurrentFuel = currentFuel;
            this.FuelConsumation = fuelConsumation;
        }

        public double SeasonFuelConsumation
        {
            get { return seasonFuelConsumation; }
            set { seasonFuelConsumation = value; }
        }


        public double FuelConsumation
        {
            get { return fuelConsumation; }
            set { fuelConsumation = value; }
        }

        public double CurrentFuel
        {
            get { return currentFuel; }
            set { currentFuel = value; }
        }

        

        public abstract void Drive(double distance);


        public abstract void Refuel(double liters);
        
    }
}
