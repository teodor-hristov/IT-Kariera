using System;
using System.Collections.Generic;
using System.Text;
using Exam_Preparation.Vehicle;

namespace Exam_Preparation.Storage
{
    class AutomatedWarehouse : Storage
    {
        private const int DefaultCapacity = 1;
        private const int DefaultGarageSlots = 2;

        public AutomatedWarehouse(string name)
            : base(name, DefaultCapacity, DefaultGarageSlots, new List<Vehicle.Vehicle>() { new Truck()})
        {
        }
    }
}
