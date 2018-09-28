using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises_05._4
{
    class Cat : Animal,IAnimal
    {
        public override string MakeNoise() => "Meow";

        public override string MakeTrick() => "No trick for you! I'm too lazy";
        

    }
}
