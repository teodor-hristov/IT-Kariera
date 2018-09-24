using System;

namespace Exercises_04._2
{
    class SetUp
    {
        static void Main()
        {
            RandomList rndList = new RandomList();

            rndList.Add("test1");
            rndList.Add("test2");
            rndList.Add("test3");
            rndList.Add("test4");
            rndList.Add("test5");

            foreach (string item in rndList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("//"+rndList.RandomString());

            foreach (string item in rndList)
            {
                Console.WriteLine(item);
            }
        }


    }
}
