using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises_05._4
{
    interface IAnimal : IMakeNoise, IMakeTrick
    {
        void Perform();
    }
}
