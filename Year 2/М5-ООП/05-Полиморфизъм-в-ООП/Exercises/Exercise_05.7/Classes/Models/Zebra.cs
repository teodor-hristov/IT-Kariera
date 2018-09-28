using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_05._7.Classes.Models
{
    class Zebra : Mammal
    {
        public Zebra(string animalType, string animalName, double animalWeight, string animalLivingRegion)
            : base(animalType, animalName, animalWeight, animalLivingRegion)
        {
            this.FoodWanted = new Vegetable();
        }

        public override void Eat(Food food)
        {
            if (food.GetType() != this.FoodWanted.GetType())
            {
                Console.WriteLine($"{this.AnimalType} are not eating that type of food!");
            }
            else
            {
                this.FoodEaten += food.Quantity;
            }
        }

        public override void MakeSound()
        {
            Console.WriteLine("Just some zebra things.");
        }
        
    }
}
