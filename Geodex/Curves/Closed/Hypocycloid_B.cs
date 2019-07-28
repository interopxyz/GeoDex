using System;

namespace Geodex.Curves.Closed
{
    public class Hypocycloid_B : Curve
    {
        public double Rotations = 1;

        public Hypocycloid_B() : base()
        {

        }

        public Hypocycloid_B(double rotations) : base()
        {
            this.Rotations = rotations;
        }

        public Hypocycloid_B(double t, double rotations) : base()
        {
            this.Rotations = rotations;
            this.T = t;
        }

        protected override void Evaluate()
        {
            double s = t * Math.PI;
            double u = (Rotations - 1);

            p.X = u * Math.Cos(s) + Math.Cos(u * s);
            p.Y = u * Math.Sin(s) - Math.Sin(u * s);
        }
    }
}
