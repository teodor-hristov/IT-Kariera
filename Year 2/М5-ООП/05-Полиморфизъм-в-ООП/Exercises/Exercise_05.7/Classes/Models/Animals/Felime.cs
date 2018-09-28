using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_05._7.Classes.Models
{
    abstract class Felime : Mammal
    {
        public Felime(string animalType, string animalName, double animalWeight, string animalLivingRegion)
             : base(animalType, animalName, animalWeight, animalLivingRegion)
        { }

        public abstract override void Eat(Food food);

        public abstract override void MakeSound();


        
    }
}
