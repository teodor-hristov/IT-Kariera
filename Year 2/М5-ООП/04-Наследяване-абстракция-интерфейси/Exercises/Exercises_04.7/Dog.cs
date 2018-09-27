using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises_04._7
{
    class Dog : Animal
    {
        public Dog(string name, int age) : base(name, age)
        {
        }

        public override string MakeNoise() => "Bau!";

        public override string MakeTrick() => "WINTER IS COMMING!";
    }
}
