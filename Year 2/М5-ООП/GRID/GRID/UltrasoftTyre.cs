using System;
using System.Collections.Generic;
using System.Text;

namespace GRID
{
    class UltrasoftTyre : Tyre
    {
        private double grip;

        public double Grip
        {
            get { return grip; }
            set { grip = value; }
        }
        public UltrasoftTyre(string name, double hardness)
            : base(name, hardness)
        {
        }
        public UltrasoftTyre(double hardness, double grip)
            : base("Ultrasoft", hardness)
        {
            Grip = grip;
        }
        public override void Degradate()
        {
            this.Degradation -= this.Hardness*this.Grip;
        }
    }
}
