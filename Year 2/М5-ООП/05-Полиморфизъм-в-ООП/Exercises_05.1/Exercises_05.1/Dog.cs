using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises_05._1
{
    class Dog : Animal
    {
        public Dog(string name, string food)
            : base(name, food)
        {}

        public override string ExplainMyself()
        {
            return "nz...";
        }
    }
}
