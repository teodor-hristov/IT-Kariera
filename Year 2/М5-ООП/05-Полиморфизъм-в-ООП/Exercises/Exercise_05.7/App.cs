using System;
using Exercise_05._7.Classes.Models;

namespace Exercise_05._7
{
    class App
    {
        public static void Cat()
        {
            Animal cat = new Cat("Cat", "Gray", 1.1, "Home", "Persian");
            Food food = new Vegetable(4);
            cat.MakeSound();
            cat.Eat(food);
            Console.WriteLine(cat.ToString());
        }

        public static void Tiger()
        {
            Animal tiger = new Tiger("Tiger", "Tayson", 1.1, "Persian");
            Food food = new Vegetable(4);
            tiger.MakeSound();
            tiger.Eat(food);
            Console.WriteLine(tiger.ToString());
        }

        public static void Zebra()
        {
            Animal zebra = new Zebra("Zebra", "Vihar", 167.7, "Africa");
            Food food = new Vegetable(4);
            zebra.MakeSound();
            zebra.Eat(food);
            Console.WriteLine(zebra.ToString());
        }

        public static void Mouse()
        {
            Animal mouse = new Mouse("Mouse", "Lil Didi", 0.5, "NY Ghetto");
            Food food = new Vegetable(4);
            mouse.MakeSound();
            mouse.Eat(food);
            Console.WriteLine(mouse.ToString());
        }

        static void Main()
        {

            Cat();
            Tiger();
            Zebra();
            Mouse();

        }
    }
}
