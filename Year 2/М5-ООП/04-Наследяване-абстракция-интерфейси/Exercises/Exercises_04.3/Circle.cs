using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises_04._3
{
    class Circle : ColoredFigure
    {
        public Circle(string color, int size)
            : base(color, size)
        { }


        public override double GetArea()
        {
            double s = Math.PI* Math.Pow(base.Size,2);
            return s;
        }

        public override string GetName() => "Circle";


    }
}
