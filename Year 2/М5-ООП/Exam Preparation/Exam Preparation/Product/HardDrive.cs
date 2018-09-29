using System;
using System.Collections.Generic;
using System.Text;

namespace Exam_Preparation
{
    class HardDrive : Product
    {
        public HardDrive(double price, double weight)
            : base(price)
        {
            this.Weight = 1;
        }
    }
}
