using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises_04._3
{
    abstract class ColoredFigure
    {
        public ColoredFigure(string color,int size)
        {
            this.Color = color;
            this.Size = size;
        }

        public string Color { get;}

        public int Size { get; set; }

       public void Show()
        {
            Console.WriteLine(this.Color);
        }
        public abstract string GetName();

        public abstract double GetArea();

        public override string ToString()
        {
            return $"{this.GetName()}: \n Color: {this.Color} \n Size: {this.Size} \n Area: {this.GetArea():f2}";
        }
    }
}
