using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises_05._1
{
    class Animal
    {
        private string name;
        private string favouriteFood;

        public Animal(string name, string food)
        {
            Name = name;
            FavoiuriteFood = food;
        }

        public string FavoiuriteFood
        {
            get { return favouriteFood; }
            set { favouriteFood = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public virtual string ExplainMyself()
        {
            return "";
        }

    }
}
