using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises_04._5._3
{
    interface ICallable
    {
        string PhoneNumber { get; set; }
        void Call();
    }
}
