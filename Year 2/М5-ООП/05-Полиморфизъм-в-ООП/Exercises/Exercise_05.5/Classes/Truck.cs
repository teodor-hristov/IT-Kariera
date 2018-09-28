﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_05._5.Classes
{
    class Truck : Vehicle
    {
        
        public Truck(double currentFuel, double fuelConsumation, double tankCapacity)
            : base(currentFuel, fuelConsumation, tankCapacity)
        {
            base.RefuelPercentage = 0.95;
        }

    }
}
