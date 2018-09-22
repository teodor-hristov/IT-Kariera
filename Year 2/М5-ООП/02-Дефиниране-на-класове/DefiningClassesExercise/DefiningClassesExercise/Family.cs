using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClassesExercise
{
    class Family
    {
        private List<Person> family;

        public Family()
        {
            family = new List<Person>();
        }

        public void AddFamilyMember(Person familyMember)
        {
            family.Add(familyMember);
        }
        public void Print()
        {
            foreach (Person person in family)
            {
                Console.WriteLine($"{person.Name} is {person.Age} years old");
            }
        }

    }
}
