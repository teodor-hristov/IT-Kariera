using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_05._7.Classes.Models
{
    class Mouse : Mammal
    {
        public Mouse(string animalType, string animalName, double animalWeight, string animalLivingRegion)
             : base(animalType, animalName, animalWeight,animalLivingRegion)
        {}

        public override void Eat(Food food)
        {
                this.FoodEaten += food.Quantity;
        }  

        public override void MakeSound()
        {
            Console.WriteLine("Cvar");
        }

    }
}
