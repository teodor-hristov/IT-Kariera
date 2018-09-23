using System;

namespace GenericMethodsAndInterfaces
{
    class SetUp
    {
        static void Main()
        {
            string[] strings = ArrayCreator.Create(5, "Pesho");
            int[] integers = ArrayCreator.Create(10, 33);
            foreach (var item in strings)
            {
                Console.WriteLine(item);
            }

        }
    }
}
