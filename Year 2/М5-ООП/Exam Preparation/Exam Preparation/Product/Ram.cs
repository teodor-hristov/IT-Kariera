using System;
using System.Collections.Generic;
using System.Text;

namespace Exam_Preparation
{
    class Ram : Product
    {
        public Ram(double price)
            : base(price)
        {
            this.Weight = 0.1;
        }
    }
}
