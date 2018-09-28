using System;

namespace Exercises_05._4
{
    class App
    {
        static void Main()
        {
            IAnimal dog = new Dog();
            IAnimal cat = new Cat();
            Trainer trainerBasic = new Trainer(dog);
            trainerBasic.Make();
            Trainer trainerAdvanced = new Trainer(cat);
            trainerAdvanced.Make();
        }
    }
}
