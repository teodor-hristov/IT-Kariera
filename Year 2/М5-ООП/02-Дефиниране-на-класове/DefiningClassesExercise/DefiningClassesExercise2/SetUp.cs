using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClassesExercise2
{
    class SetUp
    {
        public static void AddRacionalNumbers(int[] numbers)
        {
            int numerator;
            int denumerator;
            RacionalNumber racionalNumber;

            for (int i = 1; i < numbers.Length; i+=2)
            {
                numerator = numbers[i-1];
                denumerator = numbers[i];
                racionalNumber = new RacionalNumber(numerator,denumerator);
                racionalNumber.Print();
               
            }
            

        }
        static void Main()
        {
            int[] numbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();
            AddRacionalNumbers(numbers);
            
            
        }
    }
}
