using System;
using System.Collections;

namespace GenericMethodsAndInterfaces
{
    class SetUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Box<string> boxOfStrings = new Box<string>();
            string item;
            for (int i = 0; i < n; i++)
            {
                item = Console.ReadLine();
                boxOfStrings.Add(item);
            }
            Console.WriteLine(boxOfStrings.ToString());
            boxOfStrings.Swap("pesho","gosho");
            Console.WriteLine(boxOfStrings.ToString());
            
        }

    }
}
