using System;

namespace Exercises_05._3
{
    class App
    {
        static void Main()
        {
            Shape rectangle = new Rectangle(4,4);
            Console.WriteLine("Rectangle:");
            Console.WriteLine(rectangle.Draw());

            Shape circle = new Circle(4,4);
            Console.WriteLine("Circle:");
            Console.WriteLine(circle.Draw());
        }
    }
}
