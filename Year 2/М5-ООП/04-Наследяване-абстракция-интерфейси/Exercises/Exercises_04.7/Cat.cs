using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises_04._7
{
    class Cat : Animal
    {
        public Cat(string name, int age) : base(name, age)
        {
        }

        public override string MakeNoise() => "Meow!";

        public override string MakeTrick() => "No trick for you! I'm too lazy!";
    }
}
