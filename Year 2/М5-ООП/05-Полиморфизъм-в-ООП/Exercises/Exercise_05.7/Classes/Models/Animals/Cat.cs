using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_05._7.Classes.Models
{
    class Cat : Felime
    {
        private string breed;

        public Cat(string animalType, string animalName, double animalWeight, string animalLivingRegion, string breed)
            : base(animalType, animalName, animalWeight, animalLivingRegion)
        {
            this.Breed = breed;
        }

        public string Breed
        {
            get { return breed; }
            set { breed = value; }
        }

        public override void Eat(Food food)
        {
            this.FoodEaten += food.Quantity;
        }

        public override void MakeSound()
        {
            Console.WriteLine("meow");
        }

        public override string ToString()
        {
            return $"{this.AnimalType} [{this.AnimalName}, {this.Breed}, {this.AnimalWeight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}
