using System;
using System.Collections.Generic;
using System.Text;

namespace GRID
{
    class AggressiveDriver : Driver
    {
        public AggressiveDriver(string name, Car car)
            : base(name, car)
        {
            base.FuelConsumationPerKm = 2.7;
            base.Speed = base.Speed * 1.3;
        }
    }
}
