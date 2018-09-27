using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises_05._1
{
    class Cat : Animal
    {
        public Cat(string name, string food)
            : base(name, food)
        {}

        public override string ExplainMyself()
        {
            return "Meow...";
        }
    }
}
