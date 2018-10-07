using System;
using System.Collections.Generic;
using System.Text;

namespace GRID
{
    class EnduranceDriver : Driver
    {
        public EnduranceDriver(string name, Car car)
            : base(name, car)
        {
            base.Speed = base.Speed * 1.3;
        }
    }
}
