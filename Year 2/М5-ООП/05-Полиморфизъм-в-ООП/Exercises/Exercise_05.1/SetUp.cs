using System;

namespace Exercises_05._1
{
    class SetUp
    {
        static void Main()
        {
            Animal cat = new Cat("Maca","Manja");
            Console.WriteLine(cat.ExplainMyself());
            Animal dog = new Dog("Roy", "Kotka");
            Console.WriteLine(dog.ExplainMyself());
        }
    }
}
