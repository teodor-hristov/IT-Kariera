using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises_04._5
{
    class Citizen : IPerson
    {
        private string name;
        private int age;
        public Citizen(string name, int age)
        {
            this.Age = age;
            this.Name = name;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
        public int Age
        {
            get { return this.age; }
            set
            {
                this.age = value;
            }
        }
    }
}
