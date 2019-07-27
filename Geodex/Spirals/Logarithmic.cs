using System;

namespace Geodex.Curves.Spiral
{
    public class Logarithmic : Curve
    {
        public double A = 1;
        public Logarithmic() : base()
        {

        }

        public Logarithmic(double a) : base()
        {
            this.A = a;
        }

        public Logarithmic(double t, double a) : base()
        {
            this.A = a;
            this.T = t;
        }

        protected override void Evaluate()
        {
            double s = t * Math.PI;

            double u = Math.Pow(Math.E, (A * s));

            p.X = u * Math.Cos(s);
            p.Y = u * Math.Sin(s);
        }
    }
}