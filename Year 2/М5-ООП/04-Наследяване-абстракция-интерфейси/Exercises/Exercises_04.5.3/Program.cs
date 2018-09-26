using System;
using System.Linq;

namespace Exercises_04._5._3
{
    class App
    {
        static void Main()
        {
            Smartphone sp = new Smartphone();

            string[] numbers = Console.ReadLine()
                   .Split(" ")
                   .ToArray();
            string[] urls = Console.ReadLine()
                   .Split(" ")
                   .ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                sp.PhoneNumber = numbers[i];
                if (sp.PhoneNumber != null)
                {
                    sp.Call();
                }
            }
            for (int i = 0; i < urls.Length; i++)
            {
                sp.Url = urls[i];
                if (sp.Url != null)
                {
                    sp.Browse();
                }

            }
        }
    }
}
