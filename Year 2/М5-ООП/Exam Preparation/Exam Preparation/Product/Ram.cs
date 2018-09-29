using System;
using System.Collections.Generic;
using System.Text;

namespace Exam_Preparation
{
    class Ram : Product
    {
        public Ram(double price, double weight)
            : base(price)
        {
            this.Weight = 0.1;
        }
    }
}
