using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises_04._5._3
{
    interface IConnectable
    {
        string Url { get; set; }
        void Browse();
    }
}
