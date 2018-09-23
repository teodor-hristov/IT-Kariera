using System;

namespace Generics
{
    class SetUp
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Box<string> boxOfStrings;
            string item;
            for (int i = 0; i < n; i++)
            { 
                boxOfStrings = new Box<string>();
                item = Console.ReadLine();
                boxOfStrings.Add(item);
                Console.WriteLine(boxOfStrings.ToString());
            }
        }
    }
}
