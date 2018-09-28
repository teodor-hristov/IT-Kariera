using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises_05._4
{
    class Dog : Animal,IAnimal
    {
        public override string MakeNoise() => "Bau";

        public override string MakeTrick() => "Meh..";


    }
}
