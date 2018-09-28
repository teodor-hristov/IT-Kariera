using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_05._7.Classes.Models
{
    class Tiger : Felime
    {
        public Tiger(string animalType, string animalName, double animalWeight, string animalLivingRegion)
            : base(animalType, animalName, animalWeight, animalLivingRegion)
        {
            this.FoodWanted = new Meat();
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
            Console.WriteLine("Idk how tiger is doing."); 
        }
       
    }
}
