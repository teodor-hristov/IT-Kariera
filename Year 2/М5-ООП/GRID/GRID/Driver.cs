using System;
using System.Collections.Generic;
using System.Text;

namespace GRID
{
    abstract class Driver
    {
        public double Fuel { get; set; }

        public double speed;
        public string Name { get; set; }
        public int TotalTime { get; set; }
        public double FuelConsumationPerKm { get; set; }
        public Car Car { get; set; }
        protected Driver(string name, Car car)
        {
            Name = name;
            Car = car;
        }
        protected Driver(string name, int totalTime,Car car, double fuelConsumationPerKm, double speed)
        {
            Name = name;
            TotalTime = totalTime;
            FuelConsumationPerKm = fuelConsumationPerKm;
            
            Car = car;
        }

        public virtual double Speed
        {
            get { return (this.Car.Hp + this.Car.Tyre.Degradation) / this.Car.FuelAmount; }
            set { this.speed = value; }
        }






    }
}
