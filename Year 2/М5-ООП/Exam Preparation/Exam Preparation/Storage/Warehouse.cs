using System;
using System.Collections.Generic;
using System.Text;
using Exam_Preparation.Vehicle;

namespace Exam_Preparation.Storage
{
    class Warehouse : Storage
    {
        private const int DefaultCapacity = 10;
        private const int DefaultGarageSlots = 10;

        public Warehouse(string name)
            : base(name, DefaultCapacity, DefaultGarageSlots, new List<Vehicle.Vehicle>() { new Semi(), new Semi(), new Semi() })
        {
        }
    }
}
