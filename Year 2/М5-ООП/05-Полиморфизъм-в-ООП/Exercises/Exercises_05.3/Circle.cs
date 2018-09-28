using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises_05._3
{
    sealed class Circle : Shape
    {
        private double area;
        private double r_in;
        private double r_out;
        private double r;
        public Circle(double height, double width)
            : base(height, width)
        { }

        public override double calculateArea()
        {
            this.area = Math.PI*Math.Pow((Width/2),2);
            return this.area;
        }

        public override double calculatePerimeter()
        {
            this.area = 2 * Math.PI*(Width/2);
            return this.area;
        }

        public override string Draw()
        {
            string temp = "";
            r = Width / 2;
            r_in = r - 0.4;
            r_out = r + 0.4;

            for (double y = r; y >= -r; --y)
            {
                for (double x = -r; x < r_out; x += 0.5)
                {
                    double value = x * x + y * y;
                    if (value >= r_in * r_in && value <= r_out * r_out)
                    {
                        temp += "*";
                    }
                    else if (value < r_in * r_in && value < r_out * r_out)
                    {
                        temp +="*";
                    }
                    else
                    {
                        temp += " ";
                    }
                }

                temp += "\n";
            }
            return temp;
        }
    }
}
