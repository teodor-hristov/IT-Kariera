using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises_05._3
{
    abstract class Shape
    {
        private double height;
        private double width;

        public Shape(double height,double width)
        {
            Width = width;
            Height = height;
        }

        public double Width
        {
            get { return width; }
            set { width = value; }
        }

        public double Height
        {
            get { return height; }
            set { height = value; }
        }
        public abstract double calculatePerimeter();

        public abstract double calculateArea();

        public virtual string Draw()
        {
            return "";
        }
    }
}
