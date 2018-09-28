using System;
using System.Collections.Generic;
using System.Text;
using Exercise_05._7.Interfaces.Models;

namespace Exercise_05._7.Classes.Models
{
    abstract class Food : IFood
    {
        private int quantity;
        public Food()
        {

        }
        public Food(int quantity)
        {
            Quantity = quantity;
        }
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

    }
}
