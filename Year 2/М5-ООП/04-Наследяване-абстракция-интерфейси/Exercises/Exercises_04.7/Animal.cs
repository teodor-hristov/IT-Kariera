using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises_04._7
{
    abstract class Animal : IMakeNoise, IMakeTrick
    {
        private int age;
        private string name;

        public Animal(string name,int age)
        {
            this.Age = age;
            this.Name = name;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public virtual string MakeNoise()
        {
            string str = $"My name is {this.Name}. I am {this.Age} old.";
            return str;
        }

        public virtual string MakeTrick() => "Look at my trick!";
    }
}
