using System;
using System.Collections.Generic;
using System.Text;

namespace GRID
{
    class Car
    {
        private int MaxFuel = 160;
        private Tyre tyre;
        public double fuelAmount;
        public double Hp { get; set; }
        public double FuelAmount
        {
            get => this.fuelAmount;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Out of fuel!");
                }

                this.fuelAmount = Math.Min(value, MaxFuel);
            }
        }

        public Tyre Tyre
        {
            get { return tyre; }
            set { tyre = value; }
        }
        public Car(int hp,double fuelAmount, Tyre tyre)
        {
            Hp = hp;
            FuelAmount = fuelAmount;
            Tyre = tyre; ;
        }


        public double Speed
        {
            get { return (this.Hp + this.Tyre.Degradation) / this.FuelAmount; }
        }

    }
}
