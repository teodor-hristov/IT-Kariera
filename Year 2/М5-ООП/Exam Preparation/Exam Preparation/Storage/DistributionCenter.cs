using System;
using System.Collections.Generic;
using System.Text;
using Exam_Preparation.Vehicle;

namespace Exam_Preparation.Storage
{
    class DistributionCenter : Storage
    {
        public DistributionCenter(string name)
             : base(name, 2, 5, new Van(), new Van(), new Van())
        {

        }
    }
}
