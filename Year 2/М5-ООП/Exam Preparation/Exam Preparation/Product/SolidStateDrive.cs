using System;
using System.Collections.Generic;
using System.Text;

namespace Exam_Preparation.Products
{
    class SolidStateDrive : Product
    {
        public SolidStateDrive(double price, double weight)
            : base(price)
        {
            this.Weight = 0.2;
        }
    }
}


