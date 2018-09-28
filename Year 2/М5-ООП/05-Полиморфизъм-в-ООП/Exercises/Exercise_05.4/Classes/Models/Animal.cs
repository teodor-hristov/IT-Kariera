using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises_05._4
{
    abstract class Animal : IAnimal
    {
        abstract public string MakeNoise();

        abstract public string MakeTrick();
       
        public void Perform()
        {
            Console.WriteLine(MakeNoise());
            Console.WriteLine(MakeTrick());
        }
    }
}
