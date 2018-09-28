using System;
using System.Collections.Generic;
using System.Text;
using Exercise_05._7.Interfaces.Models;

namespace Exercise_05._7.Classes.Models
{
    abstract class Animal : IAnimal
    {
        private string animalName;
        private string animalType;
        private double animalWeight;
        private int foodEaten;
        private string livingRegion;

        public Animal(string animalType, string animalName, double animalWeight,string livingRegion)
        {
            AnimalType = animalType;
            AnimalName = animalName;
            AnimalWeight = animalWeight;
            LivingRegion = livingRegion;
            FoodEaten = 0;
        }

        public string LivingRegion
        {
            get { return livingRegion; }
            set { livingRegion = value; }
        }

        public int FoodEaten
        {
            get { return foodEaten; }
            set { foodEaten = value; }
        }

        public double AnimalWeight
        {
            get { return animalWeight; }
            set { animalWeight = value; }
        }

        public string AnimalType
        {
            get { return animalType; }
            set { animalType = value; }
        }

        public string AnimalName
        {
            get { return animalName; }
            set { animalName = value; }
        }
        public abstract void MakeSound();

        public abstract void Eat(Food type);

        public override string ToString()
        {
            return $"{this.AnimalType} [{this.AnimalName}, {this.AnimalWeight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}
