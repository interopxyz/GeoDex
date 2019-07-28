using System;

namespace Geodex.Curves.Spiral
{
    public class Coth : Curve
    {
        public double A = 1;
        public Coth() : base()
        {

        }

        public Coth(double a) : base()
        {
            this.A = a;
        }

        public Coth(double t, double a) : base()
        {
            this.A = a;
            this.T = t;
        }

        protected override void Evaluate()
        {
            double s = t * Math.PI;

            double u = Math.Cos(2 * A * s) - Math.Cosh(2 * s);

            p.X = (-1) * Math.Sinh(2 * s) / u;
            p.Y = Math.Sin(2 * A * s) / u;
        }
    }
}
