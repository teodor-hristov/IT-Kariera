using System;

namespace Exercises_04._7
{
    class App
    {
        static void Main()
        {
            Animal pupper = new Dog("Jimmy", 5);
            Console.WriteLine(pupper.MakeNoise());
            Console.WriteLine(pupper.MakeTrick());

            Animal cat = new Cat("Rocky", 69);
            Console.WriteLine(cat.MakeNoise());
            Console.WriteLine(cat.MakeTrick());

        }
    }
}
