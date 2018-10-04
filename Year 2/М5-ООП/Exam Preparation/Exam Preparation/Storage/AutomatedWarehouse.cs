using System;
using System.Collections.Generic;
using System.Text;
using Exam_Preparation.Vehicle;

namespace Exam_Preparation.Storage
{
    class AutomatedWarehouse : Storage
    {
        public AutomatedWarehouse(string name)
             : base(name, 1, 2, new Truck())
        {

        }
    }
}
