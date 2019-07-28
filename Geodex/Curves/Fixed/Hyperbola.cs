using System;

namespace Geodex.Curves.Fixed
{
    public class Hyperbola : Curve
    {
        public double A = 1.0;
        public double B = 1.0;

        public Hyperbola() : base()
        {

        }
        public Hyperbola(double a, double b) : base()
        {
            this.A = a;
            this.B = b;
        }

        public Hyperbola(double t, double a, double b) : base()
        {
            this.A = a;
            this.B = b;
            this.T = t;
        }

        protected override void Evaluate()
        {
            double s = t * Math.PI;

            p.X = A * (1 / Math.Cos(s));
            p.Y = B * Math.Tan(s);

        }
    }
}
