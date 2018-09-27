using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercises_04._8
{
    class SetUps
    {
        public static void PrintFakeIds(List<string> fakeIds)
        {
            foreach (string item in fakeIds)
            {
                Console.WriteLine(item);
            }
        }

        public static void CheckingAllIds(List<Citizenship> ids,List<string> fakeIds, string lastNums)
        {
            foreach (Citizenship item in ids)
            {
                if (item.Check(lastNums))
                {
                    fakeIds.Add(item.Id);
                }
            }
        }
        static void Main()
        {
            List<Citizenship> ids = new List<Citizenship>();
            List<string> fakeIds = new List<string>();

            Citizenship citizen;

            string[] commands;
            string lastNums;

            while (true)
            {
                commands = Console.ReadLine()
                    .Split(" ")
                    .ToArray();

                if (commands.Length == 2)
                {
                    citizen = new Robot(commands[0], commands[1]);
                    ids.Add(citizen);
                    citizen = null;
                }
                else if (commands.Length == 3)
                {


                    citizen = new Human(commands[0], int.Parse(commands[1]), commands[2]);
                    ids.Add(citizen);
                    citizen = null;
                }
                else
                {
                    break;
                }
                
            }

            lastNums = Console.ReadLine();

            CheckingAllIds(ids,fakeIds,lastNums);

            PrintFakeIds(fakeIds);



        }

    }
}

