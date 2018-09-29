using System;
using System.Collections.Generic;
using System.Text;

namespace Exam_Preparation
{
    abstract class Product
    {
        private double price;
        private double weight;
        public double DefaultWeight { get; set; }

        public Product(double price)
        {
            this.Price = price;
        }

        public Product(double price, double weight)
        {
            this.Price = price;
            this.Weight = weight;
        }

        public double Weight
        {
            get { return weight; }
            set
            {
                if (price >= 0)
                {
                    weight = value;
                }
                else
                {
                    throw new InvalidOperationException("Price cannot be negative!");
                }
            }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }


    }
}
