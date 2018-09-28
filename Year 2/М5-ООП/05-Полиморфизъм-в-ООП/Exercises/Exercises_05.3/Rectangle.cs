using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises_05._3
{
    sealed class Rectangle : Shape
    {
        private double area;
        public Rectangle(double height, double width)
            : base(height, width)
        {}

        public override double calculateArea()
        {
            this.area = Width * Height;
            return this.area;
        }

        public override double calculatePerimeter()
        {
            this.area = 2*(Width + Height);
            return this.area;
        }

        public override string Draw()
        {
            string temp = "";
            for (int i = 0; i < Height; i++)
            {
                temp += new string('-', (int)Width)+"\n";
            }
            return temp;
        }
    }
}
