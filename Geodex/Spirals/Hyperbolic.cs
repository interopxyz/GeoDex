using System;

namespace Geodex.Curves.Spiral
{
    public class Hyperbolic : Curve
    {
        public double A = 1;
        public Hyperbolic() : base()
        {

        }

        public Hyperbolic(double a) : base()
        {
            this.A = a;
        }

        public Hyperbolic(double t, double a) : base()
        {
            this.A = a;
            this.T = t;
        }

        protected override void Evaluate()
        {
            double s = t * Math.PI;

            double u = A / t;

            p.X = u * Math.Cos(s);
            p.Y = u * Math.Sin(s);
        }
    }
}
