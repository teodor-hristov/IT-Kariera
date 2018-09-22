using System;
using System.Reflection;

namespace DefiningClassesExercise
{
    class App
    {
        static void Main()
        {
            int age;
            string name;
            Person person;
            Family penkovi = new Family();
            while(true)
            {
                age = int.Parse(Console.ReadLine());
                name = Console.ReadLine();
                if(age == -1)
                {
                    break;
                }
                else
                {
                    person = new Person();
                    person.Age = age;
                    person.Name = name;
                    penkovi.AddFamilyMember(person);
                }
            }
            penkovi.Print();

        }
    }
}
