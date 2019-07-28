using System;

namespace Geodex.Curves.Volumetric
{
    public class Vivianis : Curve
    {

        public Vivianis() : base()
        {

        }

        public Vivianis(double t) : base()
        {
            this.T = t;
        }

        protected override void Evaluate()
        {
            double s = t * Math.PI;

            p.X = (1 + Math.Cos(s));
            p.Y = Math.Sin(s);
            p.Z = 2 * Math.Sin(s / 2);

        }
    }
}
