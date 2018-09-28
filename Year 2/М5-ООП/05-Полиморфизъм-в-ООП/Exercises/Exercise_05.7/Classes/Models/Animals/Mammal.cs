using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_05._7.Classes.Models
{
    abstract class Mammal : Animal
    {
        private Food foodWanted;

        public Food FoodWanted
        {
            get { return foodWanted; }
            set { foodWanted = value; }
        }

        

        public Mammal(string animalType, string animalName, double animalWeight, string animalLivingRegion)
            : base(animalType, animalName, animalWeight, animalLivingRegion)
        { 
        }


        public abstract override void Eat(Food type);


        public abstract override void MakeSound();

    }
}
