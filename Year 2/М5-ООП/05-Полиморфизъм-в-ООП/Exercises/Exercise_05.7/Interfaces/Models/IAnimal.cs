using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_05._7.Interfaces.Models
{
    interface IAnimal
    {
        string AnimalName { get; set; }
        string AnimalType { get; set; }
        double AnimalWeight { get; set; }
        string LivingRegion { get; set; }
    }
}
