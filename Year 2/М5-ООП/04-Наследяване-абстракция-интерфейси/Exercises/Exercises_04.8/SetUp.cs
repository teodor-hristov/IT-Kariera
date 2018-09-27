using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Exercises_04._8
{
    class SetUps
    {
        static void Main()
        {
            List<IBirthable> years = new List<IBirthable>();
            List<DateTime> filtratedYears = new List<DateTime>();

            IBirthable target;
            Robot r2d2;
            
            
            string[] commands;
            int givenYear;

            while (true)
            {
                commands = Console.ReadLine()
                    .Split(" ")
                    .ToArray();
                if(commands[0] == "End")
                {
                    break;
                }
                switch (commands[0])
                {
                    case "Pet":
                        target = new Pet(commands[1], DateTime.ParseExact(commands[2], "dd/MM/yyyy", CultureInfo.InvariantCulture));
                        years.Add(target);
                        target = null;
                        break;
                    case "Robot":
                        r2d2 = new Robot(commands[1], commands[2]);
                        r2d2 = null;
                        break;
                    case "Citizen":
                        target = new Human(commands[1],int.Parse(commands[2]),commands[3], DateTime.ParseExact(commands[4], "dd/MM/yyyy", CultureInfo.InvariantCulture));
                        years.Add(target);
                        target = null;
                        break;
                    
                }
                
            }
            
            givenYear = int.Parse(Console.ReadLine());

            foreach (IBirthable item in years)
            {
                if(item.DateOfBirth.Year == givenYear)
                {
                    filtratedYears.Add(item.DateOfBirth);
                }
            }
            foreach (DateTime item in filtratedYears)
            {
                Console.WriteLine($"{item.Day}/{item.Month}/{item.Year}");
            }

            



        }

    }
}

