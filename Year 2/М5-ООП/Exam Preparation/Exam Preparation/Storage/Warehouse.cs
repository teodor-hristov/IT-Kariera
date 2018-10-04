using System;
using System.Collections.Generic;
using System.Text;
using Exam_Preparation.Vehicle;

namespace Exam_Preparation.Storage
{
    class Warehouse : Storage
    {
        public Warehouse(string name)
             : base(name, 10, 10, new Semi(), new Semi(), new Semi())
        {

        }
    }
}
