using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_05._5.Interfaces
{
    interface IRefuel
    {
        double RefuelPercentage { get; set; }
        double TankCapacity { get; set; }
        double CurrentFuel { get; set; }
        double FuelConsumation { get; set; }
        void Refuel(double liters);
    }
}
