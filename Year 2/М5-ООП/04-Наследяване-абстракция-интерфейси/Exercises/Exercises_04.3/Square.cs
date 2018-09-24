using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises_04._3
{
    class Square : ColoredFigure
    {
        public Square(string color, int size)
            : base(color, size)
        { }


        public override double GetArea()
        {
            double s = Math.Pow(base.Size,2);
            return s;
        }

        public override string GetName() => "Square";


    }
}
